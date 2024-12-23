<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Database_in_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" ProviderName="<%$ ConnectionStrings:SchoolConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="426px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="fee" HeaderText="fee" SortExpression="fee" />
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 654px; top: 54px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 653px; top: 105px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 648px; top: 156px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; top: 227px; position: absolute; left: 650px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 643px; top: 303px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 981px; top: 229px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 518px; top: 303px; position: absolute" Text="Fee"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 510px; top: 160px; position: absolute" Text="Age"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 523px; top: 232px; position: absolute" Text="address"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 513px; top: 55px; position: absolute" Text="ID"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 510px; top: 104px; position: absolute" Text="Name"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="position: absolute; z-index: 1; left: 979px; top: 297px" Text="Update By ID" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 618px; top: 465px; position: absolute" Text="Display All" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="z-index: 1; left: 643px; top: 556px; position: absolute" Text="Serach By ID" />
        <p>
            &nbsp;</p>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="z-index: 1; left: 266px; top: 489px; position: absolute" Text="Delete By ID" />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 573px; top: 384px; position: absolute" Text="Insert into student" />
        </p>
    </form>
</body>
</html>
