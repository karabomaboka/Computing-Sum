<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
    Me.lblFirstNum = New System.Windows.Forms.Label()
    Me.lblSecondNum = New System.Windows.Forms.Label()
    Me.txtFirstNum = New System.Windows.Forms.TextBox()
    Me.txtSecondNum = New System.Windows.Forms.TextBox()
    Me.btnCompute = New System.Windows.Forms.Button()
    Me.txtSum = New System.Windows.Forms.TextBox()
    Me.lblSum = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'lblFirstNum
    '
    Me.lblFirstNum.AutoSize = True
    Me.lblFirstNum.Location = New System.Drawing.Point(126, 77)
    Me.lblFirstNum.Name = "lblFirstNum"
    Me.lblFirstNum.Size = New System.Drawing.Size(89, 17)
    Me.lblFirstNum.TabIndex = 0
    Me.lblFirstNum.Text = "First Number"
    '
    'lblSecondNum
    '
    Me.lblSecondNum.AutoSize = True
    Me.lblSecondNum.Location = New System.Drawing.Point(126, 131)
    Me.lblSecondNum.Name = "lblSecondNum"
    Me.lblSecondNum.Size = New System.Drawing.Size(110, 17)
    Me.lblSecondNum.TabIndex = 1
    Me.lblSecondNum.Text = "Second Number"
    '
    'txtFirstNum
    '
    Me.txtFirstNum.Location = New System.Drawing.Point(311, 72)
    Me.txtFirstNum.Name = "txtFirstNum"
    Me.txtFirstNum.Size = New System.Drawing.Size(257, 22)
    Me.txtFirstNum.TabIndex = 2
    '
    'txtSecondNum
    '
    Me.txtSecondNum.Location = New System.Drawing.Point(311, 126)
    Me.txtSecondNum.Name = "txtSecondNum"
    Me.txtSecondNum.Size = New System.Drawing.Size(257, 22)
    Me.txtSecondNum.TabIndex = 3
    '
    'btnCompute
    '
    Me.btnCompute.Location = New System.Drawing.Point(242, 175)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(215, 38)
    Me.btnCompute.TabIndex = 4
    Me.btnCompute.Text = "Compute Sum"
    Me.btnCompute.UseVisualStyleBackColor = True
    '
    'txtSum
    '
    Me.txtSum.Location = New System.Drawing.Point(311, 236)
    Me.txtSum.Name = "txtSum"
    Me.txtSum.ReadOnly = True
    Me.txtSum.Size = New System.Drawing.Size(257, 22)
    Me.txtSum.TabIndex = 5
    '
    'lblSum
    '
    Me.lblSum.AutoSize = True
    Me.lblSum.Location = New System.Drawing.Point(126, 241)
    Me.lblSum.Name = "lblSum"
    Me.lblSum.Size = New System.Drawing.Size(36, 17)
    Me.lblSum.TabIndex = 6
    Me.lblSum.Text = "Sum"
    '
    'frmAdd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.lblSum)
    Me.Controls.Add(Me.txtSum)
    Me.Controls.Add(Me.btnCompute)
    Me.Controls.Add(Me.txtSecondNum)
    Me.Controls.Add(Me.txtFirstNum)
    Me.Controls.Add(Me.lblSecondNum)
    Me.Controls.Add(Me.lblFirstNum)
    Me.Name = "frmAdd"
    Me.Text = "Addition"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblFirstNum As Label
  Friend WithEvents lblSecondNum As Label
  Friend WithEvents txtFirstNum As TextBox
  Friend WithEvents txtSecondNum As TextBox
  Friend WithEvents btnCompute As Button
  Friend WithEvents txtSum As TextBox
  Friend WithEvents lblSum As Label
End Class
