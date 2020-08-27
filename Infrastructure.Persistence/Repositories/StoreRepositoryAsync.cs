using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class StoreRepositoryAsync : GenericRepositoryAsync<Store>, IStoreRepositoryAsync
    {
        private readonly DbSet<Product> _products;

        public StoreRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<Product>();
        }

        public Task<bool> IsUniqueBarcodeAsync(string barcode)
        { 
            return _products
                .AllAsync(p => p.Barcode != barcode);
        }
    }
}
