<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        BtnLogin = New Button()
        BtnRegister = New Button()
        Label1 = New Label()
        Label2 = New Label()
        BGLogin = New PictureBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TxtLinkDisini = New LinkLabel()
        CType(BGLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnLogin.BackColor = Color.Orchid
        BtnLogin.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = SystemColors.ControlText
        BtnLogin.Location = New Point(233, 354)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnRegister.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRegister.Location = New Point(233, 393)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(94, 29)
        BtnRegister.TabIndex = 1
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(78, 258)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(78, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' BGLogin
        ' 
        BGLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BGLogin.Image = My.Resources.Resources.account
        BGLogin.Location = New Point(209, 60)
        BGLogin.Name = "BGLogin"
        BGLogin.Size = New Size(156, 159)
        BGLogin.SizeMode = PictureBoxSizeMode.StretchImage
        BGLogin.TabIndex = 4
        BGLogin.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.Location = New Point(175, 251)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(234, 27)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.Location = New Point(175, 302)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(234, 27)
        txtPassword.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(101, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(343, 23)
        Label3.TabIndex = 7
        Label3.Text = "IDENTITAS KEPENDUDUKAN DIGITAL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 472)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 20)
        Label4.TabIndex = 8
        Label4.Text = "NIK anda sudah terdaftar?"
        ' 
        ' TxtLinkDisini
        ' 
        TxtLinkDisini.AutoSize = True
        TxtLinkDisini.Location = New Point(257, 472)
        TxtLinkDisini.Name = "TxtLinkDisini"
        TxtLinkDisini.Size = New Size(73, 20)
        TxtLinkDisini.TabIndex = 9
        TxtLinkDisini.TabStop = True
        TxtLinkDisini.Text = "cek disini."
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 585)
        Controls.Add(TxtLinkDisini)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(BGLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnRegister)
        Controls.Add(BtnLogin)
        Name = "FormLogin"
        Text = "FormLogin"
        CType(BGLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BGLogin As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLinkDisini As LinkLabel
End Class
