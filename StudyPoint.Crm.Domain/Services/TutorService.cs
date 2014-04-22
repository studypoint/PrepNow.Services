using System.Collections.Generic;
using StudyPoint.Crm.Domain.Managers;
using StudyPoint.Crm.DTO.Tutors;
using StudyPoint.Crm.Persistence.Repositories;

namespace StudyPoint.Crm.Domain.Services
{
    public class TutorService
    {
        private static TutorManager _tutorManager = new TutorManager(new TutorRepository());

        public static IEnumerable<Tutor> GetAllPrepNowTutors()
        {
            return _tutorManager.GetAllPrepNowTutors();
        }

        public static Tutor GetTutorById(int argTutorId)
        {
            return _tutorManager.GetTutorById(argTutorId);
        }
    }
}
