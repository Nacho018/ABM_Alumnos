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

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click





        MiAlumno.nya = TextBox1.Text()


        MiAlumno.nacimiento = CDate(TextBox2.Text)

        MiAlumno.dni = CInt(TextBox3.Text)


        MiAlumno.mail = TextBox5.Text()


        TextBox5.Text = ""

        TextBox5.Focus()


        Select Case operacion_

            Case "Nuevo"

                lst.Add(MiAlumno)

            Case "Eliminar"


                lst.RemoveAt(indice_)

            Case "Modificar"

                lst.Item(indice_) = MiAlumno





                AlumnoGrid.DataGridView1.Refresh()

        End Select



        Me.Close()







    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress



        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then



            e.Handled = True


        End If





    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then



            e.Handled = True

            'Exit Sub
        End If

        Dim pos As Integer = TextBox3.SelectionStart



        If e.KeyChar = "." And pos <> 2 And pos <> 6 Then


            e.Handled = True


            Exit Sub
        End If


        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 6) Then


            e.Handled = True

            Exit Sub
        End If





    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" Then

            e.Handled = True

            Exit Sub

        End If


        Dim pos As Integer = TextBox2.SelectionStart




        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then

            e.Handled = True

            Exit Sub

        End If



        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then

            e.Handled = True

            Exit Sub

        End If

    End Sub

    

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus



        Dim dia As Integer = CInt(TextBox2.Text.Substring(0, 2))


        Dim mes As Integer = CInt(TextBox2.Text.Substring(3, 2))

        Dim año As Integer = CInt(TextBox2.Text.Substring(6, 4))
        'Si el año es menor a 1980 o año es mayor a 2018

        If año < 1980 Or año > 2018 Then



            MsgBox(" año no valido ")

            TextBox2.Focus()
            Exit Sub

        End If

        If mes < 1 Or mes > 12 Then

            MsgBox(" mes  no valido ")
            TextBox2.Focus()

            Exit Sub



        End If

        If dia < 1 Or dia > 31 Then

            MsgBox(" dia  no valido ")
            TextBox2.Focus()

            Exit Sub

        End If


        Select Case mes

            Case 1, 3, 5, 7, 8, 10, 12
                If dia < 1 Or dia > 31 Then

                    MsgBox(" Día no valido ")

                    TextBox1.Focus()

                    Exit Sub

                End If

            Case 4, 6, 9, 11

                If dia < 1 Or dia > 30 Then


                    MsgBox(" Día no valido ")

                    TextBox2.Focus()

                    Exit Sub
                End If


            Case 2

                If año Mod 4 = 0 Then

                    If dia < 1 Or dia > 28 Then

                        MsgBox(" Día no valido ")

                        TextBox2.Focus()

                        Exit Sub


                    End If

                Else
                    If dia < 1 Or dia > 29 Then


                        MsgBox(" Día no valido ")

                        TextBox2.Focus()
                    End If


                End If

        End Select

        'TextBox4.Text = MiAlumno.edad

        TextBox4.Text = DateDiff(DateInterval.Year, CDate(TextBox2.Text), Date.Now)







    End Sub


    Private Sub AlumnoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '06/05/1993

        'TextBox4.Text = Enabled = False

        TextBox4.ReadOnly = True


    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        'Aca se valida cada tecla que se va pulsando, si se aprueba
        'se pone el Handled en false si no se aprueba va en true.


        If Char.IsNumber(e.KeyChar) Then


            e.Handled = False
            Exit Sub
        End If


        Select Case e.KeyChar



            Case "a" To "z"
                'Habilita el ingreso de las tecla "a" a la "z"





            Case "."
                'Si la longitud del textbox es cero no permite el punto.
                If TextBox5.TextLength = 0 Then Exit Sub

                Dim correo, pto As String

                correo = TextBox5.Text
                'Obtengo la última tecla tipeada.
                pto = correo.Substring(correo.Length - 1, 1)

                'Si es un punto lo bloqueo.
                If pto = "." Then
                    e.Handled = True
                End If
            Case "@"
                'Solo puede haber una arroba.
                Dim correo, arro As String

                correo = TextBox5.Text
                'Obtengo la última tecla tipeada.
                arro = correo.Substring(correo.Length - 1, 1)

                'Si es una arroba lo bloqueo.
                If arro = "@" Then
                    e.Handled = True
                End If

            Case "_", "-"
                'Para el caso de guión bajo y guión medio.
                e.Handled = False

            Case Else
                'Si es una tecla de control se habilita.
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

        End Select
    End Sub



    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        Dim correo, cuenta, dominio As String
        Dim arroba, punto As Integer
        Dim ente(8) As String

        ente(0) = ".com"
        ente(1) = ".org"
        ente(2) = ".net"
        ente(3) = ".edu"
        ente(4) = ".gov"
        ente(5) = ".gob"
        ente(6) = ".mil"
        ente(7) = ".inf"
        ente(8) = ".tur"



        correo = TextBox5.Text

        arroba = correo.IndexOf("@")




        If arroba = -1 Then

            MsgBox("falta arroba")

            TextBox5.Focus()

            Exit Sub
        End If
        'Recupero la cadena hasta el lugar antes de la arroba.
        'La variable arroba tiene la posición de la arroba.
        cuenta = correo.Substring(0, arroba)
        dominio = correo.Substring(arroba + 1)

        'Busco el punto en el dominio.
        punto = dominio.IndexOf(".")

        If punto = -1 Then
            TextBox5.Focus()
            MsgBox("Falta el punto en el dominio.")
            Exit Sub
        End If



        Dim ult, pri As String

        'Obtengo el último caracter de la cadena correo.
        pri = correo.Substring(0, 1)
        'Obtengo el último caracter de la cadena correo.
        ult = correo.Substring(correo.Length - 1)

        If pri = "@" Then
            MsgBox("No puede comenzar con arroba.")
            TextBox5.Focus()
            Exit Sub
        End If

        If ult = "@" Then
            MsgBox("No puede terminar con arroba.")
            TextBox5.Focus()
            Exit Sub
        End If
        If pri = "." Then
            MsgBox("No puede comenzar con punto.")
            TextBox5.Focus()
            Exit Sub
        End If

        If ult = "." Then
            MsgBox("No puede terminar con punto.")
            TextBox5.Focus()
            Exit Sub
        End If


        Dim x, ext As Integer

        For x = 0 To 8
            'Busco cada extensión en el dominio.
            ext = dominio.IndexOf(ente(x))

            'Si encuentro la extensión en el dominio finalizo.
            If ext > 0 Then
                Exit For
            End If
        Next


        'Si ext es igual a -1 es porque no encontro ninguna de las extensiones.
        If ext = -1 Then
            MsgBox("falta terminacion o terminacion inválida")
            TextBox5.Focus()
            Exit Sub
        End If
        MsgBox("Validación de correo correcta.")
       
    End Sub

    'Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    TextBox5.Text = ""
    '    TextBox5.Focus()
    'End Sub
End Class




