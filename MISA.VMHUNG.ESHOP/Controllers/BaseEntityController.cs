using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.VMHUNG.ESHOP.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseEntityController<Entity> : ControllerBase
    {
        private IBaseService<Entity> _baseService;
        public BaseEntityController(IBaseService<Entity> baseService)
        {
            this._baseService = baseService;
        }
        /// <summary>
        /// Lấy thông tin tất cả bản ghi
        /// </summary>
        /// <returns>
        /// 200: Nếu có bản ghi trả về
        /// 204: Nếu không có bản ghi trả về
        /// </returns>
        /// Created by: VM Hùng 02/04/2021
        [HttpGet]
        public IActionResult GetAll()
        {

            var res = _baseService.GetAll();
            if (!res.isSuccess)
            {
                return StatusCode(204, res);
            }
            else
            {
                return Ok(res.data);
            }

        }
        /// <summary>
        /// Lấy thông tin bản ghi theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// Created by: VM Hùng 02/04/2021
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {

            var res = _baseService.GetById(id);
            if (!res.isSuccess)
            {
                return StatusCode(204, res);
            }
            return Ok(res.data);
        }
    }
}
