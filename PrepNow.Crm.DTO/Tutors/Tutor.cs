using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrepNow.Crm.Domain.Tutors
{
    public class Tutor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PublicShortProfile { get; set; }
        public List<TutorSubject> TutorSubjects { get; set; }
    }
}