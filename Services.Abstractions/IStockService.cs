using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IStockService
    {
        Task<Stock> GetStockById();
        Task<IEnumerable<Stock>> GetAllStocks();
        void AddStock(Stock stock);
        void UpdateStock(Stock stock);
        void DeleteStock(Stock stock);
    }
}
