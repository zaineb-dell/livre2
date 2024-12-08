Public Class Form1
    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        Dim l As livre
        l.isbn = BOX1.Text
        l.titre = BOX2.Text
        l.auteur = BOX3.Text
        If AjouterLivre(l) Then
            MessageBox.Show("ajouter livre avec succes")
        Else
            MessageBox.Show("le tableaux bibliotheque est sature")
        End If
    End Sub

    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        frm_afficher.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
