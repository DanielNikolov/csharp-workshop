using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Messages;
using Task.Models;

namespace Task.Repository
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private Dictionary<int, int> CapacityRecords;

        public WarehouseRepository()
        {
            CapacityRecords = new Dictionary<int, int>();
        }
        public IEnumerable<CapacityRecord> GetCapacityRecords()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CapacityRecord> GetCapacityRecords(Func<CapacityRecord, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductRecord> GetProductRecords()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductRecord> GetProductRecords(Func<ProductRecord, bool> filter)
        {
            throw new NotImplementedException();
        }

        public void SetCapacityRecord(int productId, int capacity)
        {
            if (capacity <= 0)
            {
                throw new QuantityTooLowMessage("Provided quantity is not enough");
            }
            throw new NotImplementedException();
        }

        public void SetProductRecord(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
