Imports System.ComponentModel
Imports System.Reflection
Imports System.Xml
Imports ApartmentUpdate
Public Class MngLogin
    Dim _frmmain As MainActivity
    Dim _frmwaiting As Darwaiting
    Dim dtlogin As New DataTable

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgExit.Click
        Application.Exit()
    End Sub
    Private Sub MngLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles imgExit.MouseHover
        imgExit.Image = My.Resources.remove
    End Sub

    Private Sub imgExit_MouseLeave(sender As Object, e As EventArgs) Handles imgExit.MouseLeave
        imgExit.Image = My.Resources.remove_symbol
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        _frmwaiting = New Darwaiting
        _frmwaiting.Show()
        bgworker.RunWorkerAsync()
    End Sub
    Private Sub bgworker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgworker.DoWork
        _frmmain = New MainActivity
        Try
            Call Isconnection()
        Catch ex As Exception
            MessageBox.Show("can't connect database.")
            bgworker.ReportProgress(99)
        End Try
        Try
            dtlogin = QueryReturnDatatable("SELECT * FROM tbl_userauthen WHERE user_name = " + "'" + txtUser.text + "'" + " and user_password =" + "'" + txtPwd.text + "'")
            If dtlogin.Rows.Count > 0 Then
                bgworker.ReportProgress(10)
            Else
                bgworker.ReportProgress(20)
            End If
        Catch ex As Exception
            MessageBox.Show("error login!" + ex.Message)
        End Try
    End Sub
    Private Sub bgworker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworker.ProgressChanged
        If e.ProgressPercentage = 10 Then
            My.Settings.Username = dtlogin(0)(0).ToString
            dtlogin.Clear()
            Me.Hide()
            _frmwaiting.Dispose()
            _frmmain.Show()
        Else
            _frmwaiting.Dispose()
            MngLogin_Load(sender, e)

        End If
        If e.ProgressPercentage = 99 Then
            Application.Exit()
        End If
    End Sub

    Private Sub MngLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNewVersion.Text = My.Application.Info.Version.ToString
        txtUser.text = ""
        txtPwd.text = ""
        txtUser.Focus()
        txtPwd._TextBox.PasswordChar = "*"
        txtUser._TextBox.Multiline = False
        txtPwd._TextBox.Multiline = False
        'check = New ApartmentUpdater(Me)
        'check.DoUpdate(url)
    End Sub
End Class