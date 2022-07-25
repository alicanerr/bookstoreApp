using Acme.BookStore.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class CustomerDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerDataSeederContributor(IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _customerRepository.GetCountAsync() <=0)
            {
                await _customerRepository.InsertAsync(new Customer
                {
                    MusteriAd = "Safran A.Ş",
                    RiskLimit = 90,
                    FaturaAdres = "Karabük"
                },
                autoSave: true
                );
                await _customerRepository.InsertAsync(new Customer
                {
                    MusteriAd = "Metafore A.Ş",
                    RiskLimit = 70,
                    FaturaAdres = "Ankara"
                },
               autoSave: true
               );
                await _customerRepository.InsertAsync(new Customer
                {
                    MusteriAd = "ali A.Ş",
                    RiskLimit = 80,
                    FaturaAdres = "Şişli"
                },
               autoSave: true
               );
            }
        }
    }
}
