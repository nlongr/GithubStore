<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemChungLoai.aspx.cs" Inherits="DienMayClient.ThemChungLoai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Thêm chủng loại mới</h2>
        <div>
            <label>Tên chủng loại</label>
            <asp:TextBox ID="txtTen" runat="server" Width="300px"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnGhi" runat="server" Text="Ghi thông tin" OnClick="btnGhi_Click" />
            <br />
            <br />
            <asp:Label ID="lblThongBao" runat="server" ForeColor="#FF6600"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
