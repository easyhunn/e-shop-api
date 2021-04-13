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
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        
        public int DeleteStore(Guid storeId)
        {
            var storeEffect = dbConnection.Execute($"Proc_DeleteStore", new { StoreId = storeId }, commandType: System.Data.CommandType.StoredProcedure);

            return storeEffect;
        }

        public IEnumerable<Store> GetStoreByIndexOffset(int positionStart, int offSet)
        {
            //Tạo mới object 
            var parameters = new DynamicParameters();
            parameters.Add($"@positionStart", positionStart, DbType.String);
            parameters.Add($"@offSet", offSet, DbType.String);

            //Thực hiện update
            var stores = dbConnection.Query<Store>($"Proc_GetStoreByIndexOffset", parameters, commandType: CommandType.StoredProcedure);
            return stores;
        }

        public IEnumerable<Store> GetStoreFilter(StoreFilter storeFilter)
        {
            var stores = dbConnection.Query<Store>($"Proc_GetStoreFilter", storeFilter, commandType: CommandType.StoredProcedure);
            return stores;
        }
       
        public int InsertStore(Store store)
        {
            var rowEffect = dbConnection.Execute($"Proc_InsertStore", store, commandType: CommandType.StoredProcedure);
            return rowEffect;
        }

        public int UpdateStore(Guid storeId, Store store)
        {
            store.StoreId = storeId;
            var rowEffect = dbConnection.Execute($"Proc_UpdateStore", store, commandType: CommandType.StoredProcedure);
            return rowEffect;
        }
        public int GetCountStores()
        {
            int numberStores = dbConnection.ExecuteScalar<int>($"Proc_GetCountStores", commandType: CommandType.StoredProcedure);
            return numberStores;
        }

        public Store GetStoreByStoreCode(string storeCode)
        {
            var parameters = new DynamicParameters();
            parameters.Add($"@StoreCode", storeCode, DbType.String);
            var entity = dbConnection.Query<Store>($"Proc_GetStoreByStoreCode", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entity;
        }
    }
}
