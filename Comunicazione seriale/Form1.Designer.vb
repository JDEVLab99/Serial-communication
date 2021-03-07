<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.portComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.baudComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.RichTextBox()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.initButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.leggi = New System.Windows.Forms.Button()
        Me.scrivi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comunicazione Master-Slave tra PC-Master e DGH1711-Slave"
        '
        'portComboBox
        '
        Me.portComboBox.FormattingEnabled = True
        Me.portComboBox.Location = New System.Drawing.Point(38, 140)
        Me.portComboBox.Name = "portComboBox"
        Me.portComboBox.Size = New System.Drawing.Size(180, 39)
        Me.portComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'baudComboBox
        '
        Me.baudComboBox.FormattingEnabled = True
        Me.baudComboBox.Items.AddRange(New Object() {"300", "9600", "19200"})
        Me.baudComboBox.Location = New System.Drawing.Point(38, 244)
        Me.baudComboBox.Name = "baudComboBox"
        Me.baudComboBox.Size = New System.Drawing.Size(180, 39)
        Me.baudComboBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bit/Sec"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(38, 329)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(248, 35)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Uscita Digitale 0E"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(38, 385)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(250, 35)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Uscita Digitale 0D"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ing. Digitale 07"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 530)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ing. Digitale 08 "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(491, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Stringa Inviata"
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(493, 166)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(366, 163)
        Me.InputTextBox.TabIndex = 10
        Me.InputTextBox.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(491, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Stringa Ricevuta"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(493, 425)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(364, 152)
        Me.OutputTextBox.TabIndex = 12
        Me.OutputTextBox.Text = ""
        '
        'writeButton
        '
        Me.writeButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.writeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.writeButton.Location = New System.Drawing.Point(987, 155)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(203, 84)
        Me.writeButton.TabIndex = 13
        Me.writeButton.Text = "writeButton"
        Me.writeButton.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.closeButton.Location = New System.Drawing.Point(987, 304)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(203, 83)
        Me.closeButton.TabIndex = 14
        Me.closeButton.Text = "closeButton"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'initButton
        '
        Me.initButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.initButton.Location = New System.Drawing.Point(987, 442)
        Me.initButton.Name = "initButton"
        Me.initButton.Size = New System.Drawing.Size(207, 82)
        Me.initButton.TabIndex = 15
        Me.initButton.Text = "initButton"
        Me.initButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 468)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 31)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 530)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 31)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "-"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 1
        Me.VScrollBar1.Location = New System.Drawing.Point(987, 39)
        Me.VScrollBar1.Maximum = 10
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(23, 80)
        Me.VScrollBar1.TabIndex = 18
        '
        'leggi
        '
        Me.leggi.Location = New System.Drawing.Point(778, 68)
        Me.leggi.Name = "leggi"
        Me.leggi.Size = New System.Drawing.Size(90, 36)
        Me.leggi.TabIndex = 19
        Me.leggi.Text = "leggi"
        Me.leggi.UseVisualStyleBackColor = True
        '
        'scrivi
        '
        Me.scrivi.Location = New System.Drawing.Point(874, 67)
        Me.scrivi.Name = "scrivi"
        Me.scrivi.Size = New System.Drawing.Size(88, 37)
        Me.scrivi.TabIndex = 20
        Me.scrivi.Text = "scrivi"
        Me.scrivi.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1268, 621)
        Me.Controls.Add(Me.scrivi)
        Me.Controls.Add(Me.leggi)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.initButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.writeButton)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.baudComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.portComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form1"
        Me.Text = "Comunicazione seriale RS32"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents portComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents baudComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OutputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents writeButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents initButton As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents leggi As System.Windows.Forms.Button
    Friend WithEvents scrivi As System.Windows.Forms.Button

End Class
