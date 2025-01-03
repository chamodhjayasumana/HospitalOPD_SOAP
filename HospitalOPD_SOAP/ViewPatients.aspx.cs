//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//public partial class ViewPatients : System.Web.UI.Page
//{
//    protected void Page_Load(object sender, EventArgs e)
//    {
//        if (!IsPostBack)
//        {
//            LoadPatients();
//        }
//    }

//    //protected void SearchPatients_Click(object sender, EventArgs e)
//    //{
//    //    string searchTerm = txtSearch.Value; 
//    //    LoadPatients(searchTerm);
//    //}

//    protected void btnSearch_Click(object sender, EventArgs e)
//    {
//        string searchTerm = txtSearch.Value.Trim();
//        string jsonResult = patientService.SearchPatients(searchTerm);
//        DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonResult);

//        if (dt != null && dt.Rows.Count > 0)
//        {
//            gvPatients.DataSource = dt;
//            gvPatients.DataBind();
//        }
//        else
//        {
//            gvPatients.DataSource = null;
//            gvPatients.DataBind();
//        }
//    }



//    private void LoadPatients(string searchTerm = "")
//    {
//        try
//        {
//            var patientService = new HospitalOPD_SOAP.PatientService();

//            // Get the patients JSON (could be a list or array of patient objects)
//            string patientsJson = string.IsNullOrEmpty(searchTerm)
//                ? patientService.GetAllPatients()
//                : patientService.SearchPatients(searchTerm);

//            // Deserialize the JSON into a list of patient objects (assuming a Patient class is defined)
//            var patients = JsonConvert.DeserializeObject<List<Patient>>(patientsJson);

//            // Bind the patient list to the GridView
//            gvPatients.DataSource = patients;
//            gvPatients.DataBind();
//        }
//        catch (Exception ex)
//        {
//            Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
//        }
//    }


//    private void LoadAllPatients()
//    {
//        string jsonResult = patientService.GetAllPatients();
//        DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonResult);

//        if (dt != null && dt.Rows.Count > 0)
//        {
//            gvPatients.DataSource = dt;
//            gvPatients.DataBind();
//        }
//        else
//        {
//            gvPatients.DataSource = null;
//            gvPatients.DataBind();
//        }
//    }
//}






//////////////////////
///
using System;
using System.Data;
using HospitalOPD_SOAP; // Reference your SOAP service namespace

public partial class ViewPatients : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadAllPatients();
        }
    }

    private void LoadAllPatients()
    {
        var patientService = new HospitalOPD_SOAP.PatientService();
        string jsonResult = patientService.GetAllPatients();
        DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonResult);

        if (dt != null && dt.Rows.Count > 0)
        {
            gvPatients.DataSource = dt;
            gvPatients.DataBind();
        }
        else
        {
            gvPatients.DataSource = null;
            gvPatients.DataBind();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        var patientService = new HospitalOPD_SOAP.PatientService();
        string searchTerm = txtSearch.Value.Trim();
        string jsonResult = patientService.SearchPatients(searchTerm);
        DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonResult);

        if (dt != null && dt.Rows.Count > 0)
        {
            gvPatients.DataSource = dt;
            gvPatients.DataBind();
        }
        else
        {
            gvPatients.DataSource = null;
            gvPatients.DataBind();
        }
    }
}
