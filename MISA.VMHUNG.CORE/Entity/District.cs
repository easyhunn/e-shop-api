using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Thông tin quận/huyện
    /// </summary>
    /// CreatedBy: VM Hùng (12/04/2021)
    public class District:BaseEntity
    {
        public District()
        {

        }
        /// <summary>
        /// id của quận/huyện (khoá chính)
        /// </summary>
        /// CreatedBy: VM Hùng (12/04/2021)
        public Guid DistrictId { get; set; }
        /// <summary>
        /// Tên quận/huyện
        /// </summary>
        /// CreatedBy: VM Hùng (12/04/2021)
        public String DistrictName { get; set; }
        /// <summary>
        /// id của tỉnh/thành phố (Khoá ngoại với bảng tỉnh/thành phố)
        /// </summary>
        /// CreatedBy: VM Hùng (12/04/2021)
        public Guid ProvinceId { get; set; }

    }
}
