Public Class AlumnoGrid

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click

        AlumnoForm.operacion = "Nuevo"
        AlumnoForm.Text = "Alta de alumno"


        AlumnoForm.Show()



    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click



        AlumnoForm.operacion = "Modificar"

        AlumnoForm.Text = "Modifica alumno"

        AlumnoForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        AlumnoForm.Show()



    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        AlumnoForm.operacion = "Eliminar"

        AlumnoForm.Text = "Elimina alumno"

        AlumnoForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        AlumnoForm.Show()

    End Sub

    Private Sub LlenarForm()

        AlumnoForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString

        AlumnoForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AlumnoForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AlumnoForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

    End Sub



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AlumnoGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst


    End Sub
End Class