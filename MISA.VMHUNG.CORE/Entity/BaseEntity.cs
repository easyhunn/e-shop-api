using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Models thực thể chung
    /// </summary>
    /// Created by: VMHUNG ()
    public class BaseEntity
    {
        /// <summary>
        /// Ngày tạo bản ghi
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Người tạo bản ghi
        /// </summary>
        public String CreatedBy { get; set; }
        /// <summary>
        /// Lần chỉnh sửa đổi bản ghi cuối cùng
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Người chỉnh sửa bản ghi cuối cùng
        /// </summary>
        public String ModifiedBy { get; set; }
    }
}
