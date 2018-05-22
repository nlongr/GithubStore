<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuaChungLoai.aspx.cs" Inherits="DienMayClient.SuaChungLoai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <h2>Thêm chủng loại mới</h2>
        </div>
        <div>
            <label>ID chủng loại</label>
            <asp:TextBox ID="txtIDChungLoai" runat="server" Width="300px" ReadOnly="True"></asp:TextBox>
        </div>
        <div>
            Tên chủng loại
            <asp:TextBox ID="txtTenChungLoai" runat="server" Width="300px"></asp:TextBox>
        </div>
        <div>
            Tổng số loại
            <asp:TextBox ID="txtTongSoLoai" runat="server" Width="300px" ReadOnly="True"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" Enabled="False" />
            <asp:Button ID="btnXoa" runat="server" Text="Xóa" Enabled="False" OnClick="btnXoa_Click" />
        </div>
        <div>
            <asp:Label ID="lblThongBao" runat="server" ForeColor="#FF6600"></asp:Label>
        </div>

    </form>
</body>
</html>
