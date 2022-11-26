<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPass
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
        Me.btnChange = New System.Windows.Forms.Button()
        Me.txNewPass = New System.Windows.Forms.TextBox()
        Me.txConfirm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnChange.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnChange.Location = New System.Drawing.Point(142, 348)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(112, 34)
        Me.btnChange.TabIndex = 0
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'txNewPass
        '
        Me.txNewPass.Location = New System.Drawing.Point(176, 128)
        Me.txNewPass.Name = "txNewPass"
        Me.txNewPass.Size = New System.Drawing.Size(150, 31)
        Me.txNewPass.TabIndex = 1
        '
        'txConfirm
        '
        Me.txConfirm.Location = New System.Drawing.Point(176, 236)
        Me.txConfirm.Name = "txConfirm"
        Me.txConfirm.Size = New System.Drawing.Size(150, 31)
        Me.txConfirm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(33, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "confirmation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(33, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "New Password"
        '
        'ForgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepPink
        Me.ClientSize = New System.Drawing.Size(419, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txConfirm)
        Me.Controls.Add(Me.txNewPass)
        Me.Controls.Add(Me.btnChange)
        Me.Name = "ForgotPass"
        Me.Text = "ForgotPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChange As Button
    Friend WithEvents txNewPass As TextBox
    Friend WithEvents txConfirm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
