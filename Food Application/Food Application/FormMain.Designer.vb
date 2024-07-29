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
        btnAboutUs = New Button()
        btnCart = New Button()
        btnFruits = New Button()
        btnDrinks = New Button()
        btnFoods = New Button()
        pnlTop = New Panel()
        pnlFoods = New Panel()
        pnlChicken = New Panel()
        btnChicken = New Button()
        lblChicken = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        pnlLeft.SuspendLayout()
        pnlFoods.SuspendLayout()
        pnlChicken.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
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
        ' btnAboutUs
        ' 
        btnAboutUs.Location = New Point(30, 406)
        btnAboutUs.Name = "btnAboutUs"
        btnAboutUs.Size = New Size(131, 52)
        btnAboutUs.TabIndex = 4
        btnAboutUs.Text = "About Us"
        btnAboutUs.UseVisualStyleBackColor = True
        ' 
        ' btnCart
        ' 
        btnCart.Location = New Point(30, 322)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(131, 52)
        btnCart.TabIndex = 3
        btnCart.Text = "My Cart"
        btnCart.UseVisualStyleBackColor = True
        ' 
        ' btnFruits
        ' 
        btnFruits.Location = New Point(30, 245)
        btnFruits.Name = "btnFruits"
        btnFruits.Size = New Size(131, 52)
        btnFruits.TabIndex = 2
        btnFruits.Text = "Fruits"
        btnFruits.UseVisualStyleBackColor = True
        ' 
        ' btnDrinks
        ' 
        btnDrinks.Location = New Point(30, 167)
        btnDrinks.Name = "btnDrinks"
        btnDrinks.Size = New Size(131, 52)
        btnDrinks.TabIndex = 1
        btnDrinks.Text = "Drinks"
        btnDrinks.UseVisualStyleBackColor = True
        ' 
        ' btnFoods
        ' 
        btnFoods.BackgroundImage = My.Resources.Resources.plate
        btnFoods.BackgroundImageLayout = ImageLayout.None
        btnFoods.FlatStyle = FlatStyle.Flat
        btnFoods.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFoods.ForeColor = SystemColors.ButtonHighlight
        btnFoods.Location = New Point(30, 99)
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
        ' pnlFoods
        ' 
        pnlFoods.Controls.Add(Panel5)
        pnlFoods.Controls.Add(Panel4)
        pnlFoods.Controls.Add(Panel3)
        pnlFoods.Controls.Add(Panel2)
        pnlFoods.Controls.Add(Panel1)
        pnlFoods.Controls.Add(pnlChicken)
        pnlFoods.Location = New Point(205, 53)
        pnlFoods.Name = "pnlFoods"
        pnlFoods.Size = New Size(699, 444)
        pnlFoods.TabIndex = 2
        ' 
        ' pnlChicken
        ' 
        pnlChicken.Controls.Add(lblChicken)
        pnlChicken.Controls.Add(btnChicken)
        pnlChicken.Location = New Point(16, 18)
        pnlChicken.Name = "pnlChicken"
        pnlChicken.Size = New Size(209, 149)
        pnlChicken.TabIndex = 0
        ' 
        ' btnChicken
        ' 
        btnChicken.Location = New Point(17, 35)
        btnChicken.Name = "btnChicken"
        btnChicken.Size = New Size(160, 102)
        btnChicken.TabIndex = 0
        btnChicken.Text = "Chicken-img"
        btnChicken.UseVisualStyleBackColor = True
        ' 
        ' lblChicken
        ' 
        lblChicken.AutoSize = True
        lblChicken.Location = New Point(86, 14)
        lblChicken.Name = "lblChicken"
        lblChicken.Size = New Size(50, 15)
        lblChicken.TabIndex = 1
        lblChicken.Text = "Chicken"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(272, 17)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(193, 149)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(507, 18)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(180, 149)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(27, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 102)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(15, 35)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 102)
        Button2.TabIndex = 0
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button3)
        Panel3.Location = New Point(16, 217)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(209, 142)
        Panel3.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button4)
        Panel4.Location = New Point(272, 217)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(193, 142)
        Panel4.TabIndex = 4
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button5)
        Panel5.Location = New Point(507, 210)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(180, 149)
        Panel5.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(17, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(160, 82)
        Button3.TabIndex = 0
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(27, 22)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 82)
        Button4.TabIndex = 0
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(15, 29)
        Button5.Name = "Button5"
        Button5.Size = New Size(139, 82)
        Button5.TabIndex = 0
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' formMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(904, 497)
        Controls.Add(pnlFoods)
        Controls.Add(pnlTop)
        Controls.Add(pnlLeft)
        Name = "formMain"
        Text = " "
        pnlLeft.ResumeLayout(False)
        pnlFoods.ResumeLayout(False)
        pnlChicken.ResumeLayout(False)
        pnlChicken.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnFoods As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnFruits As Button
    Friend WithEvents pnlFoods As Panel
    Friend WithEvents pnlChicken As Panel
    Friend WithEvents btnChicken As Button
    Friend WithEvents lblChicken As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button

End Class
