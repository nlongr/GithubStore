using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DienMayClient.CVThanhService;


namespace DienMayClient
{
    public partial class TraCuuChungLoai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXemTatCa_Click(object sender, EventArgs e)
        {
            ChungLoaiServiceClient client = new ChungLoaiServiceClient();

            // Use the 'client' variable to call operations on the service.
            List<ChungLoaiOutput> items = client.DocTatCa();
            // Always close the client.
            client.Close();
            // Ket Xuat
            //grvKetQua.DataSource = items;
            grvKetQua.DataSource = items.OrderBy(p=>p.Ten);
            grvKetQua.DataBind();

        }

        protected void btnTraCuuTheoID_Click(object sender, EventArgs e)
        {
            ChungLoaiServiceClient client = new ChungLoaiServiceClient();
            int idChungLoai = int.Parse(txtTuKhoa.Text);
            ChungLoaiOutput item = client.DocTheoID(idChungLoai);
            // Use the 'client' variable to call operations on the service.
            
            // Always close the client.
            client.Close();
            //ket xuat
            lblKetQua.Text = string.Format(@"ID: {1}{0}Tên: {2}{0}Tổng số loại: {3}{0}", "<br/>", item.ID, item.Ten, item.TongSoLoai);

        }
    }
}