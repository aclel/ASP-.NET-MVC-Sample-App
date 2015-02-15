<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StoreApplication.Models.Product>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
    <legend>Product Details</legend>

    <div class="well product-container">
        <div class="display-field">
            <h1>
                <%: Html.DisplayFor(model => model.Name) %>
            </h1>
        </div>

        <div class="display-field">
            <%: Html.DisplayFor(model => model.Description) %>
        </div>

        <div class="display-field">
            <h4>
                $<%: Html.DisplayFor(model => model.Price) %>
            </h4>
        </div>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
