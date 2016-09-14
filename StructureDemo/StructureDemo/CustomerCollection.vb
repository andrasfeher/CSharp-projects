Public Class CustomerCollection
    Inherits Collections.CollectionBase

    'Add a customer to the collection
    Public Sub Add(ByVal newCustomer As Customer)
        Me.List.Add(newCustomer)
    End Sub

    'Remove a customer from the collection
    Public Sub Remove(ByVal oldCustomer As Customer)
        Me.List.Remove(oldCustomer)
    End Sub
End Class
