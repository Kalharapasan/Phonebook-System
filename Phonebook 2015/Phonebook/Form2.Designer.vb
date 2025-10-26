<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim FullnameLabel As System.Windows.Forms.Label
        Dim BerthdayLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddersLabel As System.Windows.Forms.Label
        Dim CantrreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DatabaseDataSet = New Phonebook.DatabaseDataSet()
        Me.PhonebookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhonebookTableAdapter = New Phonebook.DatabaseDataSetTableAdapters.phonebookTableAdapter()
        Me.TableAdapterManager = New Phonebook.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PhonebookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PhonebookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FullnameTextBox = New System.Windows.Forms.TextBox()
        Me.BerthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderCheckBox = New System.Windows.Forms.CheckBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddersTextBox = New System.Windows.Forms.TextBox()
        Me.CantrreTextBox = New System.Windows.Forms.TextBox()
        Me.PhonebookDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PhonebookTableAdapter1 = New Phonebook.DatabaseDataSetTableAdapters.phonebookTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        FullnameLabel = New System.Windows.Forms.Label()
        BerthdayLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddersLabel = New System.Windows.Forms.Label()
        CantrreLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhonebookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhonebookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhonebookBindingNavigator.SuspendLayout()
        CType(Me.PhonebookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullnameLabel
        '
        FullnameLabel.AutoSize = True
        FullnameLabel.Location = New System.Drawing.Point(18, 28)
        FullnameLabel.Name = "FullnameLabel"
        FullnameLabel.Size = New System.Drawing.Size(52, 13)
        FullnameLabel.TabIndex = 3
        FullnameLabel.Text = "Fullname:"
        '
        'BerthdayLabel
        '
        BerthdayLabel.AutoSize = True
        BerthdayLabel.Location = New System.Drawing.Point(18, 55)
        BerthdayLabel.Name = "BerthdayLabel"
        BerthdayLabel.Size = New System.Drawing.Size(52, 13)
        BerthdayLabel.TabIndex = 5
        BerthdayLabel.Text = "Berthday:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(18, 82)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(18, 110)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 9
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(18, 136)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'AddersLabel
        '
        AddersLabel.AutoSize = True
        AddersLabel.Location = New System.Drawing.Point(18, 162)
        AddersLabel.Name = "AddersLabel"
        AddersLabel.Size = New System.Drawing.Size(43, 13)
        AddersLabel.TabIndex = 13
        AddersLabel.Text = "Adders:"
        '
        'CantrreLabel
        '
        CantrreLabel.AutoSize = True
        CantrreLabel.Location = New System.Drawing.Point(18, 188)
        CantrreLabel.Name = "CantrreLabel"
        CantrreLabel.Size = New System.Drawing.Size(44, 13)
        CantrreLabel.TabIndex = 15
        CantrreLabel.Text = "Cantrre:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhonebookBindingSource
        '
        Me.PhonebookBindingSource.DataMember = "phonebook"
        Me.PhonebookBindingSource.DataSource = Me.DatabaseDataSet
        '
        'PhonebookTableAdapter
        '
        Me.PhonebookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.phonebookTableAdapter = Me.PhonebookTableAdapter
        Me.TableAdapterManager.UpdateOrder = Phonebook.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PhonebookBindingNavigator
        '
        Me.PhonebookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PhonebookBindingNavigator.BindingSource = Me.PhonebookBindingSource
        Me.PhonebookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PhonebookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PhonebookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PhonebookBindingNavigatorSaveItem})
        Me.PhonebookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PhonebookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PhonebookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PhonebookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PhonebookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PhonebookBindingNavigator.Name = "PhonebookBindingNavigator"
        Me.PhonebookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PhonebookBindingNavigator.Size = New System.Drawing.Size(1206, 25)
        Me.PhonebookBindingNavigator.TabIndex = 0
        Me.PhonebookBindingNavigator.Text = "BindingNavigator1"
        Me.PhonebookBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PhonebookBindingNavigatorSaveItem
        '
        Me.PhonebookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PhonebookBindingNavigatorSaveItem.Image = CType(resources.GetObject("PhonebookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PhonebookBindingNavigatorSaveItem.Name = "PhonebookBindingNavigatorSaveItem"
        Me.PhonebookBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PhonebookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhonebookBindingSource, "Fullname", True))
        Me.FullnameTextBox.Location = New System.Drawing.Point(105, 25)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FullnameTextBox.TabIndex = 4
        '
        'BerthdayDateTimePicker
        '
        Me.BerthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PhonebookBindingSource, "Berthday", True))
        Me.BerthdayDateTimePicker.Location = New System.Drawing.Point(105, 51)
        Me.BerthdayDateTimePicker.Name = "BerthdayDateTimePicker"
        Me.BerthdayDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BerthdayDateTimePicker.TabIndex = 6
        '
        'GenderCheckBox
        '
        Me.GenderCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PhonebookBindingSource, "Gender", True))
        Me.GenderCheckBox.Location = New System.Drawing.Point(105, 77)
        Me.GenderCheckBox.Name = "GenderCheckBox"
        Me.GenderCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.GenderCheckBox.TabIndex = 8
        Me.GenderCheckBox.Text = "Mail"
        Me.GenderCheckBox.UseVisualStyleBackColor = True
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhonebookBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(105, 107)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneNumberTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhonebookBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(105, 133)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'AddersTextBox
        '
        Me.AddersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhonebookBindingSource, "Adders", True))
        Me.AddersTextBox.Location = New System.Drawing.Point(105, 159)
        Me.AddersTextBox.Name = "AddersTextBox"
        Me.AddersTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddersTextBox.TabIndex = 14
        '
        'CantrreTextBox
        '
        Me.CantrreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhonebookBindingSource, "Cantrre", True))
        Me.CantrreTextBox.Location = New System.Drawing.Point(105, 185)
        Me.CantrreTextBox.Name = "CantrreTextBox"
        Me.CantrreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantrreTextBox.TabIndex = 16
        '
        'PhonebookDataGridView
        '
        Me.PhonebookDataGridView.AutoGenerateColumns = False
        Me.PhonebookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PhonebookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PhonebookDataGridView.DataSource = Me.PhonebookBindingSource
        Me.PhonebookDataGridView.Location = New System.Drawing.Point(328, 25)
        Me.PhonebookDataGridView.Name = "PhonebookDataGridView"
        Me.PhonebookDataGridView.Size = New System.Drawing.Size(843, 220)
        Me.PhonebookDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fullname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fullname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Berthday"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Berthday"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Gender"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Gender"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Adders"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Adders"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantrre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantrre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(198, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PhonebookTableAdapter1
        '
        Me.PhonebookTableAdapter1.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(279, 274)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 309)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PhonebookDataGridView)
        Me.Controls.Add(FullnameLabel)
        Me.Controls.Add(Me.FullnameTextBox)
        Me.Controls.Add(BerthdayLabel)
        Me.Controls.Add(Me.BerthdayDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderCheckBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AddersLabel)
        Me.Controls.Add(Me.AddersTextBox)
        Me.Controls.Add(CantrreLabel)
        Me.Controls.Add(Me.CantrreTextBox)
        Me.Controls.Add(Me.PhonebookBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhonebookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhonebookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhonebookBindingNavigator.ResumeLayout(False)
        Me.PhonebookBindingNavigator.PerformLayout()
        CType(Me.PhonebookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents PhonebookBindingSource As BindingSource
    Friend WithEvents PhonebookTableAdapter As DatabaseDataSetTableAdapters.phonebookTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhonebookBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PhonebookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FullnameTextBox As TextBox
    Friend WithEvents BerthdayDateTimePicker As DateTimePicker
    Friend WithEvents GenderCheckBox As CheckBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddersTextBox As TextBox
    Friend WithEvents CantrreTextBox As TextBox
    Friend WithEvents PhonebookDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PhonebookTableAdapter1 As DatabaseDataSetTableAdapters.phonebookTableAdapter
    Friend WithEvents Button4 As Button
End Class
