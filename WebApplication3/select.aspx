<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select.aspx.cs" Inherits="WebApplication3.select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
            <br />
            Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Skill:<br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Java" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
