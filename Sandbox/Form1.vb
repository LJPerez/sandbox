Imports System
Imports System.IO
Imports System.Xml


Public Class Form1

    Dim nombreEmpresa As String
    Dim razonSocialEmpresa As String
    Dim RUTEmpresa As String
    Dim sucId As String
    Dim sucIdDGI As String
    Dim directorioCAEs As String
    Dim directorioXMLEntrada As String
    Dim directorioSalidaCAEs As String
    Dim directorioSalidaXMLs As String


#Region "Eventos"
    Private Sub btnDirectorioCAEs_Click(sender As Object, e As EventArgs) Handles btnDirectorioCAEs.Click
        fbdCAEs.SelectedPath = "C:\"
        If fbdCAEs.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtCarpetaCAEs.Text = fbdCAEs.SelectedPath
            Catch Ex As Exception
                MessageBox.Show("No se puede leer del disco. Error: " & Ex.Message, "Error")
            Finally
            End Try
        End If
    End Sub

    Private Sub btnDirectorioXMLs_Click(sender As Object, e As EventArgs) Handles btnDirectorioXMLs.Click
        fbdXMLs.SelectedPath = "C:\"
        If fbdXMLs.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                txtCarpetaXMLEntrada.Text = fbdXMLs.SelectedPath
            Catch Ex As Exception
                MessageBox.Show("No se puede leer del disco. Error: " & Ex.Message, "Error")
            Finally
            End Try
        End If
    End Sub



#End Region


#Region "Subrutinas de funcionamiento"

    Private Sub ConvertirCAEs()
        'directorioCAEs = txtCarpetaCAEs.Text
        directorioCAEs = "\\servosi\Instalaciones\New Age Data\Taface\Compartida TaFAce\Caes\Homologacion"
        ' lista de las rutas de los archivos
        Dim listaCAEs = Directory.GetFiles(directorioCAEs)
        Dim listaCAEsModificados(listaCAEs.Length) As String

        Dim xmlCAE As XmlDocument
        Dim xmlNode As XmlNode
        Dim xmlElement As XmlElement

        Dim cae As String = ""
        Try
            For Each cae In listaCAEs
                xmlCAE = loadXMLDocument(cae)
                'xmlNode = xmlCAE.SelectSingleNode("RucE")
                MessageBox.Show(My.Computer.Clock.LocalTime.ToString, "CAE")
            Next cae

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Function loadXMLDocument(path As String) As XmlDocument
        Dim doc As XmlDocument
        doc = New XmlDocument
        Dim fs As New System.IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
        Dim sr As New System.IO.StreamReader(fs)
        doc.Load(sr)
        sr.Close()
        fs.Close()
        Return doc
    End Function

    Private Sub AbrirXML()
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim str As String
        Dim fs As New FileStream("products.xml", FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName("Product")
        For i = 0 To xmlnode.Count - 1
            xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
            str = xmlnode(i).ChildNodes.Item(0).InnerText.Trim() & "  " & xmlnode(i).ChildNodes.Item(1).InnerText.Trim() & "  " & xmlnode(i).ChildNodes.Item(2).InnerText.Trim()
            MsgBox(str)
        Next
    End Sub

    Private Sub btnCrearCAEs_Click(sender As Object, e As EventArgs) Handles btnCrearCAEs.Click
        ConvertirCAEs()
    End Sub




#End Region










End Class
