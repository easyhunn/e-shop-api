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
    public class WardController : BaseEntityController<Ward>
    {
        public WardController(IWardService wardService) : base(wardService)
        {

        }
    }
}
