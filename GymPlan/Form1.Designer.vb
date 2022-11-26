<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txUserACC = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lkPass = New System.Windows.Forms.LinkLabel()
        Me.lkAccount = New System.Windows.Forms.LinkLabel()
        Me.cbshowP = New System.Windows.Forms.CheckBox()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DeepPink
        Me.Label1.Location = New System.Drawing.Point(25, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DeepPink
        Me.Label2.Location = New System.Drawing.Point(25, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txUserACC
        '
        Me.txUserACC.Location = New System.Drawing.Point(207, 101)
        Me.txUserACC.Name = "txUserACC"
        Me.txUserACC.Size = New System.Drawing.Size(239, 31)
        Me.txUserACC.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.DeepPink
        Me.btnLogin.Location = New System.Drawing.Point(123, 351)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(248, 34)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lkPass
        '
        Me.lkPass.ActiveLinkColor = System.Drawing.Color.DeepPink
        Me.lkPass.AutoSize = True
        Me.lkPass.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lkPass.LinkColor = System.Drawing.Color.White
        Me.lkPass.Location = New System.Drawing.Point(302, 477)
        Me.lkPass.Name = "lkPass"
        Me.lkPass.Size = New System.Drawing.Size(144, 20)
        Me.lkPass.TabIndex = 5
        Me.lkPass.TabStop = True
        Me.lkPass.Text = "Forgot Password ?"
        '
        'lkAccount
        '
        Me.lkAccount.ActiveLinkColor = System.Drawing.Color.DeepPink
        Me.lkAccount.AutoSize = True
        Me.lkAccount.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lkAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lkAccount.LinkColor = System.Drawing.Color.White
        Me.lkAccount.Location = New System.Drawing.Point(66, 477)
        Me.lkAccount.Name = "lkAccount"
        Me.lkAccount.Size = New System.Drawing.Size(124, 20)
        Me.lkAccount.TabIndex = 6
        Me.lkAccount.TabStop = True
        Me.lkAccount.Text = "Need Account ?"
        Me.lkAccount.UseMnemonic = False
        '
        'cbshowP
        '
        Me.cbshowP.AutoSize = True
        Me.cbshowP.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.cbshowP.ForeColor = System.Drawing.Color.DeepPink
        Me.cbshowP.Location = New System.Drawing.Point(351, 252)
        Me.cbshowP.Name = "cbshowP"
        Me.cbshowP.Size = New System.Drawing.Size(132, 23)
        Me.cbshowP.TabIndex = 7
        Me.cbshowP.Text = "show password"
        Me.cbshowP.UseVisualStyleBackColor = True
        '
        'txPassword
        '
        Me.txPassword.Location = New System.Drawing.Point(207, 197)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.Size = New System.Drawing.Size(239, 31)
        Me.txPassword.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(512, 570)
        Me.Controls.Add(Me.txPassword)
        Me.Controls.Add(Me.cbshowP)
        Me.Controls.Add(Me.lkAccount)
        Me.Controls.Add(Me.lkPass)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txUserACC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txUserACC As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lkPass As LinkLabel
    Friend WithEvents lkAccount As LinkLabel
    Friend WithEvents cbshowP As CheckBox
    Friend WithEvents txPassword As TextBox
End Class
