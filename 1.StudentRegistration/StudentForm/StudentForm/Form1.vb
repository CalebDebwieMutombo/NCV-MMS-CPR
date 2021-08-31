Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '1. Declare the Connection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Declare the Command object
        Dim cmdCommand As New OleDb.OleDbCommand
        '3. Assign the path to the connection property of the conConnectionString object
        conConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\L4\CPR\1.StudentRegistration\StudentDatabase.mdb"
        '4. Open the Connection object
        conConnection.Open()
        '5. Assign the conConnection object to the Connection property of the Command object
        cmdCommand.Connection = conConnection
        '6 Assign the SQL statement to to the CommandText property of the Command object
        cmdCommand.CommandText = "INSERT INTO StudentDetails(StudentNumber,Firstname,Surname,MobileNumber,Email)VALUES(@StudentNumber,@Firstname,@Surname,@MobileNumber,@Email)"
        'Declare a parameter
        Dim parStudentNumber As New OleDb.OleDbParameter("@StudentNumber", txtStudentNumber.Text)
        Dim parFirstname As New OleDb.OleDbParameter("@Firstname", txtFirstname.Text)
        Dim parSurname As New OleDb.OleDbParameter("@Surname", txtSurname.Text)
        Dim parMobileNumber As New OleDb.OleDbParameter("@MobileNumber", txtMobileNumber.Text)
        Dim parEmail As New OleDb.OleDbParameter("@Email", txtEmail.Text)
        '8. Add the parameter to the Command object
        cmdCommand.Parameters.Add(parStudentNumber)
        cmdCommand.Parameters.Add(parFirstname)
        cmdCommand.Parameters.Add(parSurname)
        cmdCommand.Parameters.Add(parMobileNumber)
        cmdCommand.Parameters.Add(parEmail)
        '9 Perform the ExecuteNoQuery method on the cmdCommand object
        cmdCommand.ExecuteNonQuery()
        '10. Close conConnection object
        conConnection.Close()
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        '1. Declare the Connection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Declare the Command object
        Dim cmdCommand As New OleDb.OleDbCommand
        '3. Assign the path to the connection property of the conConnectionString object
        conConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Z:\L4\CPR\1.StudentRegistration\StudentDatabase.mdb"
        '4. Open the Connection object
        conConnection.Open()
        '5. Assign the conConnection object to the Connection property of the Command object
        cmdCommand.Connection = conConnection
        '6 Assign the SQL statement to to the CommandText property of the Command object
        cmdCommand.CommandText = "UPDATE StudentDetails SET MobileNumber = @MobileNumber WHERE StudentNumber=@StudentNumber"
        'Declare a parameter
        Dim parStudentNumber As New OleDb.OleDbParameter("@StudentNumber", txtStudentNumber.Text)
        Dim parFirstname As New OleDb.OleDbParameter("@Firstname", txtFirstname.Text)
        Dim parSurname As New OleDb.OleDbParameter("@Surname", txtSurname.Text)
        Dim parMobileNumber As New OleDb.OleDbParameter("@MobileNumber", txtMobileNumber.Text)
        Dim parEmail As New OleDb.OleDbParameter("@Email", txtEmail.Text)
        '8. Add the parameter to the Command object
        cmdCommand.Parameters.Add(parStudentNumber)
        cmdCommand.Parameters.Add(parFirstname)
        cmdCommand.Parameters.Add(parSurname)
        cmdCommand.Parameters.Add(parMobileNumber)
        cmdCommand.Parameters.Add(parEmail)
        '9 Perform the ExecuteNoQuery method on the cmdCommand object
        cmdCommand.ExecuteNonQuery()
        '10. Close conConnection object
        conConnection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '1. Declare the Connection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Declare the Command object
        Dim cmdCommand As New OleDb.OleDbCommand
        '3. Assign the path to the connection property of the conConnectionString object
        conConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\L4\CPR\1.StudentRegistration\StudentDatabase.mdb"
        '4. Open the Connection object
        conConnection.Open()
        '5. Assign the conConnection object to the Connection property of the Command object
        cmdCommand.Connection = conConnection
        '6 Assign the SQL statement to to the CommandText property of the Command object
        cmdCommand.CommandText = "DELETE FROM StudentDetails WHERE StudentNumber=@StudentNumber"
        'Declare a parameter
        Dim parStudentNumber As New OleDb.OleDbParameter("@StudentNumber", txtStudentNumber.Text)

        '8. Add the parameter to the Command object
        cmdCommand.Parameters.Add(parStudentNumber)

        '9 Perform the ExecuteNoQuery method on the cmdCommand object
        cmdCommand.ExecuteNonQuery()
        '10. Close conConnection object
        conConnection.Close()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '1. Declare the Connection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Declare the Command object
        Dim cmdCommand As New OleDb.OleDbCommand
        '3. Assign the path to the connection property of the conConnectionString object
        conConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\L4\CPR\1.StudentRegistration\StudentDatabase.mdb"
        '4. Open the Connection object
        conConnection.Open()
        '5. Assign the conConnection object to the Connection property of the Command object
        cmdCommand.Connection = conConnection
        '6. Assign the SQL statement to to the CommandText property of the Command object
        cmdCommand.CommandText = "SELECT * FROM StudentDetails "
        '7. Declare a table object
        Dim tblTable As New DataTable

        '8. Perform the cmdCommand(Execute.Reader()) on the tblTable.load
        tblTable.load(cmdCommand.ExecuteReader())

        '9. Assign the table object to the datasource property of the datagrid view.
        dgvStudent.DataSource = tblTable

        '10. Close conConnection object
        conConnection.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
