<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Name:
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp; News:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SendButton" runat="server" OnClick="Button2_Click" Text="Send" />
        <br />
        <br />
        <br />
        <asp:Button ID="RecieveButton" runat="server" OnClick="Button1_Click" Text="Receive news" />
        <br />
&nbsp;<asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="140px" Width="363px"></asp:ListBox>
    </form>
</body>
</html>
