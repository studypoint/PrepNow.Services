using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrepNow.Crm.DTO.Tutors;
using PrepNow.Crm.Persistence;

namespace PrepNow.Crm.Domain.Tutors
{
    class TutorManager
    {
        static Persistence.Repositories.TutorRepository _tutorRepository = new Persistence.Repositories.TutorRepository();

        public static IEnumerable<Tutor> GetAllTutors()
        {
            return _tutorRepository.Get();
        }
    }
}
