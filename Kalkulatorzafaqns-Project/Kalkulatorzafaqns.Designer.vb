<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulatorzafaqns
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBathSize = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBathWidth = New System.Windows.Forms.TextBox()
        Me.txtBathLenght = New System.Windows.Forms.TextBox()
        Me.txtBathHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDoorWidth = New System.Windows.Forms.TextBox()
        Me.txtDoorHeight = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTiles = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Калкулатор за фаянс"
        '
        'lblBathSize
        '
        Me.lblBathSize.AutoSize = True
        Me.lblBathSize.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBathSize.Location = New System.Drawing.Point(26, 86)
        Me.lblBathSize.Name = "lblBathSize"
        Me.lblBathSize.Size = New System.Drawing.Size(181, 16)
        Me.lblBathSize.TabIndex = 1
        Me.lblBathSize.Text = "Размери на банята (m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ширина"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Дължина"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Височина"
        '
        'txtBathWidth
        '
        Me.txtBathWidth.Location = New System.Drawing.Point(335, 83)
        Me.txtBathWidth.Name = "txtBathWidth"
        Me.txtBathWidth.Size = New System.Drawing.Size(100, 21)
        Me.txtBathWidth.TabIndex = 5
        '
        'txtBathLenght
        '
        Me.txtBathLenght.Location = New System.Drawing.Point(335, 121)
        Me.txtBathLenght.Name = "txtBathLenght"
        Me.txtBathLenght.Size = New System.Drawing.Size(100, 21)
        Me.txtBathLenght.TabIndex = 6
        '
        'txtBathHeight
        '
        Me.txtBathHeight.Location = New System.Drawing.Point(335, 159)
        Me.txtBathHeight.Name = "txtBathHeight"
        Me.txtBathHeight.Size = New System.Drawing.Size(100, 21)
        Me.txtBathHeight.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(26, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Размери на вратата (m)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ширина"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Височина"
        '
        'txtDoorWidth
        '
        Me.txtDoorWidth.Location = New System.Drawing.Point(335, 252)
        Me.txtDoorWidth.Name = "txtDoorWidth"
        Me.txtDoorWidth.Size = New System.Drawing.Size(100, 21)
        Me.txtDoorWidth.TabIndex = 11
        '
        'txtDoorHeight
        '
        Me.txtDoorHeight.Location = New System.Drawing.Point(335, 297)
        Me.txtDoorHeight.Name = "txtDoorHeight"
        Me.txtDoorHeight.Size = New System.Drawing.Size(100, 21)
        Me.txtDoorHeight.TabIndex = 12
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(140, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Изчисти"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(255, 360)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Пресметни"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTiles
        '
        Me.lblTiles.AutoSize = True
        Me.lblTiles.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTiles.Location = New System.Drawing.Point(29, 455)
        Me.lblTiles.Name = "lblTiles"
        Me.lblTiles.Size = New System.Drawing.Size(155, 16)
        Me.lblTiles.TabIndex = 15
        Me.lblTiles.Text = "Необходими плочки"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblOutput.Location = New System.Drawing.Point(335, 455)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 16)
        Me.lblOutput.TabIndex = 16
        '
        'Kalkulatorzafaqns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 522)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblTiles)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtDoorHeight)
        Me.Controls.Add(Me.txtDoorWidth)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBathHeight)
        Me.Controls.Add(Me.txtBathLenght)
        Me.Controls.Add(Me.txtBathWidth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBathSize)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MinimumSize = New System.Drawing.Size(481, 560)
        Me.Name = "Kalkulatorzafaqns"
        Me.Text = "Калкулатор за фаянс"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBathSize As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBathWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtBathLenght As System.Windows.Forms.TextBox
    Friend WithEvents txtBathHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDoorWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtDoorHeight As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTiles As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label

End Class
