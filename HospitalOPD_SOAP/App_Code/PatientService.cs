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

//////////////////

//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Web.Services;

//namespace HospitalOPD_SOAP
//{
//    /// <summary>
//    /// PatientService class for managing patient-related operations
//    /// </summary>
//    [WebService(Namespace = "http://hospital.opd/")]
//    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//    public class PatientService : System.Web.Services.WebService
//    {
//        private Main main = new Main();
//        private AuthService authService = new AuthService(); // Instance of AuthService to validate tokens

//        // Helper method to validate token
//        private bool IsTokenValid(string token)
//        {
//            return authService.ValidateToken(token); // Validate the token
//        }

//        // Add patient method
//        [WebMethod]
//        public bool AddPatient(string token, string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string email, string address, string emergencyContact, string bloodGroup)
//        {
//            if (IsTokenValid(token)) // Validate token before proceeding
//            {
//                return main.InsertPatient(firstName, lastName, dateOfBirth, gender, phoneNumber, email, address, emergencyContact, bloodGroup);

//            }
//            else
//            {
//                throw new Exception("Invalid token. Unauthorized access.");
//            }
//        }

//        // Update patient method
//        [WebMethod]
//        public bool UpdatePatient(string token, int patientId, string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string email, string address, string emergencyContact, string bloodGroup)
//        {
//            if (IsTokenValid(token)) // Validate token before proceeding
//            {
//                return main.UpdatePatient(patientId, firstName, lastName, dateOfBirth, gender, phoneNumber, email, address, emergencyContact, bloodGroup);
//            }
//            else
//            {
//                throw new Exception("Invalid token. Unauthorized access.");
//            }
//        }

//        // Get all patients
//        [WebMethod]
//        public string GetAllPatients(string token)
//        {
//            if (IsTokenValid(token)) // Validate token before proceeding
//            {
//                var patients = main.GetAllPatients();
//                return JsonConvert.SerializeObject(patients);
//            }
//            else
//            {
//                throw new Exception("Invalid token. Unauthorized access.");
//            }
//        }

//        // Get patient by ID
//        [WebMethod]
//        public string GetPatientByID(string token, int patientId)
//        {
//            if (IsTokenValid(token)) // Validate token before proceeding
//            {
//                var patient = main.GetPatientByID(patientId);
//                return JsonConvert.SerializeObject(patient);
//            }
//            else
//            {
//                throw new Exception("Invalid token. Unauthorized access.");
//            }
//        }

//        // Search for patients by search term
//        [WebMethod]
//        public string SearchPatients(string token, string searchTerm)
//        {
//            if (IsTokenValid(token)) // Validate token before proceeding
//            {
//                var patients = main.SearchPatients(searchTerm);
//                return JsonConvert.SerializeObject(patients);
//            }
//            else
//            {
//                throw new Exception("Invalid token. Unauthorized access.");
//            }
//        }
//    }
//}
