using MISA.VMHUNG.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Interface
{
    public interface IStoreService : IBaseService<Store>
    {
        /// <summary>
        ///Xóa cửa hàng
        /// </summary>
        /// <param name="StoreId">
        /// Mã Id cửa hàng
        /// </param>
        /// <returns>
        /// Mã lỗi 
        /// Tin nhắn cho user và dev
        /// Số lượng bản ghi được xóa
        /// </returns>
        ServiceResult DeleteStore(Guid StoreId);
        /// <summary>
        /// Cập nhật thông tin bản ghi
        /// </summary>
        /// <param name="store">
        /// Thông tin cửa hàng
        /// </param>
        /// <param name="storeId">
        /// Thông tin id của cửa hàng
        /// </param>
        /// <returns>
        /// Mã lỗi 
        /// Tin nhắn cho user và dev
        /// Số lượng bản ghi được sửa
        /// </returns>
        /// CreatedBy: Vũ Mạnh Hùng (04/02/2021)
        ServiceResult UpdateStore(Store store, Guid storeId);
        /// <summary>
        /// Thêm mới 1 cửa hàng
        /// </summary>
        /// <param name="store">
        /// Thông tin cửa hàng
        /// </param>
        /// <returns>
        /// Mã lỗi 
        /// Tin nhắn cho user và dev
        /// Số lượng bản ghi được thêm
        /// </returns>
        ServiceResult InsertStore(Store store);
        /// <summary>
        /// Lọc dữ liệu cửa hàng theo thuộc tính
        /// </summary>
        /// <param name="storeFilter">
        /// Thuộc tính lọc
        /// </param>
        /// <returns>
        /// Trường hợp lỗi:
        /// Mã lỗi 
        /// Tin nhắn cho user và dev
        /// Số lượng bản ghi lấy được
        /// Thành công: 
        /// Những bản ghi lấy được
        /// </returns>
        ServiceResult GetStoreFilter(StoreFilter storeFilter);
        /// <summary>
        /// Lấy dữ liệu cửa hàng theo vị trí đầu vào và số lượng cần lấy
        /// </summary>
        /// <param name="positionStart">
        /// Vị trí cửa hàng trong danh sách
        /// </param>
        /// <param name="offSet">
        /// Số lượng cửa hàng cần lấy
        /// </param>
        /// <returns>
        /// Thành công: Dánh sách các cửa hàng lấy
        /// Không thành công:
        /// Mã lỗi 
        /// Tin nhắn cho user và dev
        /// Số lượng bản ghi lấy được
        /// </returns>
        ServiceResult GetStoreByIndexOffset(int positionStart, int offSet);
        /// <summary>
        /// Lấy số lượng cửa hàng có trong database
        /// </summary>
        /// <returns>
        /// Trả về số lượng cửa hàng
        /// 204 Nếu không có cửa hàng nào
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        ServiceResult GetCountStores();
        /// <summary>
        /// Lấy thông tin cửa hàng theo mã cửa hàng
        /// </summary>
        /// <param name="storeCode">
        /// Mã cửa hàng
        /// </param>
        /// <returns>
        /// 200: nếu cửa hàng tồn tại
        /// 204: Nếu không có cửa hàng nào tồn tại
        /// </returns>
        /// CreatedBy: VM Hùng (16/04/2021)
        ServiceResult GetStoreByStoreCode(String storeCode);

    }
}
