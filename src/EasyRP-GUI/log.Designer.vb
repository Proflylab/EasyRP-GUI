<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class log
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(log))
        Me.BtnSaveLog = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'BtnSaveLog
        '
        Me.BtnSaveLog.AutoSize = True
        Me.BtnSaveLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSaveLog.Depth = 0
        Me.BtnSaveLog.Location = New System.Drawing.Point(413, 33)
        Me.BtnSaveLog.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSaveLog.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnSaveLog.Name = "BtnSaveLog"
        Me.BtnSaveLog.Primary = False
        Me.BtnSaveLog.Size = New System.Drawing.Size(76, 36)
        Me.BtnSaveLog.TabIndex = 9
        Me.BtnSaveLog.Text = "Save log"
        Me.BtnSaveLog.UseVisualStyleBackColor = True
        '
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 61)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.Size = New System.Drawing.Size(502, 314)
        Me.TxtLog.TabIndex = 10
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.FileName = "easyrp-gui-log.txt"
        Me.SaveFileDialog.Filter = "Text files|*.txt"
        Me.SaveFileDialog.Title = "Save log"
        '
        'log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 375)
        Me.Controls.Add(Me.BtnSaveLog)
        Me.Controls.Add(Me.TxtLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "log"
        Me.Sizable = False
        Me.Text = "Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSaveLog As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents SaveFileDialog As SaveFileDialog
End Class
