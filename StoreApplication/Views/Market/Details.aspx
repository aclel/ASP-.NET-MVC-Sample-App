<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StoreApplication.Models.Market>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
    <legend>
        <h1><%: Html.DisplayFor(model => model.Name) %></h1>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Description) %>
        </div>
    </legend>

    <div class="product-container">
        <div class="display-field">
            <h1></h1>
        </div>


    </div>

</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
