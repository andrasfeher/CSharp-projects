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
        Me.lblName = New System.Windows.Forms.Label
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.lstCustomers = New System.Windows.Forms.ListBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(41, 138)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(19, 171)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(18, 204)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(44, 237)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(82, 135)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 20)
        Me.txtName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(82, 168)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(182, 20)
        Me.txtFirstName.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(83, 201)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(181, 20)
        Me.txtLastName.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(83, 234)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(181, 20)
        Me.txtEmail.TabIndex = 7
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(77, 267)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.IntegralHeight = False
        Me.lstCustomers.Location = New System.Drawing.Point(13, 13)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(251, 108)
        Me.lstCustomers.TabIndex = 9
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(158, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 302)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
