using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrepNow.TutorProfileService.Models;

namespace PrepNow.TutorProfileService.Controllers
{
    public class TutorProfilesController : ApiController
    {
        //change to Dependency Injection
         static Repositories.TutorRepository repository = new Repositories.TutorRepository();

                // GET api/tutorprofiles
         public IEnumerable<Tutor> GetTutorProfiles()
        {
            //return new Tutor[] { new Tutor {ID=1, FirstName="Joe", LastName = "Shmoe"}, new Tutor {ID=2, FirstName="Jane", LastName="Doe"} };
            //call repository for all tutors

            return repository.Get();
        }

        // GET api/tutorprofiles/5
        public Tutor GetTutorProfile(int id)
        {
            //Tutor tutor;
            //if (!repository.TryGet(id, out tutor))
            //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            //return tutor;

            return repository.Get(id);
        }

        //// POST api/tutorprofiles
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/tutorprofiles/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/tutorprofiles/5
        //public void Delete(int id)
        //{
        //}
    }
}
