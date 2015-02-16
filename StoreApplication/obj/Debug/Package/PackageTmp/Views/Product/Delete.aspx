<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StoreApplication.Models.Product>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
    <legend>Delete Product</legend>

    <div class="display-field">
        <h1><%: Html.DisplayFor(model => model.Name) %></h1>
    </div>

    <div class="display-field">
        <%: Html.DisplayFor(model => model.Description) %>
    </div>

    <div class="display-field">
        <h3>$<%: Html.DisplayFor(model => model.Price) %></h3>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <div class="form-button">
        <button type="submit" value="Delete" class="btn btn-danger">Delete</button>
    </div>
    <p>
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
