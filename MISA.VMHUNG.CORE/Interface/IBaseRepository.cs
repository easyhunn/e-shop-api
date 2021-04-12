using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Interface
{
    public interface IBaseRepository<MISAEntity>
    {
        /// <summary>
        /// lấy tất cả bản ghi
        /// </summary>
        /// <returns>
        /// Danh sách thông tin tất cả bảng ghi
        /// </returns>
        /// Created By: VM Hùng (12/04/2021)
        IEnumerable<MISAEntity> GetAll();
        /// <summary>
        /// Lấy thông tin bản ghi theo Id
        /// </summary>
        /// <param name="id">id của bản ghi</param>
        /// <returns>
        /// Bản ghi được lấy về
        /// Null trong trương hợp k tìm thấy bản ghi nào
        /// </returns>
        /// Created By: VM Hùng (12/04/2021)
        MISAEntity GetById(Guid id);       
    }
}
