Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla1.ColumnCount = 8
        Tabla1.Rows.Add(1)
        Tabla2.ColumnCount = 8
        Tabla2.Rows.Add(1)
        For i = 0 To 7
            Tabla1.Columns(i).Width = 40
            Tabla2.Columns(i).Width = 40
        Next

    End Sub

    Private Sub cmdBoton_Click(sender As Object, e As EventArgs) Handles cmdBoton.Click
        Dim vector(8), pos As Integer
        For colu = 1 To 8
            vector(colu) = Tabla1.Item(colu - 1, 0).Value
        Next
        pos = 1
        For colum = 5 To 8
            Tabla2.Item(pos - 1, 0).Value = vector(colum)
            Tabla2.Item(colum - 1, 0).Value = vector(pos)
            pos += 1
        Next
    End Sub
End Class
