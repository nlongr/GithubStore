using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DienMayServices
{
    # region Bước 01: Tạo Data Contract
  
    [DataContract]
    public class ChungLoaiInput
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Ten { get; set; }
        
    }

    [DataContract]
    public class ChungLoaiOutput:ChungLoaiInput
    {
        [DataMember]
        public int TongSoLoai { get; set; }
        
    }
    # endregion

#    region Bước 02: Tạo Service Contract

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChungLoaiService" in both code and config file together.
    [ServiceContract]
    public interface IChungLoaiService
    {
        #region
        [OperationContract]
        List<ChungLoaiOutput> DocTatCa();

        [OperationContract]
        List<ChungLoaiOutput> DocTheoTen(string value);

        [OperationContract]
        ChungLoaiOutput DocTheoID(int id);
        #endregion

        [OperationContract]
        string Them(ChungLoaiInput entity);

        [OperationContract]
        string Sua(ChungLoaiInput entity);

        [OperationContract]
        string Huy(int id);

    }

    
    # endregion
}
