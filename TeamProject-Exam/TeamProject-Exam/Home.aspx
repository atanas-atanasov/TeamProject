<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TeamProject_Exam.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Date" runat="server" />
            <br />
            <asp:TextBox runat="server" ID="dateText" />
            <br />
            <br />
            <asp:Label Text="Product" runat="server" />
            <br />
            <asp:TextBox runat="server" ID="productText" />
            <br />
            <br />
            <asp:Label Text="Price" runat="server" />
            <br />
            <asp:TextBox runat="server" ID="priceText" />
            <br />
            <asp:Button Text="Add" runat="server" ID="add" OnClick="add_Click" />
            <br />
            <br />
            <asp:DropDownList runat="server" ID="dropDown">
                <asp:ListItem Text="Choose period..." />
                <asp:ListItem Text="Week" />
                <asp:ListItem Text="Month" />
                <asp:ListItem Text="Year" />
            </asp:DropDownList>
            <asp:Button Text="Calculate" id="calcBtn" runat="server" OnClick="calcBtn_Click" />
            <asp:Label Text="sss" ID="result" runat="server" />
        </div>
    </form>
</body>
</html>
