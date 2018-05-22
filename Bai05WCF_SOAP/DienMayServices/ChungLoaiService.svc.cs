using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DienMayServices.Models;

namespace DienMayServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChungLoaiService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ChungLoaiService.svc or ChungLoaiService.svc.cs at the Solution Explorer and start debugging.
    public class ChungLoaiService : IChungLoaiService
    {
        DienMayEntityModel db = new DienMayEntityModel();
        #region
        public List<ChungLoaiOutput> DocTatCa()
        {
            var items = db.ChungLoais
                .Select(p => new ChungLoaiOutput
                {
                    ID = p.ChungLoaiID,
                    Ten = p.Ten,
                    TongSoLoai = p.Loais.Count
                })
                .ToList();
            return items;
        }

        public List<ChungLoaiOutput> DocTheoTen(string value)
        {
            var items = db.ChungLoais
                .Where(k => k.Ten.Contains(value))
                .Select(p => new ChungLoaiOutput
                {
                    ID = p.ChungLoaiID,
                    Ten = p.Ten,
                    TongSoLoai = p.Loais.Count
                })
                .ToList();
            return items;
        }

        public ChungLoaiOutput DocTheoID(int id)
        {
            ChungLoaiOutput item = db.ChungLoais
                .Select(p => new ChungLoaiOutput
                {
                    ID = p.ChungLoaiID,
                    Ten = p.Ten,
                    TongSoLoai = p.Loais.Count
                })
                .SingleOrDefault(p => p.ID == id);

            return item;
        }
        #endregion
        //buoi6
        #region Phương thức sử dụng cục bộ
        private string KiemTraTrung(string value, int id = 0)
        {
            string kq = "";
            var entity = db.ChungLoais.SingleOrDefault(p => p.Ten == value.Trim());
            if (entity != null && entity.ChungLoaiID != id)
                kq = "Tên chủng loại " + value + " đã có rồi.";
            return kq;
        }
        #endregion
        public string Them(ChungLoaiInput entity)
        {
            if (entity == null) return "Lổi: Chủng loại null";
            if (entity.Ten == null || entity.Ten.Trim() == "") return "Lổi: Tên chủng loại không được để trống";
            string kq = "";
            try
            {
                kq = KiemTraTrung(entity.Ten);
                if (kq == "")
                {
                    ChungLoai chungLoaiMoi = new ChungLoai();
                    chungLoaiMoi.Ten = entity.Ten;
                    chungLoaiMoi.BiDanh = XuLyDuLieu.LoaiBoDauTiengViet(entity.Ten);
                    db.ChungLoais.Add(chungLoaiMoi);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                kq = string.Format("Thêm chủng loại [{0}] không thành công.", entity.Ten + ex.Message);
            }
            return kq;
        }

        public string Sua(ChungLoaiInput entity)
        {
            if (entity == null) return "Lổi: Chủng loại null";
            if (entity.Ten == null || entity.Ten.Trim() == "") return "Lổi: Tên chủng loại không được để trống";
            string kq = "";
            try
            {
                kq = KiemTraTrung(entity.Ten, entity.ID);
                if (kq == "")
                {
                    var chungLoaiHC = db.ChungLoais.Find(entity.ID);
                    chungLoaiHC.Ten = entity.Ten;
                    chungLoaiHC.BiDanh = XuLyDuLieu.LoaiBoDauTiengViet(entity.Ten);
                    db.Entry(chungLoaiHC).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                kq = string.Format("Hiệu chỉnh chủng loại [{0}] không thành công.", entity.Ten + ex.Message);
            }
            return kq;
        }

        public string Huy(int id)
        {
            string kq = "";
            try
            {
                var chungLoaiHuy = db.ChungLoais.Find(id);
                if (chungLoaiHuy == null) throw new Exception("Chủng loại ID=" + id + " không tồn tại.");
                db.ChungLoais.Remove(chungLoaiHuy);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                kq = string.Format("Hủy chủng loại [{0}] không thành công. Do đã có thông tin phụ thuộc", id);
            }
            catch (Exception ex)
            {
                kq = string.Format("Lỗi hủy chủng loại. Lý do:{0}", ex.Message);
            }

            return kq;
        }

    }
}
