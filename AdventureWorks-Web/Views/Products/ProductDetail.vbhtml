@ModelType AdventureWorks.ViewModelLayer.ProductViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "ProductDetail"
End Code

<div class="row">
    <div class="col-sm-3">Product ID</div>
    <div class="col-sm-9">@Model.Entity.ProductID</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Name</div>
    <div class="col-sm-9">@Model.Entity.Name</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
    <div class="col-sm-9">@Model.Entity.ProductNumber</div>
</div>
<div class="row">
    <div class="col-sm-3">Colour</div>
    <div class="col-sm-9">@Model.Entity.Colour</div>
</div>
<div class="row">
    <div class="col-sm-3">Size</div>
    <div class="col-sm-9">@Model.Entity.Size</div>
</div>
<div class="row">
    <div class="col-sm-3">Weight</div>
    <div class="col-sm-9">@Model.Entity.Weight</div>
</div>
<div class="row">
    <div class="col-sm-3">Cost</div>
    <div class="col-sm-9">@Model.Entity.StandardCost</div>
</div>
<div class="row">
    <div class="col-sm-3">Price</div>
    <div class="col-sm-9">@Model.Entity.ListPrice</div>
</div>
<div class="row">
    <div class="col-sm-3">Sell Start Date</div>
    <div class="col-sm-9">@Model.Entity.SellStartDate</div>
</div>
<div class="row">
    <div class="col-sm-3">Sell End Date</div>
    <div class="col-sm-9">@Model.Entity.SellEndDate</div>
</div>