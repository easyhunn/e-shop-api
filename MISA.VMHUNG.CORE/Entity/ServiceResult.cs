using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Entity
{
    public class ServiceResult
    {
        /// <summary>
        /// Kết quả service thành công
        /// </summary>
        public bool isSuccess;
        public ServiceResult()
        {
            isSuccess = true;
        }
        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        /// CreatedBy: VM Hùng (02/04/2021)
        public object data { get; set; }

        /// <summary>
        /// Messeage cho dev
        /// </summary>
        public String devMsg { get; set; }
        /// <summary>
        /// Thông báo lỗi trả về cho khách hàng
        /// </summary>
        /// CreatedBy: VM Hùng (02/04/2021)
        public String userMsg { get; set; }
        /// <summary>
        /// Mã lỗi của MISA
        /// </summary>
        /// CreatedBy: VM Hùng (02/04/2021)
        public String errorCode { get; set; }
        /// <summary>
        /// Thông tin cần biết thêm
        /// </summary>
        /// CreatedBy: VM Hùng (02/04/2021)
        public String moreInfo { get; set; }
        /// <summary>
        /// traceId
        /// </summary>
        /// CreatedBy: VM Hùng (02/04/2021)
        public String traceId { get; set; }
    }
}
