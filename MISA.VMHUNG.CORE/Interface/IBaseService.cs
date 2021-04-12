using MISA.VMHUNG.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Interface
{
    public interface IBaseService <MISAEntity>
    {
        /// <summary>
        /// lấy tất cả bản ghi
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <returns></returns>
        /// Created By: VM Hùng (12/04/2021)
        ServiceResult GetAll();
        /// <summary>
        /// lấy khách hàng theo ID
        /// </summary>
        /// <typeparam name="ServiceResult"></typeparam>
        /// <returns></returns>
        /// Created By: VM Hùng (12/04/2021)
        ServiceResult GetById(Guid entityId);
    }
}
