<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project4.CalcMortgage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Calculate Mortgage Monthly Payment</h2>
        </div>
        <p>
            Please enter the principle amount<asp:TextBox ID="PrincipleAmount" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Please enter the loan duration in years
            <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                <ContentTemplate>
                <asp:RadioButtonList ID="RadioButtonList1" AutoPostBack="true" runat="server">
                <asp:ListItem Value="15">15 Years</asp:ListItem>
                <asp:ListItem Value="30">30 Years</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="OtherYears" runat="server"></asp:TextBox>
                </ContentTemplate>    
            </asp:UpdatePanel>
        </p>
        <p>
            Please Select the interest rate<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>.25</asp:ListItem>
                <asp:ListItem>.50</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>1.25</asp:ListItem>
                <asp:ListItem>1.50</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>2.25</asp:ListItem>
                <asp:ListItem>2.50</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>3.25</asp:ListItem>
                <asp:ListItem>3.50</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>4.25</asp:ListItem>
                <asp:ListItem>4.50</asp:ListItem>
            </asp:DropDownList>
        
        <p>
            <asp:Button ID="ComputeMortgage" runat="server" OnClick="ComputeMortgage_Click" Text="Monthly Payment" />
        </p>
        <asp:Label ID="ResultPayment" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
