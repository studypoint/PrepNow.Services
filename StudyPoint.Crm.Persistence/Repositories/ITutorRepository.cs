using System.Collections.Generic;
using StudyPoint.Crm.DTO.Tutors;

namespace StudyPoint.Crm.Persistence.Repositories
{
    public interface ITutorRepository
    {
        IEnumerable<Tutor> GetAllPrepNowTutors();
        bool TryGetTutorById(int argTutorId, out Tutor argTutor_out);
        Tutor GetTutorById(int argTutorId);
        //Tutor Add(Tutor tutor);
        //bool Delete(int id);
        //bool Update(Tutor tutor);
    }
}
