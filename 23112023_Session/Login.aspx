i<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_23112023_Session.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Kullanıcı Adı</td>
                    <td>
                        <asp:TextBox ID="txtKullanici" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <%--  --%>
                <tr>
                    <td>Parola</td>
                    <td>
                        <asp:TextBox ID="txtParola" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <%--  --%>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />
                    </td>
                </tr>

            </table>
            <hr />
            <asp:Label ID="lblBilgi" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
