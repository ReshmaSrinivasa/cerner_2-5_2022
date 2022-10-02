//cerner_2tothe5th_2022

Public Class Calculator
     Dim a As Integer
     Dim b As Integer
     Private Sub Add_Click(sender As Object, e As EventArgs) 
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a + b)
     End Sub
 
    Private Sub Sub_Click_1(sender As Object, e As EventArgs) 
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a - b)
    End Sub
 
    Private Sub Mul_Click(sender As Object, e As EventArgs) 
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a * b)
    End Sub
 
    Private Sub Div_Click(sender As Object, e As EventArgs) 
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a / b)
    End Sub
End Class