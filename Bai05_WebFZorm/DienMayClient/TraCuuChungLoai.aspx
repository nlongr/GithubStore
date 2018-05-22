<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TraCuuChungLoai.aspx.cs" Inherits="DienMayClient.TraCuuChungLoai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtTuKhoa" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnXemTatCa" runat="server" Text="1-Xem tất cả" OnClick="btnXemTatCa_Click" />
        <br />
        <p><asp:Button ID="btnTraCuuTheoTen" runat="server" Text="2- Tra cứu theo tên" /></p>
        
        <p><asp:Button ID="btnTraCuuTheoID" runat="server" Text="2- Tra cứu theo ID" OnClick="btnTraCuuTheoID_Click" /></p>
        <asp:Label ID="lblKetQua" runat="server" Text=""></asp:Label>
        <asp:GridView ID="grvKetQua" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>

