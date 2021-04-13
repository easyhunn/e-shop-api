using MISA.VMHUNG.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Interface
{
    public interface IProvinceRepository:IBaseRepository<Province>
    {
        /// <summary>
        /// Lấy tỉnh/thành phố theo quốc gia
        /// </summary>
        /// <returns>
        /// Danh sách các tỉnh/thành phố được lấy
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        IEnumerable<Province> GetProvinceWithCountry(Guid Id);
    }
}
