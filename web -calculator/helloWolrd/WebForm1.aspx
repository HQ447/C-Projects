<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="helloWolrd.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello World</div>
        <p>
            Order List</p>
        <ol>
            <li>Item</li>
            <li>Item </li>
            <li>Item</li>
            <li>Item</li>
        </ol>
        <p>
            Arithmatic Calculator</p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 208px; top: 428px; position: absolute" Text="Enter 2nd Number"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 422px; top: 360px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 423px; top: 511px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 201px; top: 368px; position: absolute" Text="Enter First Number"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 204px; top: 500px; position: absolute" Text="Sum"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 428px; top: 444px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 398px; top: 609px; position: absolute" Text="Button" />
        </p>
    </form>
</body>
</html>
