Imports System.Data.Odbc
Imports System.IO
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         'openport()
    End Sub
    Private Sub openport()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            ' BtnConnect.Text = "Connect"
        Else
            Try
                With SerialPort1
                    .PortName = Trim(Mid(TextBox1.Text, 1, 5))
                    .BaudRate = 9600
                    .Parity = IO.Ports.Parity.None
                    .DataBits = 8
                    .StopBits = Ports.StopBits.One
                    .Handshake = Ports.Handshake.None
                    .RtsEnable = True
                    .DtrEnable = True
                    .Open()
                    .WriteLine("AT+CNMI=1,2,0,0,0" & vbCrLf) 'send whatever data that it receives to serial port  
                End With
                L.Text = "connected"
                'BtnConnect.Text = "Disconnect"
            Catch ex As Exception
                'BtnConnect.Text = "Connect"
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openport()
        try
              ' MsgBox(phone)
        With SerialPort1
            .WriteLine("AT" & vbCrLf)
            Threading.Thread.Sleep(1000)
            .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
            Threading.Thread.Sleep(1000)
            .WriteLine("AT+CMGS=""" & "+263773130145" & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
            Threading.Thread.Sleep(1000) 'thapeko
            .WriteLine("ADRR prediction system test message " & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
            'did you get my message?
        End With
       Catch ex As Exception
            MsgBox(ex.message)
       End Try
    End Sub
End Class