<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.AccountListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsDataSet = New Verification.accountsDataSet()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtRole = New System.Windows.Forms.TextBox()
        Me.TxtError = New System.Windows.Forms.TextBox()
        Me.AccountListTableAdapter = New Verification.accountsDataSetTableAdapters.AccountListTableAdapter()
        Me.TableAdapterManager = New Verification.accountsDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        RoleLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(207, 35)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 9
        UsernameLabel.Text = "Username:"
        AddHandler UsernameLabel.Click, AddressOf Me.UsernameLabel_Click
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(207, 61)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "Password:"
        AddHandler PasswordLabel.Click, AddressOf Me.PasswordLabel_Click
        '
        'RoleLabel
        '
        RoleLabel.AutoSize = True
        RoleLabel.Location = New System.Drawing.Point(207, 87)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New System.Drawing.Size(65, 13)
        RoleLabel.TabIndex = 13
        RoleLabel.Text = "Department:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(10, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.BackgroundImage = Global.Verification.My.Resources.Resources.addbg2
        Me.BtnExit.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(230, 132)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(110, 32)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "RESET"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.White
        Me.BtnSubmit.BackgroundImage = Global.Verification.My.Resources.Resources.addbg2
        Me.BtnSubmit.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(364, 132)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(109, 32)
        Me.BtnSubmit.TabIndex = 6
        Me.BtnSubmit.Text = "SUBMIT"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'TxtUser
        '
        Me.TxtUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountListBindingSource, "Username", True))
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(278, 32)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(215, 20)
        Me.TxtUser.TabIndex = 10
        '
        'AccountListBindingSource
        '
        Me.AccountListBindingSource.DataMember = "AccountList"
        Me.AccountListBindingSource.DataSource = Me.AccountsDataSet
        '
        'AccountsDataSet
        '
        Me.AccountsDataSet.DataSetName = "accountsDataSet"
        Me.AccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtPass
        '
        Me.TxtPass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountListBindingSource, "Password", True))
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(278, 58)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(215, 20)
        Me.TxtPass.TabIndex = 12
        '
        'TxtRole
        '
        Me.TxtRole.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountListBindingSource, "Role", True))
        Me.TxtRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRole.Location = New System.Drawing.Point(278, 84)
        Me.TxtRole.Name = "TxtRole"
        Me.TxtRole.Size = New System.Drawing.Size(215, 20)
        Me.TxtRole.TabIndex = 14
        '
        'TxtError
        '
        Me.TxtError.BackColor = System.Drawing.Color.PeachPuff
        Me.TxtError.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtError.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtError.Location = New System.Drawing.Point(230, 170)
        Me.TxtError.Name = "TxtError"
        Me.TxtError.Size = New System.Drawing.Size(243, 16)
        Me.TxtError.TabIndex = 15
        '
        'AccountListTableAdapter
        '
        Me.AccountListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountListTableAdapter = Me.AccountListTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Verification.accountsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NOTE: Indicate your department. (owner, finance, customersupport)"
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.BackgroundImage = Global.Verification.My.Resources.Resources.addbg1
        Me.chkShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPass.Location = New System.Drawing.Point(391, 109)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPass.TabIndex = 17
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Verification.My.Resources.Resources.addbg1
        Me.ClientSize = New System.Drawing.Size(509, 197)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtError)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(RoleLabel)
        Me.Controls.Add(Me.TxtRole)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents AccountsDataSet As accountsDataSet
    Friend WithEvents AccountListBindingSource As BindingSource
    Friend WithEvents AccountListTableAdapter As accountsDataSetTableAdapters.AccountListTableAdapter
    Friend WithEvents TableAdapterManager As accountsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtRole As TextBox
    Friend WithEvents TxtError As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShowPass As CheckBox
End Class
