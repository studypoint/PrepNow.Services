using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrepNow.TutorProfileService.Models;

namespace PrepNow.TutorProfileService.Repositories
{
    interface ITutorRepository
    {
        IEnumerable<Tutor> Get();
        bool TryGet(int id, out Tutor tutor);
        //Tutor Add(Tutor tutor);
        //bool Delete(int id);
        //bool Update(Tutor tutor);
    }
}
