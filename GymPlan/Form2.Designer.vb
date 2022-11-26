<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.txUserReg = New System.Windows.Forms.TextBox()
        Me.txCreaPRE = New System.Windows.Forms.TextBox()
        Me.txEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lkAccRE = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrer.Location = New System.Drawing.Point(194, 425)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(191, 34)
        Me.btnRegistrer.TabIndex = 0
        Me.btnRegistrer.Text = "Register"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'txUserReg
        '
        Me.txUserReg.Location = New System.Drawing.Point(318, 132)
        Me.txUserReg.Name = "txUserReg"
        Me.txUserReg.Size = New System.Drawing.Size(150, 31)
        Me.txUserReg.TabIndex = 1
        '
        'txCreaPRE
        '
        Me.txCreaPRE.Location = New System.Drawing.Point(318, 298)
        Me.txCreaPRE.Name = "txCreaPRE"
        Me.txCreaPRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txCreaPRE.Size = New System.Drawing.Size(150, 31)
        Me.txCreaPRE.TabIndex = 2
        '
        'txEmail
        '
        Me.txEmail.Location = New System.Drawing.Point(318, 215)
        Me.txEmail.Name = "txEmail"
        Me.txEmail.Size = New System.Drawing.Size(150, 31)
        Me.txEmail.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(143, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(126, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Create Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(143, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email"
        '
        'lkAccRE
        '
        Me.lkAccRE.ActiveLinkColor = System.Drawing.Color.Snow
        Me.lkAccRE.AutoSize = True
        Me.lkAccRE.BackColor = System.Drawing.Color.DeepPink
        Me.lkAccRE.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lkAccRE.ForeColor = System.Drawing.Color.Snow
        Me.lkAccRE.LinkColor = System.Drawing.Color.Black
        Me.lkAccRE.Location = New System.Drawing.Point(62, 535)
        Me.lkAccRE.Name = "lkAccRE"
        Me.lkAccRE.Size = New System.Drawing.Size(124, 20)
        Me.lkAccRE.TabIndex = 9
        Me.lkAccRE.TabStop = True
        Me.lkAccRE.Text = "Account Exists?"
        Me.lkAccRE.UseMnemonic = False
        '
        'registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepPink
        Me.ClientSize = New System.Drawing.Size(618, 626)
        Me.Controls.Add(Me.lkAccRE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txEmail)
        Me.Controls.Add(Me.txCreaPRE)
        Me.Controls.Add(Me.txUserReg)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Name = "registration"
        Me.Text = "registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrer As Button
    Friend WithEvents txUserReg As TextBox
    Friend WithEvents txCreaPRE As TextBox
    Friend WithEvents txEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lkAccRE As LinkLabel
End Class
