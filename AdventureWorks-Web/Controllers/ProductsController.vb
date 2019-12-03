Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class ProductsController
        'a microsoft class that you must inherit from for our controllers
        Inherits Controller

        ' Get: products
        Function ProductList() As ActionResult
            Dim vm As New ProductViewModel

            'Server.MapPath() returns the physical directory where your web application is running from
            vm.LoadProducts(Server.MapPath("/"))

            Return View(vm)
        End Function

        Function ProductDetail(ByVal id As Integer) As ActionResult
            Dim vm As New ProductViewModel

            vm.LoadProduct(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace