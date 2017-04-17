'repository git changes
Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Dim _con As MySqlConnection
    Dim _cmd As MySqlCommand
    Dim _timercount As Integer = 60 'The number of seconds 
    Private sub checkconnection
        Try
            Dim connectionString = ConfigurationManager.ConnectionStrings("myConnection").ConnectionString
            _con = New mySqlConnection(connectionString)
            _con.Open()
        Catch ex As Exception
            MsgBox("Failed to establish connection")
            FrmDatabaseSetup.ShowDialog()
        End Try
    End sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkconnection()
        txtusername.Select()
    End Sub
    Private Sub CreateData()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label7.Text = _timercount.ToString() 'show the countdown in the label
        If _timercount = 0 Then 'Check to see if it has reached 0, if yes then stop timer and display done
            Timer1.Enabled = False
            Label7.Text = "Done"
        Else 'If timercount is higher then 0 then subtract one from it
            _timercount -= 1
        End If
    End Sub

    Private Sub Login()
        Try
            Dim connectionString = ConfigurationManager.ConnectionStrings("myConnection").ConnectionString
            _con = New mySqlConnection(connectionString)
            _con.Open()
            _cmd =
                New MySqlCommand(
                    "Select * from users where username like '%" + txtusername.Text + "%' and Password = '" + txtpwd.Text + "'",
                    _con)
            Dim reader = _cmd.ExecuteReader()
            if reader.Read() = True
                _cmd.Dispose()
                _con.Close()
                lblerror.Visible = True
                lblerror.Text = "Login Successful"
                ProgressPanel1.Visible = True
                Timer2.Interval = 1000
                Timer2.Start()
            Else
                lblerror.Visible = True
                lblerror.Text = "Login Details not yet verified !! "
            End If
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '_cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
        _cmd.Dispose()
        _con.Close()
    End Sub

    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtpwd.TextChanged
        Login()
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _con.Close()
    End Sub

    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim ans as string
            ans = MsgBox("Are you sure you want to Exit System?", vbYesNo + vbQuestion, "Caution")
            if ans = vbYes then
                Dispose()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Label7_TextChanged(sender As Object, e As EventArgs) Handles Label7.TextChanged
        If Label7.Text = "58" Then
            Timer2.Stop()
            _timercount = 60
            ProgressPanel1.Visible = False
            FrmMain.lblUsername.Text = txtusername.Text
            Label7.Text = ""
            txtusername.Select()
            txtpwd.Text = ""
            txtusername.Text = ""
            lblerror.Visible = False
            FrmMain.ShowDialog()
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        FrmDatabaseSetup.ShowDialog()
    End Sub
End Class
