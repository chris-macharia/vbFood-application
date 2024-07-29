<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        pnlLeft = New Panel()
        btnFoods = New Button()
        pnlTop = New Panel()
        btnDrinks = New Button()
        btnFruits = New Button()
        btnCart = New Button()
        btnAboutUs = New Button()
        pnlLeft.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.Tomato
        pnlLeft.Controls.Add(btnAboutUs)
        pnlLeft.Controls.Add(btnCart)
        pnlLeft.Controls.Add(btnFruits)
        pnlLeft.Controls.Add(btnDrinks)
        pnlLeft.Controls.Add(btnFoods)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(204, 497)
        pnlLeft.TabIndex = 0
        ' 
        ' btnFoods
        ' 
        btnFoods.BackgroundImage = My.Resources.Resources.plate
        btnFoods.BackgroundImageLayout = ImageLayout.None
        btnFoods.FlatStyle = FlatStyle.Flat
        btnFoods.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnFoods.ForeColor = SystemColors.ButtonHighlight
        btnFoods.Location = New Point(30, 51)
        btnFoods.Name = "btnFoods"
        btnFoods.Size = New Size(131, 52)
        btnFoods.TabIndex = 0
        btnFoods.Text = "Foods"
        btnFoods.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFoods.UseVisualStyleBackColor = True
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.DarkOrange
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(204, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(700, 53)
        pnlTop.TabIndex = 1
        ' 
        ' btnDrinks
        ' 
        btnDrinks.Location = New Point(30, 114)
        btnDrinks.Name = "btnDrinks"
        btnDrinks.Size = New Size(131, 52)
        btnDrinks.TabIndex = 1
        btnDrinks.Text = "Drinks"
        btnDrinks.UseVisualStyleBackColor = True
        ' 
        ' btnFruits
        ' 
        btnFruits.Location = New Point(30, 185)
        btnFruits.Name = "btnFruits"
        btnFruits.Size = New Size(131, 52)
        btnFruits.TabIndex = 2
        btnFruits.Text = "Fruits"
        btnFruits.UseVisualStyleBackColor = True
        ' 
        ' btnCart
        ' 
        btnCart.Location = New Point(30, 257)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(131, 52)
        btnCart.TabIndex = 3
        btnCart.Text = "My Cart"
        btnCart.UseVisualStyleBackColor = True
        ' 
        ' btnAboutUs
        ' 
        btnAboutUs.Location = New Point(30, 321)
        btnAboutUs.Name = "btnAboutUs"
        btnAboutUs.Size = New Size(131, 52)
        btnAboutUs.TabIndex = 4
        btnAboutUs.Text = "About Us"
        btnAboutUs.UseVisualStyleBackColor = True
        ' 
        ' formMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(904, 497)
        Controls.Add(pnlTop)
        Controls.Add(pnlLeft)
        Name = "formMain"
        Text = " "
        pnlLeft.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnFoods As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnFruits As Button

End Class
