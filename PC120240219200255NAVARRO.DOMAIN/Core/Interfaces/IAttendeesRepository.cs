using PC120240219200255NAVARRO.DOMAIN.Core.Entities;

namespace PC120240219200255NAVARRO.DOMAIN.Core.Interfaces
{
    public interface IAttendeesRepository
    {
        Task<int> CreateAttende(Attendees attende);
        Task<IEnumerable<Attendees>> GetAttendees();
    }
}