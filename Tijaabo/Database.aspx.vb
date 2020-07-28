Imports System.Data.SqlClient
Public Class Database
    Inherits System.Web.UI.Page
    Dim str As String = ("server=Jama; database=FinalProject; integrated security=true;")
    Dim cn As New SqlConnection(str)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet


    'Sub readData()
    '    cmd.Connection = cn
    '    cmd.CommandText = "select Id,Cust_Distruct from Customer"
    '    cn.Open()
    '    dr = cmd.ExecuteReader()
    '    While dr.Read = True
    '        DropDownList1.Items.Add(dr("Cust_Distruct"))
    '    End While
    '    dr.Close()
    '    cn.Close()

    'End Sub
    Sub fillData()
        cmd.Connection = cn
        cmd.CommandText = "select *from Customer"
        cn.Open()
        dr = cmd.ExecuteReader
        GridView1.DataSource = dr
        GridView1.DataBind()
        cn.Close()


    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'readData()
        fillData()

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim row As GridViewRow = GridView1.SelectedRow
        txt_Id.Text = row.Cells(1).Text
        txt_Name.Text = row.Cells(2).Text
        txt_Gender.Text = row.Cells(3).Text
        txt_Tell.Text = row.Cells(4).Text
        DropDownList1.SelectedItem.Text = row.Cells(5).Text
    End Sub
    Protected Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        cmd.Parameters.Clear()

        cmd.Connection = cn
        cmd.CommandText = "INSERT into Customer values (@Id,@Cust_Name,@Cust_Gender,@Cust_Tell,@Cust_Distruct)"
        cmd.Parameters.AddWithValue("@Id", txt_Id.Text)
        cmd.Parameters.AddWithValue("@Cust_Name", txt_Name.Text)
        cmd.Parameters.AddWithValue("@Cust_Gender", txt_Gender.Text)
        cmd.Parameters.AddWithValue("@Cust_Tell", txt_Tell.Text)
        cmd.Parameters.AddWithValue("@Cust_Distruct", DropDownList1.SelectedItem.Text)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Recore inserted Succesfully !", MsgBoxStyle.Information)
            fillData()
            clean()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clean()
        txt_Id.Text = ""
        txt_Name.Text = ""
        txt_Gender.Text = ""
        txt_Tell.Text = ""
        'DropDownList1.SelectedItem.Text = ""
    End Sub

    Protected Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        cmd.Parameters.Clear()

        cmd.Connection = cn
        cmd.CommandText = "UPDATE Customer set Cust_Name=@Cust_Name,Cust_Gender=@Cust_Gender, Cust_Tell=@Cust_Tell,Cust_Distruct=@Cust_Distruct WHERE Id=@Id"
        cmd.Parameters.AddWithValue("@Id", txt_Id.Text)
        cmd.Parameters.AddWithValue("@Cust_Name", txt_Name.Text)
        cmd.Parameters.AddWithValue("Cust_Gender", txt_Gender.Text)
        cmd.Parameters.AddWithValue("@Cust_Tell", txt_Tell.Text)
        cmd.Parameters.AddWithValue("@Cust_Distruct", DropDownList1.SelectedItem.Text)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Records updated successfully !", MsgBoxStyle.Information)
            fillData()
            clean()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        cmd.Parameters.Clear()
        cmd.Connection = cn
        cmd.CommandText = "DELETE Customer WHERE Id=@Id"
        cmd.Parameters.AddWithValue("@Id", txt_Id.Text)
        Try
            Dim answer = MsgBox("Are you sure to delet this record", MsgBoxStyle.OkCancel)
            If answer = MsgBoxResult.Cancel Then
                Return
            End If
            cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
            MsgBox("Record has been Deleted!", MsgBoxStyle.Exclamation)
            fillData()

            clean()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub

    Protected Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        clean()

    End Sub
End Class