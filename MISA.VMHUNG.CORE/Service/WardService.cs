using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Core.Service
{
    public class WardService:BaseService<Ward>, IWardService
    {
        public WardService(IWardRepository wardRepository):base(wardRepository)
        {

        }
    }
}
