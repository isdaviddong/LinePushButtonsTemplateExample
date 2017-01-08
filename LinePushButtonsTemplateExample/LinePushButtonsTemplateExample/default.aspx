<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LinePushButtonsTemplateExample._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Channel Access Token:
        <br />
        <asp:TextBox ID="txbToken" runat="server" TextMode="MultiLine" Width="526px"></asp:TextBox>
        <br />
        <br />
        to User :<br />
&nbsp;<asp:TextBox ID="TxbUserId" runat="server" Width="517px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="發送" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
