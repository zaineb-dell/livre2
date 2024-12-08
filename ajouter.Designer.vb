<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajouter
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Lst_auteur = New ListBox()
        Lst_livre = New ListBox()
        Lst_titre = New ListBox()
        Btn_affichier = New Button()
        SuspendLayout()
        ' 
        ' Lst_auteur
        ' 
        Lst_auteur.FormattingEnabled = True
        Lst_auteur.Location = New Point(129, 64)
        Lst_auteur.Name = "Lst_auteur"
        Lst_auteur.Size = New Size(150, 204)
        Lst_auteur.TabIndex = 0
        ' 
        ' Lst_livre
        ' 
        Lst_livre.FormattingEnabled = True
        Lst_livre.Location = New Point(319, 64)
        Lst_livre.Name = "Lst_livre"
        Lst_livre.Size = New Size(150, 204)
        Lst_livre.TabIndex = 1
        ' 
        ' Lst_titre
        ' 
        Lst_titre.FormattingEnabled = True
        Lst_titre.Location = New Point(519, 64)
        Lst_titre.Name = "Lst_titre"
        Lst_titre.Size = New Size(150, 204)
        Lst_titre.TabIndex = 2
        ' 
        ' Btn_affichier
        ' 
        Btn_affichier.Location = New Point(350, 344)
        Btn_affichier.Name = "Btn_affichier"
        Btn_affichier.Size = New Size(94, 29)
        Btn_affichier.TabIndex = 3
        Btn_affichier.Text = "affichier"
        Btn_affichier.UseVisualStyleBackColor = True
        ' 
        ' ajouter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_affichier)
        Controls.Add(Lst_titre)
        Controls.Add(Lst_livre)
        Controls.Add(Lst_auteur)
        Name = "ajouter"
        Text = "ajouter"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lst_auteur As ListBox
    Friend WithEvents Lst_livre As ListBox
    Friend WithEvents Lst_titre As ListBox
    Friend WithEvents Btn_affichier As Button
End Class
