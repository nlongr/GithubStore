using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DienMayClient.LocalService;


namespace DienMayClient
{
    public partial class LietKeDanhSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChungLoaiServiceClient client = new ChungLoaiServiceClient();

            // Use the 'client' variable to call operations on the service.
            List<ChungLoaiOutput> items = client.DocTatCa();
            // Always close the client.
            client.Close();
            // Ket Xuat
            //grvKetQua.DataSource = items;
            grvChungLoai.DataSource = items.OrderBy(p => p.Ten);
            grvChungLoai.DataBind();
        }
    }
}