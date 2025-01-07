using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for AuthService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AuthService : System.Web.Services.WebService
{
    private static Dictionary<string, string> tokens = new Dictionary<string, string>(); // Simulating token storage

    // Login method to validate credentials and return a token
    [WebMethod]
    public string Login(string username, string password)
    {
        // Validate credentials (replace with actual database validation)
        if (username == "admin" && password == "password")
        {
            // Generate random token
            string token = GenerateRandomToken();

            // Store the token with username
            tokens[token] = username;

            return token;
        }
        else
        {
            throw new Exception("Invalid credentials");
        }
    }

    // Validate token method
    [WebMethod]
    public bool ValidateToken(string token)
    {
        // Check if token exists in storage
        return tokens.ContainsKey(token);
    }

    // Generate a random token
    private string GenerateRandomToken()
    {
        return Guid.NewGuid().ToString(); // Generates a random unique token
    }

   
    [WebMethod]
    public void Logout(string token)
    {
        // Remove token from storage
        if (tokens.ContainsKey(token))
        {
            tokens.Remove(token);
        }
    }

}