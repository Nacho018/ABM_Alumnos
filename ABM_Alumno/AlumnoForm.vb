Public Class AlumnoForm

    Dim operacion_ As String
    Dim MiAlumno As New Alumno


    Public Property operacion() As String
        Get
            Return operacion_


        End Get

        Set(ByVal value As String)

            operacion_ = value

        End Set



    End Property


    Dim indice_ As Byte

    Public Property indice() As String
        Get
            Return indice_

        End Get
        Set(ByVal value As String)
            indice_ = value

        End Set

    End Property






    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub
End Class