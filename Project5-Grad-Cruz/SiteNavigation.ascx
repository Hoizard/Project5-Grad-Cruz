<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteNavigation.ascx.cs" Inherits="Project3.SiteNavigation" %>
<h1>Mortgage Calculator</h1>
<hr />
<asp:Menu ID="Menu1" Orientation="Vertical" runat="server">
    <Items>
        <asp:MenuItem NavigateUrl="~/WebForm1.aspx" Text="Calc Mortgages" Value="CalcMortgages"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/ClearMortgages.aspx" Text="Clear Mortages" Value="ClearMortages"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/ListMortgages.aspx" Text="List Mortgages" Value="ListMortgages"></asp:MenuItem>
    </Items>
</asp:Menu>
<hr />
