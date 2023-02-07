<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgers
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPrime = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnPrime = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lblHeading.Location = New System.Drawing.Point(238, 22)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(218, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'picPrime
        '
        Me.picPrime.Location = New System.Drawing.Point(68, 83)
        Me.picPrime.Name = "picPrime"
        Me.picPrime.Size = New System.Drawing.Size(260, 250)
        Me.picPrime.TabIndex = 1
        Me.picPrime.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Location = New System.Drawing.Point(413, 83)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(260, 250)
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        '
        'btnVeggie
        '
        Me.btnVeggie.Location = New System.Drawing.Point(517, 367)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(128, 35)
        Me.btnVeggie.TabIndex = 4
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.Location = New System.Drawing.Point(311, 367)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(128, 35)
        Me.btnSelectMeal.TabIndex = 5
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = True
        '
        'btnPrime
        '
        Me.btnPrime.Location = New System.Drawing.Point(104, 367)
        Me.btnPrime.Name = "btnPrime"
        Me.btnPrime.Size = New System.Drawing.Size(128, 35)
        Me.btnPrime.TabIndex = 6
        Me.btnPrime.Text = "Prime Beef"
        Me.btnPrime.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(259, 419)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(285, 14)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Choose a burger and then click Select Meal button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblConfirmation.Location = New System.Drawing.Point(308, 454)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(144, 14)
        Me.lblConfirmation.TabIndex = 8
        Me.lblConfirmation.Text = "Enjoy your burger special"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 551)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnPrime)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrime)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBurgers"
        Me.Text = "Burger Specials"
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnPrime As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
