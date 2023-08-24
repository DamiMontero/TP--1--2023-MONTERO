Imports System

Module Program
    Sub Main(args As String())
        Dim descripcion As String
        Dim unidadesProd As Integer
        Dim costoMateriales As Decimal
        Dim costoFijo As Double
        Dim costoTotal As Double

        ' Solicitar datos al usuario
        Console.WriteLine("Ingrese la descripción del artículo: ")
        descripcion = Console.ReadLine()

        Console.WriteLine("Ingrese el número de unidades producidas: ")
        unidadesProd = Convert.ToInt32(Console.ReadLine())

        ' Calcular el costo de los materiales
        costoMateriales = unidadesProd * 3.5

        ' Calcular el costo fijo
        costoFijo = 10700

        ' Calcular el costo total
        costoTotal = costoMateriales + costoFijo

        ' Imprimir los resultados
        Console.WriteLine("Descripción: {0}", descripcion)
        Console.WriteLine("Unidades producidas: {0}", unidadesProd)
        Console.WriteLine("Costo de los materiales: {0}", costoMateriales)
        Console.WriteLine("Costo fijo: {0}", costoFijo)
        Console.WriteLine("Costo total: {0}", costoTotal)
    End Sub
End Module
