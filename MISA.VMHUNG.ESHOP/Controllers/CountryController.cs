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
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseEntityController<Country>
    {
        private IBaseService<Country> _baseService;
        public CountryController (IBaseService<Country> baseService) : base(baseService)
        {

        }
    }
}
