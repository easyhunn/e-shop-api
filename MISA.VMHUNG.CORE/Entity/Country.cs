using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    /// <summary>
    /// Thông tin quốc gia
    /// </summary>
    /// CreatedBy: VM Hùng (12/04/2021)
    public class Country:BaseEntity
    {
        public Country ()
        {

        }
        /// <summary>
        /// id của quốc gia (khoá chính)
        /// </summary>
        /// CreatedBy: VM Hùng (12/04/2021)
        public Guid CountryId { get; set; }
        /// <summary>
        /// Tên quốc gia
        /// </summary>
        /// CreatedBy: VM Hùng (12/04/2021)
        public String CountryName { get; set; }
  
    }
}
