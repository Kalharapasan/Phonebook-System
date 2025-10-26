Public Class Form2
    Public Property PhonebookDataSet As Object

    Private Sub PhonebookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PhonebookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PhonebookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.phonebook' table. You can move, or remove it, as needed.
        Me.PhonebookTableAdapter.Fill(Me.DatabaseDataSet.phonebook)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PhonebookBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PhonebookBindingSource.EndEdit()
        PhonebookTableAdapter.Update(PhonebookDataSet.phonebook)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PhonebookBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class