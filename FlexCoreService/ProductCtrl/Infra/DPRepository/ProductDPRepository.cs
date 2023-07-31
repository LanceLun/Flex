using Dapper;
using FlexCoreService.ProductCtrl.Interface;
using FlexCoreService.ProductCtrl.Models.Dtos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FlexCoreService.ProductCtrl.Infra.DPRepository
{
    public class ProductDPRepository : IProductRepository
    {
        private string _connStr;
        private IConfiguration _configuration;
        public ProductDPRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connStr = _configuration.GetConnectionString("AppDbContext");
        }

        public IEnumerable<ProductCardDto> SearchProducts()
        {
            string sql = @"select p.ProductId, p.ProductName, p.UnitPrice, p.SalesPrice, MIN(pi.ImgPath) AS FirstImgPath 
from Products as p
join ProductImgs as pi on p.ProductId = pi.fk_ProductId
group by p.ProductId, p.ProductName, p.UnitPrice, p.SalesPrice, p.Status, p.LogOut
having p.Status=0 and p.LogOut=0
order by p.ProductId";

            using IDbConnection dbConnection = new SqlConnection(_connStr);
            var result = dbConnection.Query<ProductCardDto>(sql);
            return result;
        }

    }
}
