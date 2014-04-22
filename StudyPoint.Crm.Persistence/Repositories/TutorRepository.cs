using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Insight.Database;
using StudyPoint.Crm.DTO.Tutors;

namespace StudyPoint.Crm.Persistence.Repositories
{
    public class TutorRepository : ITutorRepository
    {
        string connectionString = "user id=StudySmart;" +
                                       "password=asdfjyims;server=portaldev.studypoint.com;" +
                                       "Trusted_Connection=yes;" +
                                       "database=StudySmart; " +
                                       "connection timeout=30";

        public IEnumerable<Tutor> GetAllPrepNowTutors()
        {
            var conn = new SqlConnection(connectionString);
           // var i = conn.As<ITutorRepository>();

            //IList<Tutor> tutors = conn.QuerySql<Tutor>("SELECT top 10 * FROM Tutors " +
            //                                             "WHERE StatusId = 1 AND (OfficeID = 24 OR PNTAvailable = 1)");
            //var tutors =
            //    conn.QuerySql<Tutor, TutorSubject>(
            //        "SELECT TOP 100 t.ID, t.FirstName, t.LastName, t.PublicShortProfile, s.Name, s.Description FROM    Tutors t JOIN    TutorSubjects ts ON ts.TID = t.ID JOIN    Subjects s ON s.ID = ts.SID WHERE   t.StatusId = 1 AND ( t.OfficeID = 24 OR t.PNTAvailable = 1)",
            //        Parameters.Empty);

            var tutors2 = conn.Query("GetAllPrepNowTutors", Parameters.Empty, Query.Returns(Some<Tutor>.Records).ThenChildren(Some<TutorSubject>.Records));

            //var results = i.GetAllPrepNowTutors();

            return tutors2;

        }

        public bool TryGetTutorById(int argTutorId, out Tutor argTutor_out)
        {
            try
            {
                argTutor_out = GetTutorById(argTutorId);
                return (argTutor_out != null);
            }
            catch (Exception)
            {
                argTutor_out = null;
                return false;
            }
        }

        public Tutor GetTutorById(int argTutorId)
        {
            var conn = new SqlConnection(connectionString);

            //IList<Tutor> tutors = conn.QuerySql<Tutor>("SELECT top 10 ID, FirstName, LastName FROM Tutors");
            var tutor = conn.QuerySql<Tutor>("SELECT * FROM Tutors WHERE ID = @ID", new { ID = argTutorId }).FirstOrDefault();

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