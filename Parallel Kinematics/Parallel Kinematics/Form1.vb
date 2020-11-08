'Option Explicit On

Imports System.Runtime.InteropServices
Imports Emgu.CV.UI
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Text.RegularExpressions



Public Class main
    Inherits System.Windows.Forms.Form
    Dim cal_data(65) As Byte

#Region "Global Variables"
    Dim image_capture As Bitmap
    Private Const VendorID As Integer = &H1234
    Private Const ProductID As Integer = &H1234
    Private Const BufferInSize As Integer = 129
    Private Const BufferOutSize As Integer = 129
    Dim BufferIn(BufferInSize) As Byte
    Dim BufferOut(BufferOutSize) As Byte
    Dim i As Byte
    Dim devices As String = Nothing
    Dim count As Integer = 0
    Dim temp As Integer
    Dim usb_status As Boolean
#End Region


#Region "Emgu_object_detection"
    Public Sub PerformShapeDetection()
        If Not image_capture Is Nothing Then

            Dim img As Emgu.CV.Image(Of Emgu.CV.Structure.Bgr, Byte) = New Emgu.CV.Image(Of Emgu.CV.Structure.Bgr, Byte)(image_capture) '.Resize(400, 400, CvEnum.INTER.CV_INTER_LINEAR, True)

            Dim gray As Emgu.CV.Image(Of Emgu.CV.Structure.Gray, Byte) = img.Convert(Of Gray, Byte).PyrDown.PyrUp()

            Dim cannyThreshold As New Gray(110)      '120
            Dim cannyThresholdLink As New Gray(140)  '130
            Dim circleAccumulatorThreshold As New Gray(450) '450
            Dim circles As CircleF() = gray.HoughCircles(cannyThreshold, circleAccumulatorThreshold, 4.0, 15.0, 5, 50)(0)


            Dim circleImage As Image(Of Bgr, Byte) = img

            DataGridView1.Rows.Clear()

            count = 0

            For Each circle In circles
                ' If circle.Radius > 30 And circle.Radius < 60 Then
                If count < 8 Then
                    circleImage.Draw(circle, New Bgr(Color.Yellow), 1)
                    '  End If
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows.Item(count).Cells(0).Value = count
                    temp = circle.Center.X
                    DataGridView1.Rows.Item(count).Cells(1).Value = temp
                    BufferOut(4 * count + 1) = temp / 25 ' temp / 4
                    BufferOut(4 * count + 3) = temp Mod 4


                    temp = circle.Center.Y
                    DataGridView1.Rows.Item(count).Cells(2).Value = temp
                    BufferOut(4 * count + 2) = temp / 25 'temp / 4
                    BufferOut(4 * count + 4) = temp Mod 4
                    DataGridView1.Rows.Item(count).Cells(3).Value = circle.Radius
                    DataGridView1.Rows.Item(count).Cells(4).Value = 44
                    DataGridView1.Rows.Item(count).Cells(5).Value = 0.0
                End If
                count = count + 1
            Next

            picEdge.Image = circleImage.ToBitmap
            found.Text = count.ToString
            ' hidWriteEx(&H1111, &H2222, BufferOut(0))
        End If

    End Sub

    Private Sub Timer_capture_Tick(sender As Object, e As EventArgs) Handles Timer_capture.Tick
        On Error Resume Next

        Dim data As IDataObject




        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        data = Clipboard.GetDataObject()
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then

            image_capture = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)

            data = Nothing
        End If
        PerformShapeDetection()

    End Sub
#End Region

#Region "initialization"
    Public Sub New()
        MyBase.New()


        InitializeComponent()



    End Sub

    

 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectToHID(Me)
        LoadDeviceList()
        If Not devices = Nothing Then
            StartToolStripMenuItem.Enabled = True
            'lstDevices.SelectedIndex = 0
            StopToolStripMenuItem.Enabled = False
        Else

            StartToolStripMenuItem.Enabled = False
        End If


        StopToolStripMenuItem.Enabled = False
        FixedPositionToolStripMenuItem.Enabled = False
        ManualToolStripMenuItem.Enabled = False
        Timer1.Enabled = True
        Timer_capture.Enabled = False
        DataGridView1.Rows.Add(8)
        usb_status = False
    End Sub
    

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region
#Region "general"
    Private Sub main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        DisconnectFromHID()
        If Not image_capture Is Nothing Then
            ClosePreviewWindow()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        DisconnectFromHID()
        If Not image_capture Is Nothing Then
            ClosePreviewWindow()
        End If
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_status.Text = My.Computer.Clock.LocalTime.ToLocalTime.ToString
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about1 As New about
        about1.Show()
    End Sub
#End Region

#Region "camera"
    Const WM_CAP As Short = &H400

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean



    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0

        ' 
        ' Load name of all avialable devices into the lstDevices
        '

        Do
            '
            '   Get Driver name and version
            '
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)

            '
            ' If there was a device add device name to the list
            '
            If bReturn Then devices = strName
            x += 1
        Loop Until bReturn = False
    End Sub

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = picCapture.Height
        Dim iWidth As Integer = picCapture.Width


        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PicCapture.Handle.ToInt32, 0)



        ' Connect to device
        '
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale
            '
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, 640, 480, _
                    SWP_NOMOVE Or SWP_NOZORDER)

            Timer_capture.Enabled = True
        Else
            '
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)


        End If
    End Sub
    Private Sub ClosePreviewWindow()

        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        '

        image_capture = Nothing

        DestroyWindow(hHwnd)
    End Sub


    
    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        ClosePreviewWindow()
        StartToolStripMenuItem.Enabled = True
        Timer_capture.Enabled = False
    End Sub
 
    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        iDevice = 0
        OpenPreviewWindow()

        StopToolStripMenuItem.Enabled = True
        StartToolStripMenuItem.Enabled = False

    End Sub

   

#End Region

#Region "USB"

    Public Sub OnUnplugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID Then
            hidSetReadNotify(hidGetHandle(VendorID, ProductID), False)
            ' ** YOUR CODE HERE **
            hw_status.Text = "Disconnected"
            Button1.Enabled = False
            usb_status = False
        End If
    End Sub

    Public Sub OnPlugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID Then
            ' ** YOUR CODE HERE **
            hw_status.Text = "Connected"
            Button1.Enabled = True

            usb_status = True
        End If
    End Sub
    Public Sub OnChanged()
        ' get the handle of the device we are interested in, then set
        ' its read notify flag to true - this ensures you get a read
        ' notification message when there is some data to read...
        Dim pHandle As Integer
        pHandle = hidGetHandle(VendorID, ProductID)
        hidSetReadNotify(hidGetHandle(VendorID, ProductID), True)
    End Sub

    Public Sub OnRead(ByVal pHandle As Integer)
        ' read the data (don't forget, pass the whole array)...
        If hidRead(pHandle, BufferIn(0)) Then


            'SEBIN c JOSEPH, WRITE HERE the code for read event


        End If

    End Sub


  
#End Region


  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' cal_data(1) = Integer.Parse(Text_X.Text)
        ' cal_data(2) = Integer.Parse(Text_Y.Text)
        ' cal_data(3) = Integer.Parse(Text_Z.Text)
        ' cal_data(4) = Integer.Parse(Text_C.Text)
        hidWriteEx(&H1234, &H1234, BufferOut(0))
    End Sub
End Class


