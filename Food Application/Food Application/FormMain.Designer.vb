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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tomato
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 497)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrange
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(204, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(700, 53)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.plate
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(4, 82)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 47)
        Button1.TabIndex = 0
        Button1.Text = "Foods"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkOrange
        Panel3.Location = New Point(300, 156)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(374, 217)
        Panel3.TabIndex = 2
        ' 
        ' formMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(904, 497)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "formMain"
        Text = " "
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel

End Class
