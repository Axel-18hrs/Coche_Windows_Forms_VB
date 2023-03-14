Namespace Coche_Windows_Forms_VB.Clases
    ' Clase abstracta que no se puede instanciar directamente
    Public MustInherit Class Auto
        ' atibutos o variables globales desde los que se pueden acceder en otras clases derivadas

        Protected _marca As String
        Protected _modelo As String
        Protected _motor As String


        Public Property Marca As String
            Get
                Return _marca
            End Get
            Set(value As String)
                _marca = value
            End Set
        End Property

        Public Property Modelo As String
            Get
                Return _modelo
            End Get
            Set(value As String)
                _modelo = value
            End Set
        End Property

        Public Property Motor As String
            Get
                Return _motor
            End Get
            Set(value As String)
                _motor = value
            End Set
        End Property

        ' metodo abstracto que se implementara en todas las clases y que cada una de ellas se encargara de definirlo
        ' tambien es un ejemplo de polimorfismo al modificar o personalizar un metodo de la clase object
        Public MustOverride Function ToString() As String

        ' metodo abstracto que se implementara en todas las clases y que cada una de ellas se encargara de definirlo
        Public MustOverride Function Chocar() As String

    End Class
End Namespace