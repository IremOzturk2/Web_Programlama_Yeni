<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kullanicilar.aspx.cs" Inherits="Proje.Web.Kullanicilar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="KullaniciListele" OnClick="Button1_Click"/>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
