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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD:"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(174, 39)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(158, 31)
        Me.tb1.TabIndex = 2
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(174, 80)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(158, 31)
        Me.tb2.TabIndex = 3
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(65, 152)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(120, 37)
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "LOGIN"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(212, 152)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(120, 37)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "CANCEL"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 233)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button

End Class
