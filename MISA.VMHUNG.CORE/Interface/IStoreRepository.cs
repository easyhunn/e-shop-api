using MISA.VMHUNG.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Interface
{
    public interface IStoreRepository:IBaseRepository<Store>
    {
        /// <summary>
        /// Xóa thông tin cửa hàng
        /// </summary>
        /// <param name="storeId">
        /// id của cửa hàng
        /// </param>
        /// <returns>
        /// Số lượng bản ghi được xoá
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        int DeleteStore(Guid storeId);
        /// <summary>
        /// Lấy dữ liệu cửa hàng theo vị trí đầu vào và số lượng cần lấy
        /// </summary>
        /// <param name="positionStart">
        /// Vị trí cửa hàng theo danh sách đầu vào
        /// </param>
        /// <param name="offSet">
        /// Số lượng bản ghi cửa hàng cần lấy
        /// </param>
        /// <returns>
        /// Thông tin những cửa hàng lấy được
        /// null trong trường hợp không có cửa hàng nào được lấy
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        IEnumerable<Store> GetStoreByIndexOffset(int positionStart, int offSet);
        /// <summary>
        /// Lấy thông tin cửa hàng theo điều kiện
        /// </summary>
        /// <param name="storeFilter">
        /// Thông tin các điều kiện cần lọc
        /// </param>
        /// <returns>
        /// Dánh sách các cửa hàng sau khi lọc
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        IEnumerable<Store> GetStoreFilter(StoreFilter storeFilter);
        /// <summary>
        /// Thêm mới 1 cửa hàng
        /// </summary>
        /// <param name="store">
        /// Thông tin cửa hàng
        /// </param>
        /// <returns>
        /// Số lượng cửa hàng thêm thành công
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        int InsertStore(Store store);
        /// <summary>
        /// Sửa thông tin cửa hàng
        /// </summary>
        /// <param name="storeId">
        /// Mã id của cửa hàng
        /// </param>
        /// <param name="store">
        /// Thông tin cửa hàng sau sửa đổi
        /// </param>
        /// <returns>
        /// Số lượng cửa hàng sửa đổi thông tin 
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        int UpdateStore(Guid storeId, Store store);
        /// <summary>
        /// Lấy số lượng cửa hàng có trong database
        /// </summary>
        /// <returns>
        /// Trả về số lượng cửa hàng
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        int GetCountStores();
        /// <summary>
        /// Lấy thông tin cửa hàng dựa theo mã cửa hàng
        /// </summary>
        /// <param name="StoreCode">
        /// Mã cửa hàng
        /// </param>
        /// <returns>
        /// thông tin cửa hàng được lấy
        /// </returns>
        /// CreatedBy: VM Hùng (13/04/2021)
        Store GetStoreByStoreCode(String storeCode);
    }
}
