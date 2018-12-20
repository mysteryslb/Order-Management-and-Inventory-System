<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCustomerSupport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCustomerSupport))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnOwner = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        Me.BtnReserved = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSched = New System.Windows.Forms.Button()
        Me.BtnMini = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Verification.My.Resources.Resources.custinfo
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 318)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnOwner
        '
        Me.BtnOwner.BackColor = System.Drawing.Color.White
        Me.BtnOwner.BackgroundImage = Global.Verification.My.Resources.Resources.addbg2
        Me.BtnOwner.Font = New System.Drawing.Font("BankGothic Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOwner.Location = New System.Drawing.Point(492, 287)
        Me.BtnOwner.Name = "BtnOwner"
        Me.BtnOwner.Size = New System.Drawing.Size(112, 31)
        Me.BtnOwner.TabIndex = 3
        Me.BtnOwner.Text = "EXIT"
        Me.BtnOwner.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.White
        Me.btnCreate.BackgroundImage = Global.Verification.My.Resources.Resources.exitbtn
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(222, 97)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(177, 86)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "CREATE AN ORDER"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'BtnModify
        '
        Me.BtnModify.BackColor = System.Drawing.Color.White
        Me.BtnModify.BackgroundImage = CType(resources.GetObject("BtnModify.BackgroundImage"), System.Drawing.Image)
        Me.BtnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModify.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModify.Location = New System.Drawing.Point(222, 189)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(177, 86)
        Me.BtnModify.TabIndex = 5
        Me.BtnModify.Text = "MODIFY ORDERS"
        Me.BtnModify.UseVisualStyleBackColor = False
        '
        'BtnReserved
        '
        Me.BtnReserved.BackColor = System.Drawing.Color.White
        Me.BtnReserved.BackgroundImage = CType(resources.GetObject("BtnReserved.BackgroundImage"), System.Drawing.Image)
        Me.BtnReserved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReserved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReserved.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReserved.Location = New System.Drawing.Point(405, 97)
        Me.BtnReserved.Name = "BtnReserved"
        Me.BtnReserved.Size = New System.Drawing.Size(185, 86)
        Me.BtnReserved.TabIndex = 6
        Me.BtnReserved.Text = "RESERVATION LIST"
        Me.BtnReserved.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CUSTOMER SUPPORT"
        '
        'BtnSched
        '
        Me.BtnSched.BackColor = System.Drawing.Color.White
        Me.BtnSched.BackgroundImage = CType(resources.GetObject("BtnSched.BackgroundImage"), System.Drawing.Image)
        Me.BtnSched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSched.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSched.Location = New System.Drawing.Point(406, 189)
        Me.BtnSched.Name = "BtnSched"
        Me.BtnSched.Size = New System.Drawing.Size(184, 86)
        Me.BtnSched.TabIndex = 8
        Me.BtnSched.Text = "CATERING SCHEDULES"
        Me.BtnSched.UseVisualStyleBackColor = False
        '
        'BtnMini
        '
        Me.BtnMini.BackgroundImage = Global.Verification.My.Resources.Resources.minimize
        Me.BtnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMini.Location = New System.Drawing.Point(565, 0)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(39, 26)
        Me.BtnMini.TabIndex = 9
        Me.BtnMini.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("BankGothic Md BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(-2, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "MODIFY MY ACCOUNT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdminCustomerSupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Verification.My.Resources.Resources.addbg
        Me.ClientSize = New System.Drawing.Size(602, 317)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnMini)
        Me.Controls.Add(Me.BtnSched)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnReserved)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.BtnOwner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminCustomerSupport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminCustomerSupport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnOwner As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents BtnModify As Button
    Friend WithEvents BtnReserved As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSched As Button
    Friend WithEvents BtnMini As Button
    Friend WithEvents Button1 As Button
End Class
