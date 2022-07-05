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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtbxViewer = New System.Windows.Forms.TextBox()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(219, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(221, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Contact Tracing Viewer"
        '
        'txtbxViewer
        '
        Me.txtbxViewer.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtbxViewer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxViewer.Location = New System.Drawing.Point(12, 48)
        Me.txtbxViewer.Multiline = True
        Me.txtbxViewer.Name = "txtbxViewer"
        Me.txtbxViewer.Size = New System.Drawing.Size(492, 313)
        Me.txtbxViewer.TabIndex = 1
        '
        'btnSelectFile
        '
        Me.btnSelectFile.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectFile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFile.Location = New System.Drawing.Point(510, 48)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(118, 39)
        Me.btnSelectFile.TabIndex = 2
        Me.btnSelectFile.Text = "SELECT FILE"
        Me.btnSelectFile.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(510, 107)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(510, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 371)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.txtbxViewer)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Contact Tracing Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtbxViewer As TextBox
    Friend WithEvents btnSelectFile As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
