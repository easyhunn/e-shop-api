using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.VMHUNG.ESHOP.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StoreController : BaseEntityController<Store>
    {
        private IStoreService _storeService; 
        public StoreController(IStoreService storeService) : base(storeService)
        {
            this._storeService = storeService;
        }

        /// <summary>
        /// Xoá thông tin cửa hàng 
        /// </summary>
        /// <param name="storeId">
        /// Mã id của cửa hàng
        /// </param>
        /// <returns>
        /// 200: thành công
        /// 204: Không lấy được dữ liệu
        /// </returns>
        /// Created By:VM Hùng (13/04/2021)
        [HttpDelete("{storeId}")]
        public IActionResult DeleteEntity(Guid storeId)
        {

            var res = _storeService.DeleteStore(storeId);
            if (res.isSuccess)
            {
                return Ok(res.userMsg);
            }
            else
            {
                return StatusCode(204, res);
            }

        }

        /// <summary>
        /// Cập nhật thông tin cửa hàng
        /// </summary>
        /// <param name="store">
        /// Thông tin cửa hàng
        /// </param>
        /// <param name="storeId">
        /// Mã id của cửa hàng
        /// </param>
        /// <returns>
        /// 200: Nếu cập nhật thành công
        /// 204: Nếu không có bản ghi nào được cập nhật
        /// 400: Nếu trường thông tin bị sai
        /// </returns>
        /// Created By:VM Hùng (13/04/2021)
        [HttpPut("{storeId}")]
        public IActionResult UpdateEntity([FromBody] Store store, Guid storeId)
        {

            var res = _storeService.UpdateStore(store, storeId);
            if (res.isSuccess) return Ok(res.userMsg);
            else
            {
                if (res.errorCode == MISAError.badRequest)
                    return StatusCode(400, res);
                else return StatusCode(204, res);
            }
        }
        /// <summary>
        /// Thêm mới 1 cửa hàng
        /// </summary>
        /// <param name="store">
        /// cửa hàng
        /// </param>
        /// <returns>
        /// 201: Nếu thêm cửa hàng thành công
        /// 400: Nếu thông tin đầu vào bị sai
        /// 200: Không có bản ghi nào được thêm
        /// </returns>
        /// Created By:VM Hùng (13/04/2021)
        [HttpPost]
        public IActionResult InsertEntity(Store store)
        {
            //thêm dữ liệu
            var res = _storeService.InsertStore(store);
            //kiểm tra thêm thành công
            if (res.isSuccess)
            {
                return StatusCode(201, res.userMsg);
            }
            else
            {
                if (res.errorCode == MISAError.badRequest)
                {
                    return StatusCode(400, res);
                }
                return StatusCode(200, res.userMsg);
            }
        }
        /// <summary>
        /// Lọc thông tin khách hàng theo đầu vào
        /// </summary>
        /// <param name="storeCode">
        /// Mã cửa hàng
        /// </param>
        /// <param name="storeName"> Tên cửa hàng</param>
        /// <param name="address"> Địa chỉ</param>
        /// <param name="phoneNumber">Số điện thoại</param>
        /// <returns>
        /// 200: Nếu lấy được dánh sách cửa hàng
        /// 204: Nếu không có dữ liệu được lấy về
        /// </returns>
        /// Created By:VM Hùng (13/04/2021)
        [HttpGet("Filter")]

        public IActionResult GetStoreFilter(String storeCode, String storeName, String address, String phoneNumber)
        {
            var storeFilter = new StoreFilter();
            storeFilter.StoreCode = storeCode;
            storeFilter.StoreName = storeName;
            storeFilter.Address = address;
            storeFilter.PhoneNumber = phoneNumber;
            ServiceResult res = _storeService.GetStoreFilter(storeFilter);
            if (res.isSuccess)
            {
                return Ok(res.data);
            }
            else
            {
                return StatusCode(204, res);
            }
        }
        /// <summary>
        /// Lấy thông tin cửa hàng theo vị trí bắt đầu và số lượng
        /// </summary>
        /// <param name="positionStart">vị trí bản ghi </param>
        /// <param name="offSet">số lượng bản ghi cần lấy</param>
        /// <returns>
        /// 200: nếu lấy bản ghi thành công
        /// 204: Nếu không lấy được bản ghi nào
        /// </returns>
        /// Created By:VM Hùng (13/04/2021)
        [HttpGet("Page")]
        public IActionResult GetStoreByIndexOffset(int positionStart, int offSet) 
        {
            ServiceResult res = _storeService.GetStoreByIndexOffset(positionStart, offSet);
            if (res.isSuccess)
            {
                return Ok(res.data);
            }
            else
            {
                return StatusCode(204, res);
            }
        }
        /// <summary>
        /// Lấy số lượng cửa hàng hiện có trong database
        /// </summary>
        /// <returns>
        /// Số lượng bản ghi cửa hàng trong database
        /// </returns>
        /// Created By:VM Hùng (13/04/2021)
        [HttpGet("StoresQuantity")]

        public int GetCountStores()
        {
            return _storeService.GetCountStores();
        }

    }
}
