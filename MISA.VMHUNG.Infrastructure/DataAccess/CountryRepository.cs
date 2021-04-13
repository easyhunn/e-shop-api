using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Infrastructure.DataAccess
{
    public class CountryRepository:BaseRepository<Country>, ICountryRepository
    {
    }
}
