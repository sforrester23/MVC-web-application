@ModelType AdventureWorks.ViewModelLayer.CustomerViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customers"
End Code

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Customer ID</th>
            <th>Company Name</th>
            <th>First Name</th>
            <th>Last Name</th>
        </tr>
    </thead>

    @For Each customer In Model.Customers

        '<!-- table body -->
        @<tbody>
            <tr>
                <!--td: table details-->
                <td>@customer.CustomerID</td>
                <td>@customer.CompanyName</td>
                <td>@customer.FirstName</td>
                <td>@Html.ActionLink(customer.LastName, "CustomerDetail", New With {.id = customer.CustomerID})</td>
            </tr>
        </tbody>

    Next
</table>