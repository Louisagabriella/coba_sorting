Public Class Form1

    Dim data As New ArrayList()
    Dim amtk As New ArrayList()
    Dim abind As New ArrayList()
    Dim anama As New ArrayList()
    Dim anis As New ArrayList()

    Private Sub hasil_Click(sender As Object, e As EventArgs) Handles hasil.Click
        Dim angka(1) As Integer
        data.Insert(0, nama.Text)
        data.Insert(1, nis.Text)
        data.Insert(2, mat.Text)
        data.Insert(3, bind.Text)

        DataGridView1.Rows.Add(data(0), data(1), data(2), data(3))

        

        amtk.Add(mat.Text)
        abind.Add(bind.Text)
        anama.Add(nama.Text)
        anis.Add(nis.Text)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim indexMin, i, j, itemp As Integer
        Dim temp As String

        For i = 0 To amtk.Count - 1
            indexMin = i
            For j = i + 1 To amtk.Count - 1
                If amtk(j) > amtk(indexMin) Then
                    indexMin = j
                End If
            Next
            itemp = amtk(i)
            amtk(i) = amtk(indexMin)
            amtk(indexMin) = itemp

            itemp = abind(i)
            abind(i) = abind(indexMin)
            abind(indexMin) = itemp

            temp = anama(i)
            anama(i) = anama(indexMin)
            anama(indexMin) = temp

            temp = anis(i)
            anis(i) = anis(indexMin)
            anis(indexMin) = temp
        Next
        DataGridView1.Rows.Clear()
        For i = 0 To amtk.Count - 1
            DataGridView1.Rows.Add(anama(i), anis(i), amtk(i), abind(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim indexMin, i, j, itemp As Integer
        Dim temp As String

        For i = 0 To abind.Count - 1
            indexMin = i
            For j = i + 1 To abind.Count - 1
                If abind(j) > abind(indexMin) Then
                    indexMin = j
                End If
            Next
            itemp = amtk(i)
            amtk(i) = amtk(indexMin)
            amtk(indexMin) = itemp

            itemp = abind(i)
            abind(i) = abind(indexMin)
            abind(indexMin) = itemp

            temp = anama(i)
            anama(i) = anama(indexMin)
            anama(i) = temp

            temp = anis(i)
            anis(i) = anis(indexMin)
            anis(i) = temp
        Next
        DataGridView1.Rows.Clear()
        For i = 0 To abind.Count - 1
            DataGridView1.Rows.Add(anama(i), anis(i), amtk(i), abind(i))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim indexMin, i, j, itemp As Integer
        Dim temp As String

        For i = 0 To amtk.Count - 1
            indexMin = i
            For j = i + 1 To amtk.Count - 1
                If amtk(j) < amtk(indexMin) Then
                    indexMin = j
                End If
            Next
            itemp = amtk(i)
            amtk(i) = amtk(indexMin)
            amtk(indexMin) = itemp

            itemp = abind(i)
            abind(i) = abind(indexMin)
            abind(indexMin) = itemp

            temp = anama(i)
            anama(i) = anama(indexMin)
            anama(indexMin) = temp

            temp = anis(i)
            anis(i) = anis(indexMin)
            anis(indexMin) = temp
        Next
        DataGridView1.Rows.Clear()
        For i = 0 To amtk.Count - 1
            DataGridView1.Rows.Add(anama(i), anis(i), amtk(i), abind(i))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim indexMin, i, j, itemp As Integer
        Dim temp As String

        For i = 0 To abind.Count - 1
            indexMin = i
            For j = i + 1 To abind.Count - 1
                If abind(j) < abind(indexMin) Then
                    indexMin = j
                End If
            Next
            itemp = amtk(i)
            amtk(i) = amtk(indexMin)
            amtk(indexMin) = itemp

            itemp = abind(i)
            abind(i) = abind(indexMin)
            abind(indexMin) = itemp

            temp = anama(i)
            anama(i) = anama(indexMin)
            anama(i) = temp

            temp = anis(i)
            anis(i) = anis(indexMin)
            anis(i) = temp
        Next
        DataGridView1.Rows.Clear()
        For i = 0 To abind.Count - 1
            DataGridView1.Rows.Add(anama(i), anis(i), amtk(i), abind(i))
        Next
    End Sub
End Class
