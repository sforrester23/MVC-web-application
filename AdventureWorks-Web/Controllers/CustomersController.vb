Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class CustomersController
        'a microsoft class that you must inherit from for our controllers
        Inherits Controller

        ' Get: customers
        Function CustomerList() As ActionResult
            Dim vm As New CustomerViewModel

            'Server.MapPath() returns the physical directory where your web application is running from
            vm.LoadCustomers(Server.MapPath("/"))

            Return View(vm)
        End Function

        Function CustomerDetail(ByVal id As Integer) As ActionResult
            Dim vm As New CustomerViewModel

            vm.LoadCustomer(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace