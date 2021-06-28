<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.display = New System.Windows.Forms.Label()
        Me.Btn_7 = New System.Windows.Forms.Button()
        Me.Btn_8 = New System.Windows.Forms.Button()
        Me.Btn_3 = New System.Windows.Forms.Button()
        Me.Btn_4 = New System.Windows.Forms.Button()
        Me.Btn_5 = New System.Windows.Forms.Button()
        Me.Btn_2 = New System.Windows.Forms.Button()
        Me.Btn_9 = New System.Windows.Forms.Button()
        Me.Btn_6 = New System.Windows.Forms.Button()
        Me.Btn_1 = New System.Windows.Forms.Button()
        Me.Btn_pl = New System.Windows.Forms.Button()
        Me.Btn_mn = New System.Windows.Forms.Button()
        Me.Btn_eq = New System.Windows.Forms.Button()
        Me.Btn_clr = New System.Windows.Forms.Button()
        Me.Btn_0 = New System.Windows.Forms.Button()
        Me.Btn_div = New System.Windows.Forms.Button()
        Me.Btn_mul = New System.Windows.Forms.Button()
        Me.NAP = New System.Windows.Forms.Button()
        Me.Btn_ce = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'display
        '
        Me.display.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.display.Font = New System.Drawing.Font("Microsoft YaHei", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display.ForeColor = System.Drawing.SystemColors.ControlText
        Me.display.Location = New System.Drawing.Point(13, 9)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(473, 125)
        Me.display.TabIndex = 0
        Me.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_7
        '
        Me.Btn_7.BackColor = System.Drawing.Color.White
        Me.Btn_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_7.Location = New System.Drawing.Point(12, 230)
        Me.Btn_7.Name = "Btn_7"
        Me.Btn_7.Size = New System.Drawing.Size(99, 79)
        Me.Btn_7.TabIndex = 1
        Me.Btn_7.Text = "7"
        Me.Btn_7.UseVisualStyleBackColor = False
        '
        'Btn_8
        '
        Me.Btn_8.BackColor = System.Drawing.Color.White
        Me.Btn_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_8.Location = New System.Drawing.Point(132, 230)
        Me.Btn_8.Name = "Btn_8"
        Me.Btn_8.Size = New System.Drawing.Size(105, 79)
        Me.Btn_8.TabIndex = 2
        Me.Btn_8.Text = "8"
        Me.Btn_8.UseVisualStyleBackColor = False
        '
        'Btn_3
        '
        Me.Btn_3.BackColor = System.Drawing.Color.White
        Me.Btn_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_3.Location = New System.Drawing.Point(12, 445)
        Me.Btn_3.Name = "Btn_3"
        Me.Btn_3.Size = New System.Drawing.Size(96, 79)
        Me.Btn_3.TabIndex = 3
        Me.Btn_3.Text = "3"
        Me.Btn_3.UseVisualStyleBackColor = False
        '
        'Btn_4
        '
        Me.Btn_4.BackColor = System.Drawing.Color.White
        Me.Btn_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_4.Location = New System.Drawing.Point(12, 337)
        Me.Btn_4.Name = "Btn_4"
        Me.Btn_4.Size = New System.Drawing.Size(99, 79)
        Me.Btn_4.TabIndex = 4
        Me.Btn_4.Text = "4"
        Me.Btn_4.UseVisualStyleBackColor = False
        '
        'Btn_5
        '
        Me.Btn_5.BackColor = System.Drawing.Color.White
        Me.Btn_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_5.Location = New System.Drawing.Point(132, 333)
        Me.Btn_5.Name = "Btn_5"
        Me.Btn_5.Size = New System.Drawing.Size(105, 79)
        Me.Btn_5.TabIndex = 5
        Me.Btn_5.Text = "5"
        Me.Btn_5.UseVisualStyleBackColor = False
        '
        'Btn_2
        '
        Me.Btn_2.BackColor = System.Drawing.Color.White
        Me.Btn_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_2.Location = New System.Drawing.Point(132, 445)
        Me.Btn_2.Name = "Btn_2"
        Me.Btn_2.Size = New System.Drawing.Size(106, 79)
        Me.Btn_2.TabIndex = 6
        Me.Btn_2.Text = "2"
        Me.Btn_2.UseVisualStyleBackColor = False
        '
        'Btn_9
        '
        Me.Btn_9.BackColor = System.Drawing.Color.White
        Me.Btn_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_9.Location = New System.Drawing.Point(260, 230)
        Me.Btn_9.Name = "Btn_9"
        Me.Btn_9.Size = New System.Drawing.Size(102, 79)
        Me.Btn_9.TabIndex = 7
        Me.Btn_9.Text = "9"
        Me.Btn_9.UseVisualStyleBackColor = False
        '
        'Btn_6
        '
        Me.Btn_6.BackColor = System.Drawing.Color.White
        Me.Btn_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_6.Location = New System.Drawing.Point(260, 335)
        Me.Btn_6.Name = "Btn_6"
        Me.Btn_6.Size = New System.Drawing.Size(102, 79)
        Me.Btn_6.TabIndex = 8
        Me.Btn_6.Text = "6"
        Me.Btn_6.UseVisualStyleBackColor = False
        '
        'Btn_1
        '
        Me.Btn_1.BackColor = System.Drawing.Color.White
        Me.Btn_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_1.Location = New System.Drawing.Point(260, 445)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Size = New System.Drawing.Size(102, 79)
        Me.Btn_1.TabIndex = 9
        Me.Btn_1.Text = "1"
        Me.Btn_1.UseVisualStyleBackColor = False
        '
        'Btn_pl
        '
        Me.Btn_pl.BackColor = System.Drawing.Color.White
        Me.Btn_pl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_pl.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_pl.Location = New System.Drawing.Point(384, 333)
        Me.Btn_pl.Name = "Btn_pl"
        Me.Btn_pl.Size = New System.Drawing.Size(102, 83)
        Me.Btn_pl.TabIndex = 10
        Me.Btn_pl.Text = "+"
        Me.Btn_pl.UseVisualStyleBackColor = False
        '
        'Btn_mn
        '
        Me.Btn_mn.BackColor = System.Drawing.Color.White
        Me.Btn_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_mn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_mn.Location = New System.Drawing.Point(384, 445)
        Me.Btn_mn.Name = "Btn_mn"
        Me.Btn_mn.Size = New System.Drawing.Size(102, 79)
        Me.Btn_mn.TabIndex = 11
        Me.Btn_mn.Text = "-"
        Me.Btn_mn.UseVisualStyleBackColor = False
        '
        'Btn_eq
        '
        Me.Btn_eq.BackColor = System.Drawing.Color.White
        Me.Btn_eq.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_eq.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_eq.Location = New System.Drawing.Point(384, 230)
        Me.Btn_eq.Name = "Btn_eq"
        Me.Btn_eq.Size = New System.Drawing.Size(102, 79)
        Me.Btn_eq.TabIndex = 12
        Me.Btn_eq.Text = "="
        Me.Btn_eq.UseVisualStyleBackColor = False
        '
        'Btn_clr
        '
        Me.Btn_clr.BackColor = System.Drawing.Color.White
        Me.Btn_clr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clr.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_clr.Location = New System.Drawing.Point(11, 146)
        Me.Btn_clr.Name = "Btn_clr"
        Me.Btn_clr.Size = New System.Drawing.Size(226, 64)
        Me.Btn_clr.TabIndex = 13
        Me.Btn_clr.Text = "Clear"
        Me.Btn_clr.UseVisualStyleBackColor = False
        '
        'Btn_0
        '
        Me.Btn_0.BackColor = System.Drawing.Color.White
        Me.Btn_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_0.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_0.Location = New System.Drawing.Point(132, 547)
        Me.Btn_0.Name = "Btn_0"
        Me.Btn_0.Size = New System.Drawing.Size(106, 79)
        Me.Btn_0.TabIndex = 14
        Me.Btn_0.Text = "0"
        Me.Btn_0.UseVisualStyleBackColor = False
        '
        'Btn_div
        '
        Me.Btn_div.BackColor = System.Drawing.Color.White
        Me.Btn_div.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_div.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_div.Location = New System.Drawing.Point(260, 547)
        Me.Btn_div.Name = "Btn_div"
        Me.Btn_div.Size = New System.Drawing.Size(102, 79)
        Me.Btn_div.TabIndex = 15
        Me.Btn_div.Text = "/"
        Me.Btn_div.UseVisualStyleBackColor = False
        '
        'Btn_mul
        '
        Me.Btn_mul.BackColor = System.Drawing.Color.White
        Me.Btn_mul.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_mul.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_mul.Location = New System.Drawing.Point(384, 547)
        Me.Btn_mul.Name = "Btn_mul"
        Me.Btn_mul.Size = New System.Drawing.Size(103, 79)
        Me.Btn_mul.TabIndex = 16
        Me.Btn_mul.Text = "X"
        Me.Btn_mul.UseVisualStyleBackColor = False
        '
        'NAP
        '
        Me.NAP.BackColor = System.Drawing.Color.White
        Me.NAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAP.ForeColor = System.Drawing.SystemColors.Desktop
        Me.NAP.Location = New System.Drawing.Point(12, 547)
        Me.NAP.Name = "NAP"
        Me.NAP.Size = New System.Drawing.Size(99, 79)
        Me.NAP.TabIndex = 17
        Me.NAP.Text = "+/-"
        Me.NAP.UseVisualStyleBackColor = False
        '
        'Btn_ce
        '
        Me.Btn_ce.BackColor = System.Drawing.Color.White
        Me.Btn_ce.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ce.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_ce.Location = New System.Drawing.Point(259, 146)
        Me.Btn_ce.Name = "Btn_ce"
        Me.Btn_ce.Size = New System.Drawing.Size(227, 64)
        Me.Btn_ce.TabIndex = 18
        Me.Btn_ce.Text = "CE"
        Me.Btn_ce.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(501, 650)
        Me.Controls.Add(Me.Btn_ce)
        Me.Controls.Add(Me.NAP)
        Me.Controls.Add(Me.Btn_mul)
        Me.Controls.Add(Me.Btn_div)
        Me.Controls.Add(Me.Btn_0)
        Me.Controls.Add(Me.Btn_clr)
        Me.Controls.Add(Me.Btn_eq)
        Me.Controls.Add(Me.Btn_mn)
        Me.Controls.Add(Me.Btn_pl)
        Me.Controls.Add(Me.Btn_1)
        Me.Controls.Add(Me.Btn_6)
        Me.Controls.Add(Me.Btn_9)
        Me.Controls.Add(Me.Btn_2)
        Me.Controls.Add(Me.Btn_5)
        Me.Controls.Add(Me.Btn_4)
        Me.Controls.Add(Me.Btn_3)
        Me.Controls.Add(Me.Btn_8)
        Me.Controls.Add(Me.Btn_7)
        Me.Controls.Add(Me.display)
        Me.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents display As Label
    Friend WithEvents Btn_7 As Button
    Friend WithEvents Btn_8 As Button
    Friend WithEvents Btn_3 As Button
    Friend WithEvents Btn_4 As Button
    Friend WithEvents Btn_5 As Button
    Friend WithEvents Btn_2 As Button
    Friend WithEvents Btn_9 As Button
    Friend WithEvents Btn_6 As Button
    Friend WithEvents Btn_1 As Button
    Friend WithEvents Btn_pl As Button
    Friend WithEvents Btn_mn As Button
    Friend WithEvents Btn_eq As Button
    Friend WithEvents Btn_clr As Button
    Friend WithEvents Btn_0 As Button
    Friend WithEvents Btn_div As Button
    Friend WithEvents Btn_mul As Button
    Friend WithEvents NAP As Button
    Friend WithEvents Btn_ce As Button
End Class
