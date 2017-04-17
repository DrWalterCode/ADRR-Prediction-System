Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmDatabaseSetup
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim computerName As String
    Dim exists As Integer

    Dim _
        cAppConfig As Configuration =
            ConfigurationManager.OpenExeConfiguration(Application.StartupPath & "\ADRR Prediction System.exe")

    Dim asSettings As AppSettingsSection = cAppConfig.AppSettings

    Private Sub Showdatabases()
        Try
            Dim strConn As String

            strConn = "Server ='" + txthost.Text + "'; port='" + txtport.Text + "'; userid = '" + txtuser.Text +
                      "'; password = '" + txtpassword.Text +
                      "';"
            strConn &= "Database = mysql; pooling=false;"

            conn = New MySqlConnection(strConn)

            cmd = New MySqlCommand("Show Databases", conn)

            conn.Open()

            dr = cmd.ExecuteReader
            cbodatabase.Properties.Items.Clear()
            If dr.HasRows Then
                Do While dr.Read
                    cbodatabase.Properties.Items.Add(dr.Item("Database").ToString)
                Loop
            End If

            dr.Close()

        Catch ex As MySqlException
            'MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txthost_TextChanged(sender As Object, e As EventArgs) Handles txthost.TextChanged
        if txtuser.Text = "" or txthost.Text = "" Then
        Else
            Showdatabases()
        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        if txtuser.Text = "" or txthost.Text = "" Then
        Else
            Showdatabases()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        if txtuser.Text = "" or txthost.Text = "" or txtpassword.Text = "" Then
        Else
            Showdatabases()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        if txtuser.Text = "" or txthost.Text = "" or txtport.Text = "" or cbodatabase.Text = "" Then
            MsgBox("Please ensure no field is empty before saving!!", vbInformation, "Caution")
            Exit Sub
        End If

        Try
            Dim strConn As String
            strConn = "Server ='" + txthost.Text + "';port='" + txtport.Text + "'; userid = '" + txtuser.Text +
                      "'; password = '" + txtpassword.Text +
                      "'; Database = '" + cbodatabase.Text + "'"

            conn = New MySqlConnection(strConn)

            conn.Close()
            conn.Open()
            cmd =
                New MySqlCommand("select count(*) from database_connection where computer_name='" & computerName & "' ",
                                 conn)
            Dim oJobName as object = cmd.ExecuteScalar()

            If oJobName Is Nothing Then
                Insertdata
                clear()
                Exit Sub
            Else
                exists = CInt(oJobName.ToString)
            End If
            cmd.Dispose()
            conn.Close()
            if exists = 0
                Insertdata
            Else
                Updatedata
            End If

            clear()
            Dispose()
        Catch ex As Exception
            cmd.Dispose()
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private sub Clear
        txtuser.Text = ""
        txthost.Text = ""
        txtpassword.Text = ""
        cbodatabase.Properties.Items.Clear()
    End sub

    Public Function GetComputerName() As String
        computerName = Net.Dns.GetHostName
        Return computerName
    End Function

    Private Sub FrmDatabaseSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetComputerName()
    End Sub

    Private sub Insertdata

        dim newvalue as String = "server=" + txthost.Text + ";database=" + cbodatabase.Text + ";uid=" + txtuser.Text +
                                 ";password=" + txtpassword.Text + ";port=" + txtport.Text +";Allow User Variables=True"
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)
        connectionStringsSection.ConnectionStrings("myConnection").ConnectionString = newvalue
        config.Save()
        ConfigurationManager.RefreshSection("connectionStrings")

        dim newvalueR as String = "XpoProvider=MySql; " + "server=" + txthost.Text + ";port=" + txtport.Text + ";uid=" +
                                  txtuser.Text + ";password=" + txtpassword.Text + " ;database=" + cbodatabase.Text +
                                  ";Allow User Variables=True;persist security info=true;CharSet=utf8;"
        connectionStringsSection.ConnectionStrings("localhost_adrrsystem_Connection").ConnectionString = newvalueR
        config.Save()
        ConfigurationManager.RefreshSection("connectionStrings")

        conn.Close()
        conn.Open()
        cmd =
            New MySqlCommand(
                "insert into database_connection(computer_name,host,user,password,connection_status) values ('" +
                computerName +
                "','" + txthost.Text + "','" + txtuser.Text + "','" + txtpassword.Text + "','Active') ", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Database connection details saved")
        cmd.Dispose()
        conn.Close()
    End sub

    Private sub Updatedata
        dim newvalue as String = "server=" + txthost.Text + ";database=" + cbodatabase.Text + ";uid=" + txtuser.Text +
                                 ";password=" + txtpassword.Text + ";port=" + txtport.Text +";Allow User Variables=True"
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)
        connectionStringsSection.ConnectionStrings("myConnection").ConnectionString = newvalue
        config.Save()
        ConfigurationManager.RefreshSection("connectionStrings")

        dim newvalueR as String = "XpoProvider=MySql; " + "server=" + txthost.Text + ";port=" + txtport.Text + ";uid=" +
                                  txtuser.Text + ";password=" + txtpassword.Text + " ;database=" + cbodatabase.Text +
                                  ";Allow User Variables=True;persist security info=true;CharSet=utf8;"
        connectionStringsSection.ConnectionStrings("localhost_adrrsystem_Connection").ConnectionString = newvalueR
        config.Save()
        ConfigurationManager.RefreshSection("connectionStrings")

        conn.Close()
        conn.Open()
        cmd =
            New MySqlCommand(
                "update database_connection set host='" + txthost.Text + "',user='" + txtuser.Text +
                "',password= '" + txtpassword.Text + "' where computer_name='" + computerName + "' ", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Database connection details updated")
        cmd.Dispose()
        conn.Close()
    End sub
End Class