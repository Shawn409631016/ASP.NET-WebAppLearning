<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="dataSet.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1">
                <EditItemTemplate>
                    CID:
                    <asp:TextBox ID="CIDTextBox" runat="server" Text='<%# Bind("CID") %>' />
                    <br />
                    CNAME:
                    <asp:TextBox ID="CNAMETextBox" runat="server" Text='<%# Bind("CNAME") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    CID:
                    <asp:TextBox ID="CIDTextBox" runat="server" Text='<%# Bind("CID") %>' />
                    <br />
                    CNAME:
                    <asp:TextBox ID="CNAMETextBox" runat="server" Text='<%# Bind("CNAME") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                </InsertItemTemplate>
                <ItemTemplate>
                    CID:
                    <asp:Label ID="CIDLabel" runat="server" Text='<%# Bind("CID") %>' />
                    <br />
                    CNAME:
                    <asp:Label ID="CNAMELabel" runat="server" Text='<%# Bind("CNAME") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:imConnectionString %>" SelectCommand="SELECT [CID], [CNAME] FROM [customer] WHERE ([CID] = @CID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="CID" PropertyName="Text" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
