Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Form1
    Dim myport As Array
    Dim flag As Boolean
    Delegate Sub SetTextCallBack(ByVal [text] As String)


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myport = SerialPort.GetPortNames()
        portComboBox.Items.AddRange(myport)
        SerialPort1.Write("AT+CLIP=1")
        writeButton.Enabled = False
    End Sub

    Private Sub writeButton_Click(sender As System.Object, e As System.EventArgs) Handles writeButton.Click
        SerialPort1.Write(InputTextBox.Text & vbCr)

    End Sub

    Private Sub closeButton_Click(sender As System.Object, e As System.EventArgs) Handles closeButton.Click
        SerialPort1.Close()
        initButton.Enabled = True
        writeButton.Enabled = False
        closeButton.Enabled = False
        Timer1.Enabled = False
    End Sub

    Private Sub initButton_Click(sender As System.Object, e As System.EventArgs) Handles initButton.Click
        SerialPort1.PortName = portComboBox.Text
        SerialPort1.BaudRate = baudComboBox.Text
        SerialPort1.Open()
        Timer1.Enabled = True
        initButton.Enabled = False
        writeButton.Enabled = True
        closeButton.Enabled = True
    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim paperino As String
        paperino = (SerialPort1.ReadExisting())
        If paperino.Contains("3427981154") = True Then
            SerialPort1.Write("ATD+393925894446;" + vbCr)
        End If
    End Sub

    Private Sub ReceivedText(ByVal text As String)
        If Me.OutputTextBox.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            OutputTextBox.Text &= Mid(text, 2, 1)
        End If
    End Sub

    Private Sub ReceivedLabel9(ByVal text As String)
        If Me.Label9.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf ReceivedLabel9)
            Me.Invoke(x, New Object() {(text)})
        Else
            Label9.Text &= Mid(text, 2, 1)
        End If
    End Sub

    Private Sub ReceivedLabel8(ByVal text As String)
        If Me.Label8.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf ReceivedLabel8)
            Me.Invoke(x, New Object() {(text)})
        Else
            Label8.Text &= Mid(text, 2, 1)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        flag = Not flag
        Dim mia As String

            mia = SerialPort1.ReadExisting()

        InputTextBox.Text = mia

        If mia.Contains("3427981154") = True Then
            SerialPort1.Write("ATD+393925894446;" + vbCr)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Timer1.Enabled = False
        If (CheckBox1.Checked) Then
            InputTextBox.Text = "$1SB0E"
            SerialPort1.Write(InputTextBox.Text & vbCr)
        Else
            InputTextBox.Text = "$1CB0E"
            SerialPort1.Write(InputTextBox.Text & vbCr)
        End If
        Timer1.Enabled = True
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Timer1.Enabled = False
        If (CheckBox2.Checked) Then
            InputTextBox.Text = "$1SB0D"
            SerialPort1.Write(InputTextBox.Text & vbCr)
        Else
            InputTextBox.Text = "$1CB0D"
            SerialPort1.Write(InputTextBox.Text & vbCr)
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub portComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles portComboBox.SelectedIndexChanged

    End Sub


    Private Sub scrivi_Click(sender As System.Object, e As System.EventArgs) Handles scrivi.Click
        Dim a, b, c As String
        a = 10 - VScrollBar1.Value
        If (a < 10) Then
            b = "0" & a & "000.00"
        Else
            b = a & "000.00"
        End If
        c = "$2AO+" & b & vbCr
        SerialPort1.Write(c)
        InputTextBox.Text = c
        Thread.Sleep(400)
        c = (SerialPort1.ReadExisting())
    End Sub


    Private Sub leggi_Click(sender As System.Object, e As System.EventArgs) Handles leggi.Click
        SerialPort1.Write("$3RD" & vbCr)
        Thread.Sleep(400)
        OutputTextBox.Text = (SerialPort1.ReadExisting())
    End Sub
End Class
