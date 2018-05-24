Imports System
Imports System.Collections.Generic
Imports Windows.UI.Xaml.Data

Public Class ViewModel
    Private data As ICollectionView
    Public ReadOnly Property Grid_Data() As ICollectionView
        Get
            If data Is Nothing Then
                Dim list As New List(Of TestData)()
                For i As Integer = 0 To 99
                    list.Add(New TestData() With {
                            .Number1 = i,
                            .Number2 = i * 10,
                            .Text1 = "row " & i,
                            .Text2 = "ROW " & i
                        })
                Next i
                data = New CollectionViewSource With {.Source = list}.View
            End If
            Return data
        End Get
    End Property
End Class
Public Class TestData
    Public Property Number1() As Integer
    Public Property Number2() As Integer
    Public Property Text1() As String
    Public Property Text2() As String
End Class

