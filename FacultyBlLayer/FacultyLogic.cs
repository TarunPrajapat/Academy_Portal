using AdminBoLayer;
using FacultyBoLayer;
using FacultyDaLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyBlLayer
{
    public class FacultyLogic
    {
        FacultyDaLayer.FacultyContext db = new FacultyDaLayer.FacultyContext();

        public bool SaveFacultyDetails(Faculty facultyModel)
        {
          
                facultyModel.ModifiedDate = null;
                facultyModel.CreatedDate = DateTime.Now;
                facultyModel.RegistrationStatus = "Pending";
                db.Faculties.Add(facultyModel);
                db.SaveChanges();
                return true;
        
        }

        public IEnumerable<Faculty> GetFacultyDetails()
        {
            using (FacultyContext db = new FacultyContext())
            {
                var facultyModel = db.Faculties.Where(s => s.IsDeleted == false).ToList();
                return facultyModel;
            }
        }
        public IEnumerable<Faculty> GetFacultyStatus()
        {
            using (FacultyContext db = new FacultyContext())
            {
                var facultyModel = db.Faculties.Where(s => s.RegistrationStatus=="Pending" && s.IsDeleted==false).ToList();
                return facultyModel;
            }
        }
      
        public IEnumerable<Faculty> GetDeletedRecord()
        {
            var deletedRecord = db.Faculties.Where(s => s.IsDeleted == true).ToList();
            return deletedRecord;
        }


        public Faculty GetFacultyDetailsById(int id)
        {
            using (FacultyContext db = new FacultyContext())
            {
                var facultyModel = db.Faculties.Where(s => s.UserId == id).FirstOrDefault();
                return facultyModel;
            }
        }

        public bool LoginCredentials(Faculty facultyModel)
        {
            using (FacultyContext db = new FacultyContext())
            {
                var status = db.Faculties.Where(s => s.UserId == facultyModel.UserId && s.Password == facultyModel.Password).FirstOrDefault();
                if (status != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool EditFacultyDetails(Faculty faculty,string status,bool isdeleted)
        {
            using (FacultyContext db = new FacultyContext())
            {
                if (faculty!=null)
                {
                    faculty.RegistrationStatus = status;
                    faculty.IsDeleted = isdeleted;
                    db.Entry(faculty).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool EditFacultyNominationStatus(Faculty faculty, string status, int? batchId,Batch batch)
        {

            AdminDaLayer.AdminContext admindb = new AdminDaLayer.AdminContext();
                if (faculty != null && batch !=null)
                {
                    faculty.NominationStatus = status;
                    faculty.BatchId = batchId;
                   if(status=="Accepted")
                    {
                    batch.AssignFacultyStatus = "yes";
                    }
                    else
                    {
                    batch.AssignFacultyStatus = "no";
                    }
                    admindb.Entry(batch).State = EntityState.Modified;
                    admindb.SaveChanges();

                    db.Entry(faculty).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public bool DeleteFaculty(int id, Faculty faculty)
        {
            using (FacultyContext db = new FacultyContext())
            {
                var facultyModel = db.Faculties.Find(id);
                if (facultyModel != null)
                {
                    facultyModel.IsDeleted = true;
                    facultyModel.RegistrationStatus = "Rejected";
                    db.Entry(facultyModel).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(100050, 999950).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;

        }
        public int GetFacultyId(Faculty facultyModel)
        {
            using (FacultyContext db = new FacultyContext())
            {
                var userId = db.Faculties.Where(s => s.SecurityQuestion == facultyModel.SecurityQuestion && s.SecurityQueAnswer == facultyModel.SecurityQueAnswer && (s.Contact == facultyModel.Contact || s.Email == facultyModel.Email)).Select(s => s.UserId).SingleOrDefault();
                return userId;
            }
        }
        public Faculty VerifyPasswordRecoveryDetails(Faculty facultyModel)
        {
            using (FacultyContext db = new FacultyContext())
            {
                var userId = db.Faculties.Where(s => s.SecurityQuestion == facultyModel.SecurityQuestion && s.SecurityQueAnswer == facultyModel.SecurityQueAnswer && s.UserId == facultyModel.UserId).FirstOrDefault();
                return userId;
            }
        }
        public bool GetPasswordReset(string password, Faculty facultyModel)
        {
            using (FacultyContext db = new FacultyContext())
            {
                try
                {
                    if (facultyModel != null)
                    {
                        facultyModel.Password = password;
                        facultyModel.ModifiedDate = DateTime.Now;
                        db.Entry(facultyModel).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
