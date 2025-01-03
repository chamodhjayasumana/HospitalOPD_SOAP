using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Patient
/// </summary>
public class Patient
{
    public int PatientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public static Address Address { get; set; }

    public string BloodGroup { get; set; }

    public DateTime DateOfBirth { get; set; }



}
