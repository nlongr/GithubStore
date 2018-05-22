using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DienMayClient.LocalService;

namespace DienMayClient
{
    public partial class ThemChungLoai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            ChungLoaiInput input = new ChungLoaiInput();
            input.Ten = txtTen.Text;

            ChungLoaiServiceClient client = new ChungLoaiServiceClient();
            string kq = client.Them(input);
            client.Close();

            if (kq == "")
            { lblThongBao.Text = "Ghi thành công!"; }
            else
            { lblThongBao.Text = kq; }
        }
    }
}