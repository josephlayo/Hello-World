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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lnkClearEncrypted = New System.Windows.Forms.LinkLabel
        Me.lnkClearUnencrypted = New System.Windows.Forms.LinkLabel
        Me.tbPassphrase = New System.Windows.Forms.TextBox
        Me.lblPassphrase = New System.Windows.Forms.Label
        Me.lblRecipientKey = New System.Windows.Forms.Label
        Me.gvKeys = New System.Windows.Forms.DataGridView
        Me.label2 = New System.Windows.Forms.Label
        Me.tbEncrypted = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.btnDecrypt = New System.Windows.Forms.Button
        Me.btnEncrypt = New System.Windows.Forms.Button
        Me.tbUnencrypted = New System.Windows.Forms.TextBox
        CType(Me.gvKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkClearEncrypted
        '
        Me.lnkClearEncrypted.AutoSize = True
        Me.lnkClearEncrypted.Location = New System.Drawing.Point(601, 151)
        Me.lnkClearEncrypted.Name = "lnkClearEncrypted"
        Me.lnkClearEncrypted.Size = New System.Drawing.Size(74, 13)
        Me.lnkClearEncrypted.TabIndex = 78
        Me.lnkClearEncrypted.TabStop = True
        Me.lnkClearEncrypted.Text = "clear contents"
        '
        'lnkClearUnencrypted
        '
        Me.lnkClearUnencrypted.AutoSize = True
        Me.lnkClearUnencrypted.Location = New System.Drawing.Point(601, 10)
        Me.lnkClearUnencrypted.Name = "lnkClearUnencrypted"
        Me.lnkClearUnencrypted.Size = New System.Drawing.Size(74, 13)
        Me.lnkClearUnencrypted.TabIndex = 77
        Me.lnkClearUnencrypted.TabStop = True
        Me.lnkClearUnencrypted.Text = "clear contents"
        '
        'tbPassphrase
        '
        Me.tbPassphrase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPassphrase.Location = New System.Drawing.Point(15, 454)
        Me.tbPassphrase.Name = "tbPassphrase"
        Me.tbPassphrase.Size = New System.Drawing.Size(656, 20)
        Me.tbPassphrase.TabIndex = 76
        Me.tbPassphrase.UseSystemPasswordChar = True
        '
        'lblPassphrase
        '
        Me.lblPassphrase.AutoSize = True
        Me.lblPassphrase.Location = New System.Drawing.Point(12, 438)
        Me.lblPassphrase.Name = "lblPassphrase"
        Me.lblPassphrase.Size = New System.Drawing.Size(62, 13)
        Me.lblPassphrase.TabIndex = 75
        Me.lblPassphrase.Text = "Passphrase"
        '
        'lblRecipientKey
        '
        Me.lblRecipientKey.AutoSize = True
        Me.lblRecipientKey.Location = New System.Drawing.Point(13, 293)
        Me.lblRecipientKey.Name = "lblRecipientKey"
        Me.lblRecipientKey.Size = New System.Drawing.Size(30, 13)
        Me.lblRecipientKey.TabIndex = 74
        Me.lblRecipientKey.Text = "Keys"
        '
        'gvKeys
        '
        Me.gvKeys.AllowUserToAddRows = False
        Me.gvKeys.AllowUserToDeleteRows = False
        Me.gvKeys.AllowUserToOrderColumns = True
        Me.gvKeys.AllowUserToResizeRows = False
        Me.gvKeys.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvKeys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvKeys.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gvKeys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gvKeys.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvKeys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvKeys.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvKeys.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvKeys.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.gvKeys.Location = New System.Drawing.Point(15, 309)
        Me.gvKeys.MultiSelect = False
        Me.gvKeys.Name = "gvKeys"
        Me.gvKeys.ReadOnly = True
        Me.gvKeys.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvKeys.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvKeys.RowHeadersVisible = False
        Me.gvKeys.RowHeadersWidth = 20
        Me.gvKeys.RowTemplate.Height = 16
        Me.gvKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvKeys.Size = New System.Drawing.Size(656, 118)
        Me.gvKeys.TabIndex = 73
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 151)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 13)
        Me.label2.TabIndex = 72
        Me.label2.Text = "Encrypted Text"
        '
        'tbEncrypted
        '
        Me.tbEncrypted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEncrypted.Location = New System.Drawing.Point(12, 167)
        Me.tbEncrypted.Multiline = True
        Me.tbEncrypted.Name = "tbEncrypted"
        Me.tbEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbEncrypted.Size = New System.Drawing.Size(658, 114)
        Me.tbEncrypted.TabIndex = 71
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 13)
        Me.label1.TabIndex = 70
        Me.label1.Text = "Unencrypted Text"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(97, 489)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 68
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(16, 489)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrypt.TabIndex = 67
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'tbUnencrypted
        '
        Me.tbUnencrypted.Location = New System.Drawing.Point(16, 26)
        Me.tbUnencrypted.Multiline = True
        Me.tbUnencrypted.Name = "tbUnencrypted"
        Me.tbUnencrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbUnencrypted.Size = New System.Drawing.Size(654, 111)
        Me.tbUnencrypted.TabIndex = 79
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 517)
        Me.Controls.Add(Me.tbUnencrypted)
        Me.Controls.Add(Me.lnkClearEncrypted)
        Me.Controls.Add(Me.lnkClearUnencrypted)
        Me.Controls.Add(Me.tbPassphrase)
        Me.Controls.Add(Me.lblPassphrase)
        Me.Controls.Add(Me.lblRecipientKey)
        Me.Controls.Add(Me.gvKeys)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbEncrypted)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Name = "Form1"
        Me.Text = "Starksoft OpenPGP VB Example"
        CType(Me.gvKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lnkClearEncrypted As System.Windows.Forms.LinkLabel
    Private WithEvents lnkClearUnencrypted As System.Windows.Forms.LinkLabel
    Private WithEvents tbPassphrase As System.Windows.Forms.TextBox
    Private WithEvents lblPassphrase As System.Windows.Forms.Label
    Private WithEvents lblRecipientKey As System.Windows.Forms.Label
    Private WithEvents gvKeys As System.Windows.Forms.DataGridView
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents tbEncrypted As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnDecrypt As System.Windows.Forms.Button
    Private WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents tbUnencrypted As System.Windows.Forms.TextBox

End Class
