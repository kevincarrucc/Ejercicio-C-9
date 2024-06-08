Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim numero, suma, conteo, promedio As Integer
        numero = 1
        suma = 0
        conteo = 0
        Do Until numero = 0
            numero = InputBox("Cargar valores aleatorios")
            NumerosCargados.Items.Add(numero.ToString())
            suma = suma + numero
            conteo = conteo + 1
            If numero = 0 Then
                LblFin.Text = "se a ingresado el numero 0. Fin del ingreso de numeros"
                Exit Do
            End If
        Loop
        conteo = conteo - 1
        promedio = suma / conteo
        LblPromedio.Text = "El promedio de los numeros ingresados es = " & promedio
    End Sub
End Class
