using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Database.Context;
using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Classes
{
    public class CustomerRepos : ICustomerRepos
    {
        private readonly APIDBContext _context;

        public CustomerRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<CustomerModel> Create(CustomerModel customer)
        {
            customer.CreatedAt = DateTime.Now;
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<CustomerModel> Delete(int id)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer != null || customer.DeletedAt == null)
            {
                customer.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return customer;
        }

        public async Task<CustomerModel> Get(int id)
        {
            return await _context.Customers
                .Where(c => c.DeletedAt == null)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CustomerModel>> GetAll()
        {
            return await _context.Customers
                .Where(c => c.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<CustomerModel> Update(int id, CustomerModel updatedCustomer)
        {
            var customer = await _context.Customers
                 .FirstOrDefaultAsync(b => b.Id == id);

            if (customer != null)
            {
                customer.EditedAt = DateTime.Now;

                //customer.Login = updatedCustomer.Login != null ? updatedCustomer.Login : customer.Login;

                //customer.Credit = updatedCustomer.Credit != null ? updatedCustomer.Credit : customer.Credit;

                customer.UserName = updatedCustomer.UserName != null ? updatedCustomer.UserName : customer.UserName;

                customer.FirstName = updatedCustomer.FirstName != null ? updatedCustomer.FirstName : customer.FirstName;

                customer.LastName = updatedCustomer.LastName != null ? updatedCustomer.LastName : customer.LastName;

                customer.BirthDay = updatedCustomer.BirthDay != DateTime.MinValue ? updatedCustomer.BirthDay : customer.BirthDay;

                customer.AddressStreet = updatedCustomer.AddressStreet != null ? updatedCustomer.AddressStreet : customer.AddressStreet;

                customer.AddressNumber = updatedCustomer.AddressNumber;

                customer.AddressPostCode = updatedCustomer.AddressPostCode;

                _context.Update(customer);
                await _context.SaveChangesAsync();
            }

            return customer;
        }
    }
}
