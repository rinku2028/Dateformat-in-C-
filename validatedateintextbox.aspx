<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validatedateintextbox.aspx.cs" Inherits="datevalidatetextbox.validatedateintextbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Validate Date" OnClick="Button1_Click" />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
