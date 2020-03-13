Imports MySql.Data.MySqlClient
Module useFunctional

    Private da As MySqlDataAdapter
    Private dt As DataTable
    Private dr As MySqlDataReader
    Public cmd As MySqlCommand
    Private conn As MySqlConnection

    Public Function tanfomdate(ByRef point As Integer) As String
        Dim list As Array = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฏาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}
        Return list.GetValue(point - 1).ToString
    End Function

    Public Function getconnecttion() As String
        Return ConvertCommand("aG9zdD1sb2NhbGhvc3Q7dXNlcj1yb290O3Bhc3N3b3JkPScnO2RhdGFiYXNlPWRiX3dvcmtzaG9wXzEwMTtjaGFyc2V0PXV0Zjg=")
    End Function

    Public Function QueryReturnDatatableOverride(ByRef sql As String) As DataTable
        Call Isconnection()
        cmd = New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = conn
        da = New MySqlDataAdapter
        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)
        Return dt
        dt.Clear()
        Call Closeconnection()
    End Function

    Public Function QueryReturnDatatable(ByRef sql As String)
        Call Isconnection()
        cmd = New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = conn
        da = New MySqlDataAdapter
        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)
        Return dt
        dt.Clear()
        Call Closeconnection()
    End Function

    Public Function QueryReturnDatatable(ByRef cmd As MySqlCommand)
        Call Isconnection()
        cmd.Connection = conn
        da = New MySqlDataAdapter
        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)
        Return dt
        dt.Clear()
        Call Closeconnection()
    End Function

    Public Sub QueryNonReturn(ByRef sql As String)
        Call Isconnection()
        cmd = New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        Call Closeconnection()
    End Sub

    Public Sub QueryNonReturn(ByRef sql As MySqlCommand)
        Call Isconnection()
        cmd = sql
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        Call Closeconnection()
    End Sub


    Public Function QueryGetID(ByRef sql As String, ByRef code As String)
        Dim genarator As String
        Dim id As Integer
        Dim maincode As String = code.ToUpper
        Call Isconnection()
        cmd = New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = conn
        da = New MySqlDataAdapter
        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            id = CInt(dt(0)(0).substring(3)) + 1
            genarator = maincode + id.ToString("00000000")
            Return genarator
        Else
            genarator = maincode + "00000001"
            Return genarator
        End If
        dt.Clear()
        Call Closeconnection()
    End Function

    Public Sub Isconnection()
        conn = New MySqlConnection(getconnecttion)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub Closeconnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function ConvertCommand(ByRef cmd As String) As String
        Dim b As Byte() = Convert.FromBase64String(cmd)
        Dim strOriginal = System.Text.Encoding.UTF8.GetString(b)
        Return strOriginal
    End Function

    Public Class CustomTool
        Inherits ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
            If Not e.Item.Selected Then
                MyBase.OnRenderButtonBackground(e)
            Else
                Dim rectangle As New Rectangle(0, 0, e.Item.Width, e.Item.Height)
                Dim brush As Brush = New Drawing.SolidBrush(Color.FromArgb(192, 192, 192))
                e.Graphics.FillRectangle(brush, rectangle)
            End If
        End Sub
    End Class

End Module
