<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QR_code__Generate_Read_using_asp.netc_.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QR_code _Generate&Read_using_asp.netc#</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
<asp:Button ID="btnGenerate" runat="server" Text="Generate QR Code" OnClick="QR_Generate_Click" />
             <asp:Label ID="last"  runat="server" Font-Italic="True" Font-Size="Medium"></asp:Label>
<hr />
<asp:Image ID="imgQRCode" Width="100px" Height="100px" runat="server" Visible="false" />     <br /><br />
<asp:Button ID="btnRead" Text="Read QR Image" runat="server" OnClick="QR_Read_Click" />  <br /><br />
<asp:Label ID="lblQRCode" runat="server"></asp:Label>
<br />

<asp:Label ID="error" runat="server" Font-Italic="True" Font-Size="Medium"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
