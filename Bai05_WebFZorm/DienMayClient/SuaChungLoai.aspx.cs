using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DienMayClient.LocalService;

namespace DienMayClient
{
    public partial class SuaChungLoai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string idCL = Request.QueryString["idCL"];
            if (string.IsNullOrEmpty(idCL))
                Response.Redirect("~/LietKeDanhSachChungLoai.aspx");
            else
            {
                int id = int.Parse(idCL);
                XuatThongTinChungLoai(id);
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            ChungLoaiInput input = new ChungLoaiInput();
            input.ID = int.Parse(txtIDChungLoai.Text);
            input.Ten = txtTenChungLoai.Text;

            ChungLoaiServiceClient client = new ChungLoaiServiceClient();
            string kq = client.Sua(input);
            client.Close();

            if (kq == "")
                lblThongBao.Text = "Sửa thành công.";
            else
                lblThongBao.Text = kq;
        }

        private void XuatThongTinChungLoai(int id)
        {
            var client = new ChungLoaiServiceClient();
            ChungLoaiOutput output = client.DocTheoID(id);
            client.Close();
            if (output != null)
            {
                txtIDChungLoai.Text = output.ID.ToString();
                txtTenChungLoai.Text = output.Ten;
                txtTongSoLoai.Text = output.TongSoLoai.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                lblThongBao.Text = string.Format("Chủng loại ID={0} không tồn tại", id);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtIDChungLoai.Text);
            ChungLoaiServiceClient client = new ChungLoaiServiceClient();
            string kq = client.Huy(id);
            client.Close();

            if (kq == "")
                Response.Redirect("~/LietKeDanhSachChungLoai.aspx");
            else
                lblThongBao.Text = kq;
        }
    }
}