using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyPoint.Crm.DTO.Tutors;
using StudyPoint.Crm.Persistence.Repositories;

namespace StudyPoint.Crm.Domain.Managers
{
    internal class TutorManager
    {
        private readonly ITutorRepository _repository;

        public TutorManager(ITutorRepository argRepository)
        {
            _repository = argRepository;
        }

        public IEnumerable<Tutor> GetAllPrepNowTutors()
        {
            return _repository.GetAllPrepNowTutors();
        }

        public Tutor GetTutorById(int argTutorId)
        {
            Tutor tutor;
            return _repository.TryGetTutorById(argTutorId, out tutor) ? tutor : null;
        }
    }
}
