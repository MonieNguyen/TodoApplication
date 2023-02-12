Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TodoAppDataSet.ToDoList' table. You can move, or remove it, as needed.
        Me.ToDoListTableAdapter.Fill(Me.TodoAppDataSet.ToDoList)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class
