<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtValueOne = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtnAdd = New System.Windows.Forms.RadioButton()
        Me.rbtnSubtract = New System.Windows.Forms.RadioButton()
        Me.rbtnMultiply = New System.Windows.Forms.RadioButton()
        Me.rbtnDivide = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(226, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculator"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(561, 199)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 61)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Calculate"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtValueOne
        '
        Me.txtValueOne.Location = New System.Drawing.Point(190, 183)
        Me.txtValueOne.Name = "txtValueOne"
        Me.txtValueOne.Size = New System.Drawing.Size(195, 20)
        Me.txtValueOne.TabIndex = 5
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(190, 263)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(195, 20)
        Me.txtValue2.TabIndex = 6
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(190, 377)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(195, 20)
        Me.txtAnswer.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Value 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Value 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Answer"
        '
        'rbtnAdd
        '
        Me.rbtnAdd.AutoSize = True
        Me.rbtnAdd.Checked = True
        Me.rbtnAdd.Location = New System.Drawing.Point(453, 183)
        Me.rbtnAdd.Name = "rbtnAdd"
        Me.rbtnAdd.Size = New System.Drawing.Size(44, 17)
        Me.rbtnAdd.TabIndex = 12
        Me.rbtnAdd.Text = "Add"
        Me.rbtnAdd.UseVisualStyleBackColor = True
        '
        'rbtnSubtract
        '
        Me.rbtnSubtract.AutoSize = True
        Me.rbtnSubtract.Location = New System.Drawing.Point(453, 206)
        Me.rbtnSubtract.Name = "rbtnSubtract"
        Me.rbtnSubtract.Size = New System.Drawing.Size(65, 17)
        Me.rbtnSubtract.TabIndex = 13
        Me.rbtnSubtract.Text = "Subtract"
        Me.rbtnSubtract.UseVisualStyleBackColor = True
        '
        'rbtnMultiply
        '
        Me.rbtnMultiply.AutoSize = True
        Me.rbtnMultiply.Location = New System.Drawing.Point(453, 229)
        Me.rbtnMultiply.Name = "rbtnMultiply"
        Me.rbtnMultiply.Size = New System.Drawing.Size(60, 17)
        Me.rbtnMultiply.TabIndex = 14
        Me.rbtnMultiply.Text = "Multiply"
        Me.rbtnMultiply.UseVisualStyleBackColor = True
        '
        'rbtnDivide
        '
        Me.rbtnDivide.AutoSize = True
        Me.rbtnDivide.Location = New System.Drawing.Point(453, 252)
        Me.rbtnDivide.Name = "rbtnDivide"
        Me.rbtnDivide.Size = New System.Drawing.Size(55, 17)
        Me.rbtnDivide.TabIndex = 15
        Me.rbtnDivide.Text = "Divide"
        Me.rbtnDivide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 496)
        Me.Controls.Add(Me.rbtnDivide)
        Me.Controls.Add(Me.rbtnMultiply)
        Me.Controls.Add(Me.rbtnSubtract)
        Me.Controls.Add(Me.rbtnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.txtValueOne)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtValueOne As TextBox
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbtnAdd As RadioButton
    Friend WithEvents rbtnSubtract As RadioButton
    Friend WithEvents rbtnMultiply As RadioButton
    Friend WithEvents rbtnDivide As RadioButton
End Class
