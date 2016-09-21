<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthongke
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
        Me.dtgvthongke = New System.Windows.Forms.DataGridView()
        Me.lbltensach = New System.Windows.Forms.Label()
        Me.lblmasach = New System.Windows.Forms.Label()
        Me.lbltheloai = New System.Windows.Forms.Label()
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.txttheloai = New System.Windows.Forms.TextBox()
        CType(Me.dtgvthongke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvthongke
        '
        Me.dtgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvthongke.Location = New System.Drawing.Point(15, 158)
        Me.dtgvthongke.Name = "dtgvthongke"
        Me.dtgvthongke.Size = New System.Drawing.Size(597, 232)
        Me.dtgvthongke.TabIndex = 0
        '
        'lbltensach
        '
        Me.lbltensach.AutoSize = True
        Me.lbltensach.Location = New System.Drawing.Point(12, 34)
        Me.lbltensach.Name = "lbltensach"
        Me.lbltensach.Size = New System.Drawing.Size(52, 13)
        Me.lbltensach.TabIndex = 1
        Me.lbltensach.Text = "Tên sách"
        '
        'lblmasach
        '
        Me.lblmasach.AutoSize = True
        Me.lblmasach.Location = New System.Drawing.Point(12, 72)
        Me.lblmasach.Name = "lblmasach"
        Me.lblmasach.Size = New System.Drawing.Size(48, 13)
        Me.lblmasach.TabIndex = 2
        Me.lblmasach.Text = "Mã sách"
        '
        'lbltheloai
        '
        Me.lbltheloai.AutoSize = True
        Me.lbltheloai.Location = New System.Drawing.Point(12, 109)
        Me.lbltheloai.Name = "lbltheloai"
        Me.lbltheloai.Size = New System.Drawing.Size(45, 13)
        Me.lbltheloai.TabIndex = 3
        Me.lbltheloai.Text = "Thể loại"
        '
        'txttensach
        '
        Me.txttensach.Location = New System.Drawing.Point(77, 31)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.Size = New System.Drawing.Size(100, 20)
        Me.txttensach.TabIndex = 4
        '
        'txtmasach
        '
        Me.txtmasach.Location = New System.Drawing.Point(77, 69)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.Size = New System.Drawing.Size(100, 20)
        Me.txtmasach.TabIndex = 5
        '
        'txttheloai
        '
        Me.txttheloai.Location = New System.Drawing.Point(77, 106)
        Me.txttheloai.Name = "txttheloai"
        Me.txttheloai.Size = New System.Drawing.Size(100, 20)
        Me.txttheloai.TabIndex = 6
        '
        'frmthongke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 402)
        Me.Controls.Add(Me.txttheloai)
        Me.Controls.Add(Me.txtmasach)
        Me.Controls.Add(Me.txttensach)
        Me.Controls.Add(Me.lbltheloai)
        Me.Controls.Add(Me.lblmasach)
        Me.Controls.Add(Me.lbltensach)
        Me.Controls.Add(Me.dtgvthongke)
        Me.Name = "frmthongke"
        Me.Text = "Thống kê"
        CType(Me.dtgvthongke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgvthongke As System.Windows.Forms.DataGridView
    Friend WithEvents lbltensach As System.Windows.Forms.Label
    Friend WithEvents lblmasach As System.Windows.Forms.Label
    Friend WithEvents lbltheloai As System.Windows.Forms.Label
    Friend WithEvents txttensach As System.Windows.Forms.TextBox
    Friend WithEvents txtmasach As System.Windows.Forms.TextBox
    Friend WithEvents txttheloai As System.Windows.Forms.TextBox
End Class
