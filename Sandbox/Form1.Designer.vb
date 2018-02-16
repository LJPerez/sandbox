<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblSucIdDGI = New System.Windows.Forms.Label()
        Me.lblRUT = New System.Windows.Forms.Label()
        Me.lblSucId = New System.Windows.Forms.Label()
        Me.btnCrearCAEs = New System.Windows.Forms.Button()
        Me.fbdCAEs = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDirectorioXMLs = New System.Windows.Forms.Button()
        Me.btnDirectorioCAEs = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCAEs = New System.Windows.Forms.Label()
        Me.txtCarpetaCAEs = New System.Windows.Forms.TextBox()
        Me.txtCarpetaXMLEntrada = New System.Windows.Forms.TextBox()
        Me.fbdXMLs = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnCrearXMLs = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.lblRazonSocial)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lblSucIdDGI)
        Me.GroupBox1.Controls.Add(Me.lblRUT)
        Me.GroupBox1.Controls.Add(Me.lblSucId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empresa"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(135, 54)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(211, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(135, 23)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(211, 20)
        Me.TextBox4.TabIndex = 13
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(21, 56)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(73, 13)
        Me.lblRazonSocial.TabIndex = 12
        Me.lblRazonSocial.Text = "Razon Social:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(21, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(135, 144)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(28, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(135, 115)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(28, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 83)
        Me.TextBox1.MaxLength = 12
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 20)
        Me.TextBox1.TabIndex = 8
        '
        'lblSucIdDGI
        '
        Me.lblSucIdDGI.AutoSize = True
        Me.lblSucIdDGI.Location = New System.Drawing.Point(21, 147)
        Me.lblSucIdDGI.Name = "lblSucIdDGI"
        Me.lblSucIdDGI.Size = New System.Drawing.Size(65, 13)
        Me.lblSucIdDGI.TabIndex = 7
        Me.lblSucIdDGI.Text = "Suc ID DGI:"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Location = New System.Drawing.Point(21, 86)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(36, 13)
        Me.lblRUT.TabIndex = 4
        Me.lblRUT.Text = "RUT: "
        '
        'lblSucId
        '
        Me.lblSucId.AutoSize = True
        Me.lblSucId.Location = New System.Drawing.Point(21, 118)
        Me.lblSucId.Name = "lblSucId"
        Me.lblSucId.Size = New System.Drawing.Size(46, 13)
        Me.lblSucId.TabIndex = 6
        Me.lblSucId.Text = "Suc ID: "
        '
        'btnCrearCAEs
        '
        Me.btnCrearCAEs.Location = New System.Drawing.Point(36, 313)
        Me.btnCrearCAEs.Name = "btnCrearCAEs"
        Me.btnCrearCAEs.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearCAEs.TabIndex = 5
        Me.btnCrearCAEs.Text = "Crear CAEs"
        Me.btnCrearCAEs.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDirectorioXMLs)
        Me.GroupBox2.Controls.Add(Me.btnDirectorioCAEs)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblCAEs)
        Me.GroupBox2.Controls.Add(Me.txtCarpetaCAEs)
        Me.GroupBox2.Controls.Add(Me.txtCarpetaXMLEntrada)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 109)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Directorios de Trabajo"
        '
        'btnDirectorioXMLs
        '
        Me.btnDirectorioXMLs.Location = New System.Drawing.Point(248, 60)
        Me.btnDirectorioXMLs.Name = "btnDirectorioXMLs"
        Me.btnDirectorioXMLs.Size = New System.Drawing.Size(31, 23)
        Me.btnDirectorioXMLs.TabIndex = 5
        Me.btnDirectorioXMLs.Text = "..."
        Me.btnDirectorioXMLs.UseVisualStyleBackColor = True
        '
        'btnDirectorioCAEs
        '
        Me.btnDirectorioCAEs.Location = New System.Drawing.Point(248, 30)
        Me.btnDirectorioCAEs.Name = "btnDirectorioCAEs"
        Me.btnDirectorioCAEs.Size = New System.Drawing.Size(31, 23)
        Me.btnDirectorioCAEs.TabIndex = 4
        Me.btnDirectorioCAEs.Text = "..."
        Me.btnDirectorioCAEs.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "XMLs:"
        '
        'lblCAEs
        '
        Me.lblCAEs.AutoSize = True
        Me.lblCAEs.Location = New System.Drawing.Point(23, 35)
        Me.lblCAEs.Name = "lblCAEs"
        Me.lblCAEs.Size = New System.Drawing.Size(36, 13)
        Me.lblCAEs.TabIndex = 2
        Me.lblCAEs.Text = "CAEs:"
        '
        'txtCarpetaCAEs
        '
        Me.txtCarpetaCAEs.Location = New System.Drawing.Point(89, 29)
        Me.txtCarpetaCAEs.Name = "txtCarpetaCAEs"
        Me.txtCarpetaCAEs.Size = New System.Drawing.Size(140, 20)
        Me.txtCarpetaCAEs.TabIndex = 1
        '
        'txtCarpetaXMLEntrada
        '
        Me.txtCarpetaXMLEntrada.Location = New System.Drawing.Point(89, 64)
        Me.txtCarpetaXMLEntrada.Name = "txtCarpetaXMLEntrada"
        Me.txtCarpetaXMLEntrada.Size = New System.Drawing.Size(140, 20)
        Me.txtCarpetaXMLEntrada.TabIndex = 0
        '
        'btnCrearXMLs
        '
        Me.btnCrearXMLs.Location = New System.Drawing.Point(138, 312)
        Me.btnCrearXMLs.Name = "btnCrearXMLs"
        Me.btnCrearXMLs.Size = New System.Drawing.Size(91, 23)
        Me.btnCrearXMLs.TabIndex = 7
        Me.btnCrearXMLs.Text = "Crear Set XMLs"
        Me.btnCrearXMLs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 348)
        Me.Controls.Add(Me.btnCrearXMLs)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCrearCAEs)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblSucIdDGI As Label
    Friend WithEvents lblRUT As Label
    Friend WithEvents lblSucId As Label
    Friend WithEvents btnCrearCAEs As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents fbdCAEs As FolderBrowserDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDirectorioXMLs As Button
    Friend WithEvents btnDirectorioCAEs As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCAEs As Label
    Friend WithEvents txtCarpetaCAEs As TextBox
    Friend WithEvents txtCarpetaXMLEntrada As TextBox
    Friend WithEvents fbdXMLs As FolderBrowserDialog
    Friend WithEvents btnCrearXMLs As Button
End Class
