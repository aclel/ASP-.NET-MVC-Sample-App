<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<StoreApplication.Models.Market>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<p>
    <%: Html.ActionLink("Create Market", "Create") %>
</p>

<% foreach (var item in Model) { %>
    <div class="well col-md-4 product-container">
        <h2><%: Html.DisplayFor(modelItem => item.Name) %></h2>
        <p><%: Html.DisplayFor(modelItem => item.Description) %></p>
        <%: Html.ActionLink("Edit", "Edit", new { id=item.Id }) %> |
        <%: Html.ActionLink("Details", "Details", new { id=item.Id }) %> |
        <%: Html.ActionLink("Delete", "Delete", new { id=item.Id }) %>
    </div>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
