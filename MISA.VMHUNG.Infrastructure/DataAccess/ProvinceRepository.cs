using Dapper;
using MISA.VMHUNG.Core.Entity;
using MISA.VMHUNG.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.VMHUNG.Infrastructure.DataAccess
{
    public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
    {
        public IEnumerable<Province> GetProvinceWithCountry(Guid Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add($"@Id", Id, DbType.String);
            var provinces = dbConnection.Query<Province>($"Proc_GetProvinceWithCountry", parameters, commandType: CommandType.StoredProcedure);
            return provinces;
        }
    }
}
