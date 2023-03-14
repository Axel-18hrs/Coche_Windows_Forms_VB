Imports System.Runtime.InteropServices
Imports Coche_Windows_Forms_VB.Coche_Windows_Forms_VB.Clases

Public Class Form1
    ' arreglo de coches o de mi objeto nuevomodelo que es una sub clase de la clase auto
    Private coches(999) As NuevoModelo
    Private nn As Integer
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        nn = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Eres un emprendedor que adquirio una fabrica de autos y tu deber ahora es proporcionar una lista de tus nuevos modelos de auto", "Contexto", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        ' IDENTIFICAMOS EL POSIBLE ERROR INICIAL O PRINCIPAL EN EL PROGRAMA
        If String.IsNullOrEmpty(txtMarca.Text) OrElse String.IsNullOrEmpty(txtModelo.Text) OrElse String.IsNullOrEmpty(cbMotor.Text) Then

            MessageBox.Show("Debes llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' hacemos uso de los arreglos de tipo object o arreglos de clases y pasamos los valores a sus propiedades
        coches(nn) = New NuevoModelo With
        {
            .Marca = txtMarca.Text,
            .Modelo = txtModelo.Text,
            .Motor = cbMotor.SelectedItem.ToString(),
            .Color = cbColor.SelectedItem.ToString()
        }

        ' mostramos la peticion recien efectuada o emitida por el usuario y la mostramos ademas de antes usar nuestros metodos 
        ' heredados y personalizados dentro de un contexto
        coches(nn).ToString()
        coches(nn).Chocar()
        dgvListaAutos.Rows.Add(coches(nn).Marca, coches(nn).Modelo, coches(nn).Motor, cbColor.SelectedItem.ToString())
        ' la variable "nn" se usa como indice del arreglo de tipos por lo que aumentamos su valor por 1
        ' y asi no sobreescribimos los daatos de la peticion
        nn += 1

        ' limpiando los combobox y textbox dentro del formulario por temas de estetica y comodidad
        txtMarca.Clear()
        txtModelo.Clear()
        cbColor.SelectedIndex = -1
        cbMotor.SelectedIndex = -1
    End Sub


End Class
