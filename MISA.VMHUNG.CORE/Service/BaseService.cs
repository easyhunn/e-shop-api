using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Service
{
    public class BaseService<MISAEntity> : IBaseService<MISAEntity>
    {
        IBaseRepository<MISAEntity> _baseRepository;
        protected ServiceResult serviceResult;
        public BaseService(IBaseRepository<MISAEntity> baseRepository)
        {
            this._baseRepository = baseRepository;
            serviceResult = new ServiceResult();
        }
        /// <summary>
        /// Lấy thông tin tất cả khách hàng
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <returns></returns>
        /// Created by: VM Hùng (02/04/2021)
        public ServiceResult GetAll()
        {
            // Lấy tất cả bản ghi
            serviceResult.isSuccess = true;
            var customers = _baseRepository.GetAll();

            // Kiểm tra số lượng bản ghi trả về
            if (customers.Count() == 0)
            {
                serviceResult.isSuccess = false;
                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.userMsg = Properties.Resources.User_MsgError;
                serviceResult.errorCode = MISAError.noContent;
            }
            else
            {
                serviceResult.data = customers;
                serviceResult.devMsg = Properties.Resources.Msg_Success;
            }

            return serviceResult;
        }

        public ServiceResult GetById(Guid id)
        {
            serviceResult.isSuccess = true;
            //Lấy dữ dữ liệu

            var entity = _baseRepository.GetById(id);
            //Kiểm trả bản ghi có tồn tại không
            if (entity == null)
            {
                //Nếu không có bản ghi trả về
                serviceResult.isSuccess = false;
                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.userMsg = Properties.Resources.User_MsgError;
                serviceResult.errorCode = MISAError.noContent;
            }
            else
            {
                serviceResult.data = entity;
                serviceResult.devMsg = Properties.Resources.Msg_Success;
            }
            return serviceResult;
        }
    }
}
