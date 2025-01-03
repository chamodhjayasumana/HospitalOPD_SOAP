using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalOPD_SOAP;



public partial class AddPatient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMessage.Visible = false;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            // Get input values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime dateOfBirth = DateTime.Parse(txtDateOfBirth.Text.Trim());
            string gender = ddlGender.SelectedValue;
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string emergencyContact = txtEmergencyContact.Text.Trim();
            string bloodGroup = txtBloodGroup.Text.Trim();

            // Call the SOAP service
            var patientService = new HospitalOPD_SOAP.PatientService();

            bool isSuccess = patientService.AddPatient(firstName, lastName, dateOfBirth, gender, phoneNumber, email, address, emergencyContact, bloodGroup);

            // Display message
            if (isSuccess)
            {
                lblMessage.Text = "Patient added successfully!";
                lblMessage.CssClass = "text-success";
                lblMessage.Visible = true;
                ClearForm();
            }
            else
            {
                lblMessage.Text = "Failed to add patient. Please try again.";
                lblMessage.CssClass = "text-danger";
                lblMessage.Visible = true;
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = "Error: " + ex.Message;
            lblMessage.CssClass = "text-danger";
            lblMessage.Visible = true;
        }
    }

    private void ClearForm()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtDateOfBirth.Text = "";
        ddlGender.SelectedIndex = 0;
        txtPhoneNumber.Text = "";
        txtEmail.Text = "";
        txtAddress.Text = "";
        txtEmergencyContact.Text = "";
        txtBloodGroup.Text = "";
    }
}

