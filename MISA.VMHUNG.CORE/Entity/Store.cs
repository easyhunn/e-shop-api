using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Thông tin cửa hàng
    /// </summary>
    /// Created By: VMHUNG(21/04/2021)
    public class Store:BaseEntity
    {
        public Store ()
        {

        }
        /// <summary>
        /// Khoá chính id của cửa hàng
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public Guid StoreId { get; set; }
        /// <summary>
        /// Mã cửa hàng
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public String StoreCode { get; set; }
        /// <summary>
        /// Tên cửa hàng
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public String StoreName { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public String Address { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public String PhoneNumber { get; set; }
        /// <summary>
        /// Mã số thuế
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public String StoreTaxCode { get; set; }
        /// <summary>
        /// Id của quốc giá (Khoá ngoại với bảng quốc gia)
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public Guid? CountryId { get; set; }
        /// <summary>
        /// Id tỉnh/thành phố (Khoá ngoại với bảng tỉnh/thành phố)
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public Guid? ProvinceId { get; set; }
        /// <summary>
        /// Id quận/huyện (Khoá ngoại với bảng quận huyện)
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public Guid? DistrictId { get; set; }
        /// <summary>
        /// Id Phường xã (Khoá ngoại với bảng phường/xã)
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public Guid? WardId { get; set; }
        /// <summary>
        /// Đường phố
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public String Street { get; set; }
        /// <summary>
        /// Trạng thái hoạt động
        /// 0: Đang hoạt động
        /// 1: Đang đóng cửa
        /// </summary>
        /// Created By: VMHUNG(21/04/2021)
        public int Status { get; set; }
    }
}
