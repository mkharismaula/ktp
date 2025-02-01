<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCekNik
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
        Label1 = New Label()
        TxtCekNik = New TextBox()
        BtnCariNik = New Button()
        TxtAlamat = New TextBox()
        TxtNamaLengkap = New TextBox()
        TxtTanggalLahir = New TextBox()
        TxtTempatLahir = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 20)
        Label1.TabIndex = 0
        Label1.Text = "NIK"
        ' 
        ' TxtCekNik
        ' 
        TxtCekNik.Location = New Point(161, 57)
        TxtCekNik.Name = "TxtCekNik"
        TxtCekNik.Size = New Size(387, 27)
        TxtCekNik.TabIndex = 1
        ' 
        ' BtnCariNik
        ' 
        BtnCariNik.Location = New Point(573, 55)
        BtnCariNik.Name = "BtnCariNik"
        BtnCariNik.Size = New Size(94, 29)
        BtnCariNik.TabIndex = 2
        BtnCariNik.Text = "Check"
        BtnCariNik.UseVisualStyleBackColor = True
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(206, 143)
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(233, 27)
        TxtAlamat.TabIndex = 3
        ' 
        ' TxtNamaLengkap
        ' 
        TxtNamaLengkap.Location = New Point(206, 99)
        TxtNamaLengkap.Name = "TxtNamaLengkap"
        TxtNamaLengkap.Size = New Size(233, 27)
        TxtNamaLengkap.TabIndex = 4
        ' 
        ' TxtTanggalLahir
        ' 
        TxtTanggalLahir.Location = New Point(206, 188)
        TxtTanggalLahir.Name = "TxtTanggalLahir"
        TxtTanggalLahir.Size = New Size(233, 27)
        TxtTanggalLahir.TabIndex = 5
        ' 
        ' TxtTempatLahir
        ' 
        TxtTempatLahir.Location = New Point(206, 234)
        TxtTempatLahir.Name = "TxtTempatLahir"
        TxtTempatLahir.Size = New Size(233, 27)
        TxtTempatLahir.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 7
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 8
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 9
        Label4.Text = "Tgl Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(98, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 10
        Label5.Text = "Tempat Lahir"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(573, 102)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormCekNik
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtTempatLahir)
        Controls.Add(TxtTanggalLahir)
        Controls.Add(TxtNamaLengkap)
        Controls.Add(TxtAlamat)
        Controls.Add(BtnCariNik)
        Controls.Add(TxtCekNik)
        Controls.Add(Label1)
        Name = "FormCekNik"
        Text = "Cek NIK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCekNik As TextBox
    Friend WithEvents BtnCariNik As Button
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtNamaLengkap As TextBox
    Friend WithEvents TxtTanggalLahir As TextBox
    Friend WithEvents TxtTempatLahir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
