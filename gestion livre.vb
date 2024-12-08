Module gestion_livre
    Public Structure livre
        Dim isbn As Integer
        Dim titre As String
        Dim auteur As String

    End Structure
    Public biblio(100) As livre
    Dim nb As Integer = 0
    Function AjouterLivre(l As livre) As Boolean
        If nb < biblio.Length Then
            biblio(nb) = l
            nb += 1
            Return True
        Else
            Return False

        End If
    End Function
    Sub affichier_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To nb - 1
            l1.Items.Add(biblio(i).isbn)
            l2.Items.Add(biblio(i).titre)
            l3.Items.Add(biblio(i).auteur)

        Next
    End Sub
    Sub affichier2_livre(dgv_livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As livre = biblio(i)
            dgv_livre.Rows.Add(livre.isbn, livre.titre, livre.auteur)
        Next
    End Sub




End Module
