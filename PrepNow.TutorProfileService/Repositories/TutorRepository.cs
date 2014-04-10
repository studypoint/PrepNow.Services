using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Insight.Database;
using System.Data.SqlClient;
using PrepNow.TutorProfileService.Models;

namespace PrepNow.TutorProfileService.Repositories
{
    public class TutorRepository : ITutorRepository
    {
        string connectionString = "user id=StudySmart;" +
                                       "password=asdfjyims;server=portaldev.studypoint.com;" +
                                       "Trusted_Connection=yes;" +
                                       "database=StudySmart; " +
                                       "connection timeout=30";

        public IEnumerable<Tutor> Get()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            //IList<Tutor> tutors = conn.QuerySql<Tutor>("SELECT top 10 ID, FirstName, LastName FROM Tutors");
            IList<Tutor> tutors = conn.QuerySql<Tutor, List<TutorSubject>>("SELECT top 100 * FROM Tutors t " + 
                                                                    "JOIN TutorSubjects ts ON ts.TID = t.ID " +
                                                                    "JOIN Subjects s ON s.ID = ts.SID " +
                                                                    "WHERE StatusId = 1 AND (OfficeID = 24 OR PNTAvailable = 1)", Parameters.Empty);
            
            return tutors;

        }

        public bool TryGet(int id, out Models.Tutor tutor)
        {
            throw new NotImplementedException();
        }

        public Tutor Get(int argID)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            //IList<Tutor> tutors = conn.QuerySql<Tutor>("SELECT top 10 ID, FirstName, LastName FROM Tutors");
            var tutor = conn.QuerySql<Tutor>("SELECT * FROM Tutors WHERE ID = @ID", new { ID = argID }).FirstOrDefault();

            return tutor;
        }

        //public Models.Tutor Add(Models.Tutor tutor)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Update(Models.Tutor tutor)
        //{
        //    throw new NotImplementedException();
        //}
    }
}