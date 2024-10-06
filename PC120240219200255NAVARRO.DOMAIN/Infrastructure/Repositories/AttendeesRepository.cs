using Microsoft.EntityFrameworkCore;
using PC120240219200255NAVARRO.DOMAIN.Core.Entities;
using PC120240219200255NAVARRO.DOMAIN.Core.Interfaces;
using PC120240219200255NAVARRO.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC120240219200255NAVARRO.DOMAIN.Infrastructure.Repositories
{
    public class AttendeesRepository : IAttendeesRepository
    {
        private readonly EventManagementDbContext _dbContext;

        public AttendeesRepository(EventManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Attendees>> GetAttendees()
        {
            var attendees = await _dbContext.Attendees.ToListAsync();
            return attendees;
        }

        public async Task<int> CreateAttende(Attendees attende)
        {
            await _dbContext.Attendees.AddAsync(attende);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? attende.Id : -1;
        }
    }
}
