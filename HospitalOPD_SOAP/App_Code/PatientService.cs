using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;




namespace HospitalOPD_SOAP
{
    /// <summary>
    /// Summary description for PatientService
    /// </summary>
    [WebService(Namespace = "http://hospital.opd/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // Change the class declaration from internal to public

    public class PatientService : System.Web.Services.WebService
    {
        private Main main = new Main();

        [WebMethod]
        public bool AddPatient(string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string email, string address, string emergencyContact, string bloodGroup)
        {
            return main.InsertPatient(firstName, lastName, dateOfBirth, gender, phoneNumber, email, address, emergencyContact, bloodGroup);
        }

        [WebMethod]
        public bool UpdatePatient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string email, string address, string emergencyContact, string bloodGroup)
        {
            return main.UpdatePatient(patientId, firstName, lastName, dateOfBirth, gender, phoneNumber, email, address, emergencyContact, bloodGroup);
        }

        [WebMethod]
        public string GetAllPatients()
        {
            var patients = main.GetAllPatients();
            return Newtonsoft.Json.JsonConvert.SerializeObject(patients);
        }


        [WebMethod]
        public string GetPatientByID(int patientId)
        {
            var patient = main.GetPatientByID(patientId);
            return Newtonsoft.Json.JsonConvert.SerializeObject(patient);
        }

        [WebMethod]
        public string SearchPatients(string searchTerm)
        {
            var patients = main.SearchPatients(searchTerm);
            return Newtonsoft.Json.JsonConvert.SerializeObject(patients);
        }




    }


}

