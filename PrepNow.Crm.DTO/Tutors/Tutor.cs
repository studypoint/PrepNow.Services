using System.Collections.Generic;
using PrepNow.Crm.DTO.Tutors;

namespace StudyPoint.Crm.DTO.Tutors
{
    public class Tutor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PublicShortProfile { get; set; }
        public IList<TutorSubject> TutorSubjects { get; set; }
    }
}