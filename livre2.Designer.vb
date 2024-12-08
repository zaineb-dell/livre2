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
        components = New ComponentModel.Container()
        ErrorProvider1 = New ErrorProvider(components)
        isbn = New Label()
        AUTEUR = New Label()
        TITRE = New Label()
        BOX1 = New TextBox()
        BOX3 = New TextBox()
        BOX2 = New TextBox()
        BTN1 = New Button()
        BTN2 = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' isbn
        ' 
        isbn.AutoSize = True
        isbn.Location = New Point(184, 75)
        isbn.Name = "isbn"
        isbn.Size = New Size(41, 20)
        isbn.TabIndex = 0
        isbn.Text = "ISBN"
        ' 
        ' AUTEUR
        ' 
        AUTEUR.AutoSize = True
        AUTEUR.Location = New Point(184, 176)
        AUTEUR.Name = "AUTEUR"
        AUTEUR.Size = New Size(64, 20)
        AUTEUR.TabIndex = 1
        AUTEUR.Text = "AUTEUR"
        ' 
        ' TITRE
        ' 
        TITRE.AutoSize = True
        TITRE.Location = New Point(184, 127)
        TITRE.Name = "TITRE"
        TITRE.Size = New Size(46, 20)
        TITRE.TabIndex = 2
        TITRE.Text = "TITRE"
        ' 
        ' BOX1
        ' 
        BOX1.Location = New Point(273, 68)
        BOX1.Name = "BOX1"
        BOX1.Size = New Size(125, 27)
        BOX1.TabIndex = 3
        ' 
        ' BOX3
        ' 
        BOX3.Location = New Point(283, 169)
        BOX3.Name = "BOX3"
        BOX3.Size = New Size(125, 27)
        BOX3.TabIndex = 4
        ' 
        ' BOX2
        ' 
        BOX2.Location = New Point(283, 120)
        BOX2.Name = "BOX2"
        BOX2.Size = New Size(125, 27)
        BOX2.TabIndex = 5
        ' 
        ' BTN1
        ' 
        BTN1.Location = New Point(253, 272)
        BTN1.Name = "BTN1"
        BTN1.Size = New Size(94, 29)
        BTN1.TabIndex = 6
        BTN1.Text = "AJOUTER"
        BTN1.UseVisualStyleBackColor = True
        ' 
        ' BTN2
        ' 
        BTN2.Location = New Point(491, 272)
        BTN2.Name = "BTN2"
        BTN2.Size = New Size(94, 29)
        BTN2.TabIndex = 7
        BTN2.Text = "AFFICHIER"
        BTN2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BTN2)
        Controls.Add(BTN1)
        Controls.Add(BOX2)
        Controls.Add(BOX3)
        Controls.Add(BOX1)
        Controls.Add(TITRE)
        Controls.Add(AUTEUR)
        Controls.Add(isbn)
        Name = "Form1"
        Text = "ISBN"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents isbn As Label
    Friend WithEvents TITRE As Label
    Friend WithEvents AUTEUR As Label
    Friend WithEvents BTN2 As Button
    Friend WithEvents BTN1 As Button
    Friend WithEvents BOX2 As TextBox
    Friend WithEvents BOX3 As TextBox
    Friend WithEvents BOX1 As TextBox

End Class
