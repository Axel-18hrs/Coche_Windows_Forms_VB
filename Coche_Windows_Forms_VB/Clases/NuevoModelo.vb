Namespace Coche_Windows_Forms_VB.Clases
    ' clase hija o derivada
    Public Class NuevoModelo
        Inherits Auto

        ' los atributos o variables globales son las caracteristicas que definen a una clase o objeto
        Private _color As String

        Public Property Color As String
            Get
                Return Color
            End Get
            Set(value As String)
                _color = value
            End Set
        End Property

        ' aqui se usa el polimorfismo y la base de un metodo de la clase superior o clase padre
        Public Overrides Function ToString() As String
            If Color IsNot "Negro" Then
                MessageBox.Show("Este auto se vera increible!")
            End If

        End Function

        ' aqui se usa el polimorfismo y la base de un metodo de la clase superior o clase padre
        Public Overrides Function Chocar() As String
            If Color = "Negro" Then
                MessageBox.Show("Ese color se ve muy inseguro. ¿Sabias que el color mas propenso a choques y accidentes es el negro?", "???", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Function

    End Class
End Namespace
