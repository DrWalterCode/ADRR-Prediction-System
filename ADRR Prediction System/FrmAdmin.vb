Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmAdmin
      Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
  
    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        TabControl1.SelectedIndex = 0
    End Sub

     Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from users ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "users")
            DataGridView1.DataSource = mydataset2.Tables("users").DefaultView
             DataGridView1.FirstDisplayedScrollingRowIndex=DataGridView1.RowCount-1
            DataGridView1.Rows(DataGridView1.RowCount-1).Selected=True
            DataGridView1.CurrentCell=DataGridView1.Rows(DataGridView1.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
         If txtUsername.Text = "" Or txtPassword.Text = "" Or TextBox1.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If

        if txtUsername.Enabled=True
             Try
           _con.Open()
            _cmd = New mysqlCommand("INSERT into users(usergroup,UserName,Password,Email,Surname,Forename,Phone) values ('" & txtgroup.Text & "','" & txtUsername.Text & "', '" & txtPassword.Text & "','" + Email_addressTextBox.Text.ToLower + "', '" & txtsurname.Text.ToString.Replace("'", "''") & "', '" & txtforename.Text.ToString.Replace("'", "''") & "', '" & txtphonenumber.Text & "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MsgBox("User Details Saved")
            loadgrid()
            TabPane2.SelectedPageIndex = 1
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error")
        End Try
            Else 
           Try
            _con.Open()
            _cmd = New mysqlcommand("update users set usergroup='" + txtgroup.Text + "', Email='" + Email_addressTextBox.Text + "',Surname='" + txtsurname.Text + "',Forename='" + txtforename.Text + "',Phone='" + txtphonenumber.Text + "',password='" + txtPassword.Text + "' where UserName='" + txtUsername.Text + "' ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show("Record Updated")
                txtUsername.Enabled=True
                 SimpleButton6.Enabled = False
           loadgrid()
                 TabPane2.SelectedPageIndex = 1
        Catch ex As Exception
             _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End If
       

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtgroup.Text = dr.Cells(1).Value.ToString
       txtUsername.Text = dr.Cells(2).Value.ToString
       txtPassword.Text = dr.Cells(3).Value.ToString
        TextBox1.Text= dr.Cells(3).Value.ToString
       Email_addressTextBox.Text = dr.Cells(4).Value.ToString
       txtforename.Text = dr.Cells(6).Value.ToString
       txtsurname.Text = dr.Cells(5).Value.ToString
       txtphonenumber.Text = dr.Cells(7).Value.ToString
       txtUsername.Enabled = False
       SimpleButton7.Enabled = True
      TabPane2.SelectedPageIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) 
         TabControl1.SelectedIndex = 0
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        MsgBox("Under Development")
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) 
          MsgBox("Under Development")
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
          MsgBox("Under Development")
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
          MsgBox("Under Development")
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Dispose()
    End Sub
End Class
