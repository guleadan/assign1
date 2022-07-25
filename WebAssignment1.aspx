<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAssignment1.aspx.cs" Inherits="WebAssignment1.WebAssignment1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Data</title>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script>
        function runAjax() {
            var selected = document.getElementById("DropDown");
            $.ajax({
                url: 'WebAssignment1.aspx.cs/DisplayData',
                type: 'post',
                data: JSON.stringify({ "student": selected }),
                contentType: 'application/json',
                async: false,
                error:function () { alert("Ops, Error Occured!") },
                success: function (data) {
                    document.getElementById("fname").innerHTML = data.d[0];
                    document.getElementById("lname").innerHTML = data.d[1];
                    document.getElementById("rollno").innerHTML =data.d[2];
                }
            })
        }
            
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <h2>Select Sutdent Name</h2>
            <asp:DropDownList  runat="server" ID="DropDown" width="200px" OnCheckChange="runAjax()" ></asp:DropDownList><br />
            <asp:Label runat="server">First Name:</asp:Label>
            <asp:Label runat="server" ID="fname"></asp:Label><br />

            <asp:Label runat="server" >Last Name: </asp:Label>
            <asp:Label runat="server" ID="lname"></asp:Label><br />

            <asp:Label runat="server">Roll Number:</asp:Label>
            <asp:Label runat="server" ID="rollno"></asp:Label><br />
            
            
        </div>
    </form>
</body>
</html>
