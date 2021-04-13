using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.VMHUNG.ESHOP.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProvinceController : BaseEntityController<Province>
    {
        private IProvinceService _provinceService;
        public ProvinceController(IProvinceService provinceService) : base(provinceService)
        {
            this._provinceService = provinceService;
        }
       
        /// <summary>
        /// Lấy tỉnh/thành phố theo quốc gia
        /// </summary>
        /// <param name="countryId">
        /// Mã id của quốc gia
        /// </param>
        /// <returns>
        /// 204: Nếu không lấy được tỉnh thành phố nào
        /// 200: Nếu có tình/thành phố trả về
        /// </returns>
        
        [HttpGet("country/{Id}")]
        public IActionResult GetProvinceWithCountry (Guid Id)
        {
            var res = _provinceService.GetProvinceWithCountry(Id);
            if (res == null)
            {
                return StatusCode(204, res);
            } else
            {
                return Ok(res.data);
            }
        }
    }
}
