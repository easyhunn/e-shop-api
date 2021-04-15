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
            if (stores.Count() == 0)
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
            if (stores.Count() == 0)
            {

                serviceResult.devMsg = Properties.Resources.Msg_NoContent;
                serviceResult.isSuccess = false;
                serviceResult.userMsg = Properties.Resources.Msg_NoContent;
                return serviceResult;
            }

            serviceResult.data = stores;
            return serviceResult;
        }

        public ServiceResult InsertStore(Store store)
        {
            serviceResult.isSuccess = true;
            //kiêm tra thông tin cửa hàng
            if (!ValidateEntity(store, null))
            {
                serviceResult.isSuccess = false;
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
            // kiểm tra dữ liệu
            if (!ValidateEntity(store, storeId))
            {   
                serviceResult.isSuccess = false;
                return serviceResult;
            }
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
        /// <summary>
        /// kiểm tra tính hợp lệ của thông tin
        /// </summary>
        /// <param name="store"></param>
        /// <returns>
        /// True: Nếu thông tin hợp lệ
        /// False: nếu thông tin không hợp lệ
        /// </returns>
        public bool ValidateEntity(Store store, Guid? id)
        {
            //check đủ thông tin bắt buộc
            if (!ValidateInformation(store)) return false;

            // check trùng mã
            if (!isValidCode(store.StoreCode, id)) return false;
            return true;
        }
        /// <summary>
        /// Kiểm tra đầy đủ thông tin bắt buộc
        /// </summary>
        /// <param name="store">
        /// Thông tin cửa hàng
        /// </param>
        /// <returns>
        /// True: Nếu thống tin đủ
        /// False: Nếu có trường thông tin bắt buộc bị trống
        /// </returns>
        public bool ValidateInformation (Store store)
        {
            if (store.StoreName == null || store.StoreName == "")
            {
                serviceResult.userMsg = Properties.Resources.Empty_StoreName;
                serviceResult.errorCode = MISAError.badRequest;
                return false;
            }

            if (store.StoreCode == null || store.StoreCode == "")
            {
                serviceResult.userMsg = Properties.Resources.Empty_StoreCode;
                serviceResult.errorCode = MISAError.badRequest;
                return false;
            }
            if (store.Address == null || store.Address == "")
            {
                serviceResult.userMsg = Properties.Resources.Empty_Address;
                serviceResult.errorCode = MISAError.badRequest;
                return false;
            }
            return true;
        }

        public bool isValidCode (String storeCode , Guid? id)
        {
            Store store = _storeRepository.GetStoreByStoreCode(storeCode);
            if (store != null && store.StoreId != id)
            {
                serviceResult.errorCode = MISAError.badRequest;
                serviceResult.userMsg = Properties.Resources.Duplicate_StoreCode;
                return false;
            }
            return true;
        }

    }
}
