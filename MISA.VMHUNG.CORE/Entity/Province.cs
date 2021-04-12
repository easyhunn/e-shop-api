using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Thông tin tỉnh thành phố
    /// </summary>
    /// CreateBy: VM Hùng (12/04/2021)
    public class Province:BaseEntity
    {
        public Province() { }
        /// <summary>
        /// id của tỉnh/thành phố
        /// khoá chính
        /// </summary>
        /// CreateBy: VM Hùng (12/04/2021)
        public Guid ProvinceId { get; set; }
        /// <summary>
        /// Tên tỉnh thành phố
        /// </summary>
        /// CreateBy: VM Hùng (12/04/2021)
        public String ProvinceName { get; set; }
        /// <summary>
        /// Id của đất nước
        /// Khoá ngoại với bảng quốc gia
        /// </summary>
        /// CreateBy: VM Hùng (12/04/2021)
        public Guid CountryId { get; set; }

    }
    
}
