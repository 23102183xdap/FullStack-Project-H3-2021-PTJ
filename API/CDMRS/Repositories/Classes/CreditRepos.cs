using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Database.Context;
using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Classes
{
    public class CreditRepos : ICreditRepos
    {
        private readonly APIDBContext _context;

        public CreditRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<CreditModel> Create(Credit credit)
        {
            credit.CreatedAt = DateTime.Now;
            _context.Credits.Add(credit);
            await _context.SaveChangesAsync();

            return credit;
        }

        public async Task<CreditModel> Delete(int id)
        {
            var credit = await _context.Credits
                .FirstOrDefaultAsync(c => c.Id == id);

            if (credit != null || credit.DeletedAt == null)
            {
                credit.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return credit;
        }

        public async Task<CreditModel> Get(int id)
        {
            return await _context.Credits
                .Where(c => c.DeletedAt == null)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CreditModel>> GetAll()
        {
            return await _context.Credits
                .Where(c => c.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<CreditModel> Update(int id, Credit updatedCredit)
        {
            var credit = await _context.Credits
                .FirstOrDefaultAsync(c => c.Id == id);

            if (credit != null)
            {
                credit.EditedAt = DateTime.Now;

                credit.CreditAmount = updatedCredit.CreditAmount;

                _context.Update(credit);
                await _context.SaveChangesAsync();
            }

            return credit;
        }
    }
}
