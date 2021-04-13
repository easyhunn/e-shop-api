using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Những trường thông tin lọc cửa hàng
    /// </summary>
    /// Created By: VM Hùng (13/04/2021)
    public class StoreFilter
    {
        public StoreFilter ()
        {
        }
        /// <summary>
        /// Mã cửa hàng
        /// </summary>
        /// Created By: VM Hùng (13/04/2021)
        public String StoreCode { get; set; }
        /// <summary>
        /// Tên cửa hàng
        /// </summary>
        /// Created By: VM Hùng (13/04/2021)
        public String StoreName { get; set; }
        /// <summary>
        /// Địa chỉ cửa hàng
        /// </summary>
        /// Created By: VM Hùng (13/04/2021)
        public String Address { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        /// Created By: VM Hùng (13/04/2021)
        public String PhoneNumber { get; set; }
        /// <summary>
        /// Trạng thái hoạt động
        /// </summary>
        /// Created By: VM Hùng (13/04/2021)
        public int? Status { get; set; }
    }
}
