Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmMain
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Dim menuchosen as String
     Dim logintime As String
     Dim logindate As String
     Public username As String
    Public realcoID as String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            _con.Open()
            Dim logoutdate As String = "LOGGED IN"
            Dim logout As String = "LOGGED IN"
            logintime= Now.ToLongTimeString
           logindate = Now.Date.ToString("dd/MM/yyyy")
            timeIn.Text = logintime
            dateIn.Text = logindate
            _cmd =
                New MySqlCommand(
                    "INSERT into LogTransactions(loginDate,loginTime,logoutDate,logoutTime,username) values ('" +
                    logindate + "','" + logintime + "','" + logoutdate + "','" + logout + "','" + lblUsername.Text +
                    "') ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            'MsgBox(ex.Message)
        End Try

        Timer2.Start()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
       FrmNurses.ShowDialog()
    End Sub

     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DigitalGauge1.Text=Now.ToShortTimeString()
    End Sub

    
     Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        
            _cmd.Dispose()
        _con.Close()
        Try
            _con.Open()
           Dim logout As String = Now.ToLongTimeString
            Dim logoutdate As String = Now.Date.ToString("dd/MM/yyyy")
           _cmd =
                New mySQLCommand(
                    "UPDATE LogTransactions set logoutDate='" + logoutdate + "',logoutTime='" + logout + "' where username='" + username +
                    "' and loginDate='" + logindate + "' and loginTime='"+ logintime +"'", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
       FrmLogin.Show()
         
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        Frmdoctors.ShowDialog()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) 
      
    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem7.ItemClick
        FrmReports.ShowDialog()
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) 
         MsgBox("Under Development")
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
       MsgBox("Under Development")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

   Private Sub TileItem8_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem8.ItemClick
        FrmAdmin.ShowDialog()
    End Sub
End Class
