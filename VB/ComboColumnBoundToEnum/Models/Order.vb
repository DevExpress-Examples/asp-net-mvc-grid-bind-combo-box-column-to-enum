Imports ComboColumnBoundToEnum.OrderHelper

Public Class Order
    Public Property ID As Integer
    Public Property Status As OrderStatus
End Class

Public Class OrderHelper
    Public Enum OrderStatus
        Unprocessed = 1
        Started
        Sent
        Finished
    End Enum

    Public Shared Function GetOrders() As List(Of Order)
        Dim orders As List(Of Order) = New List(Of Order)()

        For i As Integer = 1 To [Enum].GetNames(GetType(OrderStatus)).Length
            orders.Add(New Order With {
                .ID = i,
                .Status = CType(i, OrderStatus)
            })
        Next

        Return orders
    End Function
End Class
