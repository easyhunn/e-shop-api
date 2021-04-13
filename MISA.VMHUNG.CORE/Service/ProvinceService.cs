using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Service
{
    public class ProvinceService:BaseService<Province>, IProvinceService
    {
        private IProvinceRepository _provinceRepository;
        public ProvinceService(IProvinceRepository provinceRepository) :base(provinceRepository)
        {
            this._provinceRepository = provinceRepository;
        }

        public ServiceResult GetProvinceWithCountry(Guid Id)
        {
            serviceResult.isSuccess = true;
            //Lấy dữ dữ liệu

            var provinces = _provinceRepository.GetProvinceWithCountry(Id);
            //Kiểm trả bản ghi có tồn tại không
            if (provinces == null)
            {
                //Nếu không có bản ghi trả về
                serviceResult.isSuccess = false;
                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.userMsg = Properties.Resources.User_MsgError;
                serviceResult.errorCode = MISAError.noContent;
            }
            else
            {
                serviceResult.data = provinces;
                serviceResult.devMsg = Properties.Resources.Msg_Success;
            }
            return serviceResult;
        }
    }
}
