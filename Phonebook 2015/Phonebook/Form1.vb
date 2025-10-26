Public Class Form1
    Public Property From2 As Object

    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Login' table. You can move, or remove it, as needed.
        Try
            Me.LoginTableAdapter.Fill(Me.DatabaseDataSet.Login)
        Catch ex As Exception
            MessageBox.Show("Error loading login data: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String = TextBox1.Text
        Dim Password As String = TextBox2.Text

        ' Ensure LoginQuery returns a Boolean value
        Dim isAuthenticated As Boolean = False
        Try
            isAuthenticated = CBool(Me.LoginTableAdapter.LoginQuery(Username, Password))
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If isAuthenticated Then
            MsgBox("LOGIN OK")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("INCORRECT USERNAME & PASSWORD")
            ' Optionally, do not close the form immediately to allow retry
            ' Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
