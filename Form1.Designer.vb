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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Title = New Label()
        GroupLbl = New Label()
        CostBox = New GroupBox()
        CnSE = New RadioButton()
        CnA = New RadioButton()
        C = New RadioButton()
        CostLbl = New Label()
        GroupSizeBox = New TextBox()
        Calculate = New Button()
        Clear = New Button()
        Ignore = New RadioButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(3204, 922)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Title.Location = New Point(950, 990)
        Title.Name = "Title"
        Title.Size = New Size(1235, 89)
        Title.TabIndex = 1
        Title.Text = "Comic Convention Registration"
        ' 
        ' GroupLbl
        ' 
        GroupLbl.AutoSize = True
        GroupLbl.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupLbl.Location = New Point(1186, 1098)
        GroupLbl.Name = "GroupLbl"
        GroupLbl.Size = New Size(236, 44)
        GroupLbl.TabIndex = 2
        GroupLbl.Text = "Group Size:"
        ' 
        ' CostBox
        ' 
        CostBox.Location = New Point(1544, 1407)
        CostBox.Name = "CostBox"
        CostBox.Size = New Size(501, 66)
        CostBox.TabIndex = 3
        CostBox.TabStop = False
        CostBox.Text = "GroupBox1"
        ' 
        ' CnSE
        ' 
        CnSE.AutoSize = True
        CnSE.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CnSE.Location = New Point(1211, 1201)
        CnSE.Name = "CnSE"
        CnSE.Size = New Size(585, 39)
        CnSE.TabIndex = 4
        CnSE.TabStop = True
        CnSE.Text = "Convention + Superhero Experience"
        CnSE.UseVisualStyleBackColor = True
        ' 
        ' CnA
        ' 
        CnA.AutoSize = True
        CnA.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CnA.Location = New Point(1211, 1263)
        CnA.Name = "CnA"
        CnA.Size = New Size(428, 39)
        CnA.TabIndex = 5
        CnA.TabStop = True
        CnA.Text = "Convention + Autographs"
        CnA.UseVisualStyleBackColor = True
        ' 
        ' C
        ' 
        C.AutoSize = True
        C.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        C.Location = New Point(1211, 1329)
        C.Name = "C"
        C.Size = New Size(217, 39)
        C.TabIndex = 6
        C.TabStop = True
        C.Text = "Convention"
        C.UseVisualStyleBackColor = True
        ' 
        ' CostLbl
        ' 
        CostLbl.AutoSize = True
        CostLbl.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CostLbl.Location = New Point(1124, 1407)
        CostLbl.Name = "CostLbl"
        CostLbl.Size = New Size(381, 44)
        CostLbl.TabIndex = 7
        CostLbl.Text = "Registration Cost:"
        ' 
        ' GroupSizeBox
        ' 
        GroupSizeBox.Location = New Point(1464, 1111)
        GroupSizeBox.Name = "GroupSizeBox"
        GroupSizeBox.Size = New Size(150, 31)
        GroupSizeBox.TabIndex = 9
        ' 
        ' Calculate
        ' 
        Calculate.Location = New Point(992, 1541)
        Calculate.Name = "Calculate"
        Calculate.Size = New Size(345, 80)
        Calculate.TabIndex = 10
        Calculate.Text = "Calculate"
        Calculate.UseVisualStyleBackColor = True
        ' 
        ' Clear
        ' 
        Clear.Location = New Point(1618, 1541)
        Clear.Name = "Clear"
        Clear.Size = New Size(345, 80)
        Clear.TabIndex = 11
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' Ignore
        ' 
        Ignore.AutoSize = True
        Ignore.Location = New Point(542, 1287)
        Ignore.Name = "Ignore"
        Ignore.Size = New Size(156, 29)
        Ignore.TabIndex = 12
        Ignore.TabStop = True
        Ignore.Text = "Startup(Ignore)"
        Ignore.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(3213, 2130)
        Controls.Add(Ignore)
        Controls.Add(Clear)
        Controls.Add(Calculate)
        Controls.Add(GroupSizeBox)
        Controls.Add(CostLbl)
        Controls.Add(C)
        Controls.Add(CnA)
        Controls.Add(CnSE)
        Controls.Add(CostBox)
        Controls.Add(GroupLbl)
        Controls.Add(Title)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents GroupLbl As Label
    Friend WithEvents CostBox As GroupBox
    Friend WithEvents CnSE As RadioButton
    Friend WithEvents CnA As RadioButton
    Friend WithEvents C As RadioButton
    Friend WithEvents CostLbl As Label
    Friend WithEvents GroupSizeBox As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Ignore As RadioButton

End Class
