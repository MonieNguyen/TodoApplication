<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ToDoListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TodoAppDataSet = New TodoApplication.TodoAppDataSet()
        Me.lbToDoList = New System.Windows.Forms.Label()
        Me.lbTaskDetail = New System.Windows.Forms.Label()
        Me.lbPriority = New System.Windows.Forms.Label()
        Me.lbAddNew = New System.Windows.Forms.Label()
        Me.lbPriorityErrorMessage = New System.Windows.Forms.Label()
        Me.txbTaskDetail = New System.Windows.Forms.TextBox()
        Me.txbPriority = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ToDoListTableAdapter = New TodoApplication.TodoAppDataSetTableAdapters.ToDoListTableAdapter()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Task_DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDoListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodoAppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Task_DetailDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.StatusDataGridViewComboBoxColumn, Me.btnDelete})
        Me.DataGridView.DataSource = Me.ToDoListBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(26, 40)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(646, 138)
        Me.DataGridView.TabIndex = 0
        '
        'ToDoListBindingSource
        '
        Me.ToDoListBindingSource.DataMember = "ToDoList"
        Me.ToDoListBindingSource.DataSource = Me.TodoAppDataSet
        '
        'TodoAppDataSet
        '
        Me.TodoAppDataSet.DataSetName = "TodoAppDataSet"
        Me.TodoAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbToDoList
        '
        Me.lbToDoList.AutoSize = True
        Me.lbToDoList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbToDoList.Location = New System.Drawing.Point(277, 9)
        Me.lbToDoList.Name = "lbToDoList"
        Me.lbToDoList.Size = New System.Drawing.Size(120, 25)
        Me.lbToDoList.TabIndex = 1
        Me.lbToDoList.Text = "To Do List"
        '
        'lbTaskDetail
        '
        Me.lbTaskDetail.AutoSize = True
        Me.lbTaskDetail.Location = New System.Drawing.Point(23, 237)
        Me.lbTaskDetail.Name = "lbTaskDetail"
        Me.lbTaskDetail.Size = New System.Drawing.Size(61, 13)
        Me.lbTaskDetail.TabIndex = 2
        Me.lbTaskDetail.Text = "Task Detail"
        '
        'lbPriority
        '
        Me.lbPriority.AutoSize = True
        Me.lbPriority.Location = New System.Drawing.Point(521, 237)
        Me.lbPriority.Name = "lbPriority"
        Me.lbPriority.Size = New System.Drawing.Size(38, 13)
        Me.lbPriority.TabIndex = 3
        Me.lbPriority.Text = "Priority"
        '
        'lbAddNew
        '
        Me.lbAddNew.AutoSize = True
        Me.lbAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddNew.Location = New System.Drawing.Point(26, 202)
        Me.lbAddNew.Name = "lbAddNew"
        Me.lbAddNew.Size = New System.Drawing.Size(146, 24)
        Me.lbAddNew.TabIndex = 4
        Me.lbAddNew.Text = "Add New Task"
        '
        'lbPriorityErrorMessage
        '
        Me.lbPriorityErrorMessage.AutoSize = True
        Me.lbPriorityErrorMessage.Location = New System.Drawing.Point(559, 254)
        Me.lbPriorityErrorMessage.Name = "lbPriorityErrorMessage"
        Me.lbPriorityErrorMessage.Size = New System.Drawing.Size(0, 13)
        Me.lbPriorityErrorMessage.TabIndex = 5
        '
        'txbTaskDetail
        '
        Me.txbTaskDetail.Location = New System.Drawing.Point(91, 237)
        Me.txbTaskDetail.MaxLength = 100
        Me.txbTaskDetail.Name = "txbTaskDetail"
        Me.txbTaskDetail.Size = New System.Drawing.Size(424, 20)
        Me.txbTaskDetail.TabIndex = 6
        '
        'txbPriority
        '
        Me.txbPriority.Location = New System.Drawing.Point(562, 236)
        Me.txbPriority.MaxLength = 2
        Me.txbPriority.Name = "txbPriority"
        Me.txbPriority.Size = New System.Drawing.Size(38, 20)
        Me.txbPriority.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(617, 235)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'ToDoListTableAdapter
        '
        Me.ToDoListTableAdapter.ClearBeforeFill = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Task_DetailDataGridViewTextBoxColumn
        '
        Me.Task_DetailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Task_DetailDataGridViewTextBoxColumn.DataPropertyName = "Task Detail"
        Me.Task_DetailDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.Task_DetailDataGridViewTextBoxColumn.HeaderText = "Task Detail"
        Me.Task_DetailDataGridViewTextBoxColumn.MaxInputLength = 100
        Me.Task_DetailDataGridViewTextBoxColumn.Name = "Task_DetailDataGridViewTextBoxColumn"
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.MaxInputLength = 2
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.Width = 50
        '
        'StatusDataGridViewComboBoxColumn
        '
        Me.StatusDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.StatusDataGridViewComboBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewComboBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewComboBoxColumn.Name = "StatusDataGridViewComboBoxColumn"
        Me.StatusDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StatusDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.StatusDataGridViewComboBoxColumn.Width = 90
        '
        'btnDelete
        '
        Me.btnDelete.HeaderText = "Action"
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        Me.btnDelete.Width = 50
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 277)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txbPriority)
        Me.Controls.Add(Me.txbTaskDetail)
        Me.Controls.Add(Me.lbPriorityErrorMessage)
        Me.Controls.Add(Me.lbAddNew)
        Me.Controls.Add(Me.lbPriority)
        Me.Controls.Add(Me.lbTaskDetail)
        Me.Controls.Add(Me.lbToDoList)
        Me.Controls.Add(Me.DataGridView)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "MainForm"
        Me.Text = "Simple To Do Application for Windows"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDoListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodoAppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents TodoAppDataSet As TodoAppDataSet
    Friend WithEvents ToDoListBindingSource As BindingSource
    Friend WithEvents ToDoListTableAdapter As TodoAppDataSetTableAdapters.ToDoListTableAdapter
    Friend WithEvents lbToDoList As Label
    Friend WithEvents lbTaskDetail As Label
    Friend WithEvents lbPriority As Label
    Friend WithEvents lbAddNew As Label
    Friend WithEvents lbPriorityErrorMessage As Label
    Friend WithEvents txbTaskDetail As TextBox
    Friend WithEvents txbPriority As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Task_DetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewComboBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
End Class
