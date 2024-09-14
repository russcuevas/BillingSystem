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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckTotal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radWW = New System.Windows.Forms.RadioButton()
        Me.radRW = New System.Windows.Forms.RadioButton()
        Me.radBeer = New System.Windows.Forms.RadioButton()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblItemAmount = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBeer)
        Me.GroupBox1.Controls.Add(Me.radRW)
        Me.GroupBox1.Controls.Add(Me.radWW)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wine Selection"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Amount Paid"
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(360, 73)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 20)
        Me.txtQuantity.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantity"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ckTotal
        '
        Me.ckTotal.Location = New System.Drawing.Point(360, 153)
        Me.ckTotal.Name = "ckTotal"
        Me.ckTotal.Size = New System.Drawing.Size(64, 27)
        Me.ckTotal.TabIndex = 4
        Me.ckTotal.Text = "Total"
        Me.ckTotal.UseCompatibleTextRendering = True
        Me.ckTotal.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(446, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 27)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sub Total"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "VAT"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Amountdue"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'radWW
        '
        Me.radWW.AutoSize = True
        Me.radWW.Location = New System.Drawing.Point(17, 49)
        Me.radWW.Name = "radWW"
        Me.radWW.Size = New System.Drawing.Size(78, 18)
        Me.radWW.TabIndex = 10
        Me.radWW.TabStop = True
        Me.radWW.Text = "White wine"
        Me.radWW.UseCompatibleTextRendering = True
        Me.radWW.UseVisualStyleBackColor = True
        '
        'radRW
        '
        Me.radRW.AutoSize = True
        Me.radRW.Location = New System.Drawing.Point(17, 80)
        Me.radRW.Name = "radRW"
        Me.radRW.Size = New System.Drawing.Size(69, 18)
        Me.radRW.TabIndex = 11
        Me.radRW.TabStop = True
        Me.radRW.Text = "Red wine"
        Me.radRW.UseCompatibleTextRendering = True
        Me.radRW.UseVisualStyleBackColor = True
        '
        'radBeer
        '
        Me.radBeer.AutoSize = True
        Me.radBeer.Location = New System.Drawing.Point(17, 113)
        Me.radBeer.Name = "radBeer"
        Me.radBeer.Size = New System.Drawing.Size(46, 18)
        Me.radBeer.TabIndex = 11
        Me.radBeer.TabStop = True
        Me.radBeer.Text = "Beer"
        Me.radBeer.UseCompatibleTextRendering = True
        Me.radBeer.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(106, 31)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(105, 17)
        Me.lblSubTotal.TabIndex = 11
        Me.lblSubTotal.UseCompatibleTextRendering = True
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(106, 60)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(105, 17)
        Me.lblTax.TabIndex = 12
        Me.lblTax.UseCompatibleTextRendering = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(106, 87)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(105, 17)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.UseCompatibleTextRendering = True
        '
        'lblItemAmount
        '
        Me.lblItemAmount.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblItemAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblItemAmount.Location = New System.Drawing.Point(360, 232)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(150, 17)
        Me.lblItemAmount.TabIndex = 12
        Me.lblItemAmount.UseCompatibleTextRendering = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(311, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(42, 18)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Tax"
        Me.CheckBox1.UseCompatibleTextRendering = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(608, 444)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblItemAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ckTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBeer As System.Windows.Forms.RadioButton
    Friend WithEvents radRW As System.Windows.Forms.RadioButton
    Friend WithEvents radWW As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckTotal As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblItemAmount As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
