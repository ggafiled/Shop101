Imports System.Reflection
Imports System.Text
Imports ApartmentUpdate

Public Class MngLogin : Implements IApartmentUpdate
    Dim _frmmain As MainActivity
    Dim _frmwaiting As Darwaiting
    Dim dtlogin As New DataTable

    Public ReadOnly Property Applicationname As String Implements IApartmentUpdate.Applicationname
        Get
            Return "Apartment.com"
        End Get
    End Property

    Public ReadOnly Property ApplicationID As String Implements IApartmentUpdate.ApplicationID
        Get
            Return "Apartment.com"
        End Get
    End Property

    Public ReadOnly Property ApplicationAssemby As Assembly Implements IApartmentUpdate.ApplicationAssemby
        Get
            Return Assembly.GetExecutingAssembly
        End Get
    End Property

    Public ReadOnly Property ApplicationIcon As Icon Implements IApartmentUpdate.ApplicationIcon
        Get
            Return Me.Icon
        End Get
    End Property

    Public ReadOnly Property XmlFileLocation As Uri Implements IApartmentUpdate.XmlFileLocation
        Get
            Return New Uri("https://github.com/ggafiled/tryz/blob/master/update.xml")
        End Get
    End Property

    Public ReadOnly Property Context As Form Implements IApartmentUpdate.Context
        Get
            Return Me
        End Get
    End Property

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
            dtlogin = QueryReturnDatatable("SELECT * FROM userauthen WHERE user_name = " + "'" + txtUser.text + "'" + " and user_password =" + "'" + txtPwd.text + "'")
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
            My.Settings.Grant = dtlogin(0)(2).ToString
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
        txtUser.text = ""
        txtPwd.text = ""
        txtUser.Focus()
        txtPwd._TextBox.PasswordChar = "*"
        txtUser._TextBox.Multiline = False
        txtPwd._TextBox.Multiline = False
    End Sub
End Class