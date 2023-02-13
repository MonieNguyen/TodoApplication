Imports System.Text.RegularExpressions

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StatusSource As String() = New String() {"New", "Doing", "Completed", "Pending"}
        Me.StatusDataGridViewComboBoxColumn.DataSource = StatusSource

        'TODO: This line of code loads data into the 'TodoAppDataSet.ToDoList' table. You can move, or remove it, as needed.
        LoadDataGridView()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim taskDetail = txbTaskDetail.Text
        Dim priority = txbPriority.Text
        If ValidateTaskDetail(taskDetail) = False _
            Or ValidatePriority(priority) = False Then
            MsgBox("Task Detail and Priority fields cannot be empty" &
                   vbNewLine & "Please enter data in both fields",
                   MessageBoxIcon.Error)
        ElseIf Not Regex.IsMatch(priority, "^[0-9 ]+$") Then
            MsgBox("Priority can only be a number", MessageBoxIcon.Error)
        Else
            'Insert data into DB
            Me.ToDoListTableAdapter.Insert(taskDetail, priority, "New")

            'Re-load displayed data
            LoadDataGridView()

            'Re-set input fields
            txbTaskDetail.Text = ""
            txbPriority.Text = ""
        End If
    End Sub

    Private Sub DataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) _
        Handles DataGridView.CellEndEdit
        'Check if cell is null, prompt error message box
        Dim cellValue = Me.DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        If IsDBNull(cellValue) Then 'TODO: Handle null or empty value
            MsgBox("This field cannot be empty." & vbNewLine & "Please enter data", MessageBoxIcon.Error)
        End If

        'Get ID of edited row
        Dim id = Me.DataGridView.Rows(e.RowIndex).Cells(0).Value

        'Update edited data to DB based on edited column index
        Select Case e.ColumnIndex
            Case 1
                Me.ToDoListTableAdapter.UpdateTaskDetail(cellValue, id)
            Case 2
                Me.ToDoListTableAdapter.UpdatePriority(cellValue, id)
            Case 3
                Me.ToDoListTableAdapter.UpdateStatus(cellValue, id) 'TODO: convert integer to text
            Case Else
                Debug.WriteLine("Out of editable cell")
        End Select
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles DataGridView.CellClick
        'Check if the Status column is clicked
        If e.ColumnIndex = 3 Then


            'Check if the Action colum is clicked
        ElseIf e.ColumnIndex = 4 Then

            'Check if the rowIndex is valid, then show and message box to confirm before deleting
            If e.RowIndex >= 0 And e.RowIndex < DataGridView.Rows.Count Then
                Dim MsgConfirm = MsgBox("Are you sure you want to delete this task?", vbYesNo)
                If MsgConfirm = vbYes Then
                    'Get Id of selected row
                    Dim id = Me.DataGridView.Rows(e.RowIndex).Cells(0).Value
                    Me.ToDoListTableAdapter.UpdateStatus("Deleted", id)
                    LoadDataGridView()
                End If
            End If
        End If
    End Sub

    Private Sub LoadDataGridView()
        Me.ToDoListTableAdapter.Fill(Me.TodoAppDataSet.ToDoList)
    End Sub

    Private Function ValidateTaskDetail(taskDetail As String) As Boolean
        taskDetail = taskDetail.Trim

        Return Not (String.IsNullOrEmpty(taskDetail) Or taskDetail.Length > 100)
    End Function

    Private Function ValidatePriority(priority As String) As Boolean
        priority = priority.Trim

        Return Not (String.IsNullOrEmpty(priority) Or priority.Length > 2)
    End Function
End Class
