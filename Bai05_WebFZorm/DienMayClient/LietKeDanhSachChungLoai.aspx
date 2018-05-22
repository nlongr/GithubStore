<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LietKeDanhSachChungLoai.aspx.cs" Inherits="DienMayClient.LietKeDanhSach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Danh sách Chủng loại</h2>

        <br />
        <asp:GridView ID="grvChungLoai" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="Chủng loại ID">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Ten" HeaderText="Tên chủng loại" />
                <asp:BoundField DataField="TongSoLoai" HeaderText="Tổng số loại">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/SuaChungLoai.aspx?idCL={0}" Target="_blank" Text="Hiệu chỉnh" />
            </Columns>
        </asp:GridView>

    </div>
    </form>
</body>
</html>
