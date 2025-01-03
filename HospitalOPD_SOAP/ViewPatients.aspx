<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewPatients.aspx.cs" Inherits="ViewPatients" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Patients</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2 class="text-center">Patient Records</h2>

            <div class="form-group">
                <label for="txtSearch">Search:</label>
                <input type="text" id="txtSearch" class="form-control" placeholder="Enter patient name, email, or phone" runat="server" />
                <button id="btnSearch" class="btn btn-primary mt-2" runat="server" OnClick="btnSearch_Click">Search</button>
            </div>

           <asp:GridView ID="gvPatients" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped">
                <Columns>
                    <asp:BoundField DataField="patient_id" HeaderText="ID" />
                    <asp:BoundField DataField="first_name" HeaderText="First Name" />
                    <asp:BoundField DataField="last_name" HeaderText="Last Name" />
                    <asp:BoundField DataField="phone_number" HeaderText="Phone Number" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="blood_group" HeaderText="Blood Group" />
                    <asp:BoundField DataField="date_of_birth" HeaderText="Date of Birth" DataFormatString="{0:yyyy-MM-dd}" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>