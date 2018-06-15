

Imports System.ComponentModel

Public Class AlumnoCollection

    Inherits BindingList(Of Alumno)



    Protected Overrides Sub onAddingNew(ByVal e As AddingNewEventArgs)


        e.NewObject = New Alumno()


    End Sub





End Class
