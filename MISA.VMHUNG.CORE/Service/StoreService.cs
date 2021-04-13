using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Service
{
    public class StoreService : BaseService<Store>, IStoreService
    {
        private IStoreRepository _storeRepository;
        public StoreService(IStoreRepository storeRepository) : base (storeRepository)
        {
            this._storeRepository = storeRepository;
        }
        public ServiceResult DeleteStore(Guid StoreId)
        {
            serviceResult.isSuccess = true;
            var rowEffect = _storeRepository.DeleteStore(StoreId);
            if (rowEffect == 0)
            {
                serviceResult.isSuccess = false;
                serviceResult.errorCode = MISAError.noContent;
                return serviceResult;
            }
            else
            {
                serviceResult.userMsg = Properties.Resources.Msg_DeleteSuccess;
                return serviceResult;
            }
        }

        public ServiceResult GetStoreByIndexOffset(int positionStart, int offSet)
        {
            serviceResult.isSuccess = true;
            var stores = _storeRepository.GetStoreByIndexOffset(positionStart, offSet);
            if (stores == null)
            {

                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.isSuccess = false;
                serviceResult.userMsg = Properties.Resources.Msg_NoContent;
            }

            serviceResult.data = stores;
            return serviceResult;
            throw new NotImplementedException();
        }

        public ServiceResult GetStoreFilter(StoreFilter storeFilter)
        {
            serviceResult.isSuccess = true;
            var stores = _storeRepository.GetStoreFilter(storeFilter);
            //Nếu không tồn tại bản ghi nào
            if (stores == null)
            {

                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.isSuccess = false;
                serviceResult.userMsg = Properties.Resources.Msg_NoContent;
            }

            serviceResult.data = stores;
            return serviceResult;
        }

        public ServiceResult InsertStore(Store store)
        {
            serviceResult.isSuccess = true;
            //check trùng mã
            if (!ValidateEntity(store))
            {
                return serviceResult;
            }
            //Thêm mới cửa hàng
            var rowEffect = _storeRepository.InsertStore(store);
            //kiểm tra thêm bản ghi mới thành công
            if (rowEffect == 0)
            {
                // Nếu thêm bản ghi không thành công
                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.isSuccess = false;
                serviceResult.errorCode = MISAError.success;
            }
            else
            {
                //Nếu thêm bản ghi thành công
                serviceResult.devMsg = Properties.Resources.Msg_InsertSuccess;
                serviceResult.isSuccess = true;
            }
            return serviceResult;
        }

        public ServiceResult UpdateStore(Store store, Guid storeId)
        {
            serviceResult.isSuccess = true;
            //Thực hiện update
            var res = _storeRepository.UpdateStore(storeId, store);
            //kiểm tra số lượng bản ghi được update
            if (res == 0)
            {
                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.userMsg = Properties.Resources.User_MsgError;
                serviceResult.errorCode = MISAError.noContent;
                serviceResult.isSuccess = false;
            }
            else
            {
                serviceResult.devMsg = Properties.Resources.Msg_Success;
                serviceResult.userMsg = Properties.Resources.Msg_Success;
                serviceResult.errorCode = MISAError.success;
            }
            return serviceResult;
        }

        public int GetCountStores()
        {
            int storeQuantity = _storeRepository.GetCountStores();
            return storeQuantity;
        }
        public bool ValidateEntity(Store store)
        {
            return true;
        }
    }
}
