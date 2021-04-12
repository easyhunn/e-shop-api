using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Thông tin xã/phường
    /// </summary>
    /// CreatedBy: VM Hùng (12/04/2021)
    public class Ward : BaseEntity
    {
        public Ward () { }
        /// <summary>
        /// Id của xã/phường
        /// khoá chính
        /// </summary>
        ///  CreatedBy: VM Hùng (12/04/2021)
        public Guid WardId { get; set; }
        /// <summary>
        /// Tên xã/phường
        /// </summary>
        ///  CreatedBy: VM Hùng (12/04/2021)
        public String WardName { get; set; }
        /// <summary>
        /// Id của quận huyện
        /// Khoá ngoại liên kết với bảng quận huyện
        /// </summary>
        ///  CreatedBy: VM Hùng (12/04/2021)
        public Guid DistrictId { get; set; }

    }
}
