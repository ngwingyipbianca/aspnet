<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sam2.aspx.cs" Inherits="sam2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
    <% foreach (string key in Request.Form.AllKeys)
       { %>
            <tr><td><%= key %></td>
                <td><%= Request.Form[key] %></td>
            </tr>
    <% } %>
        </table>
    </div>
    </form>
</body>
</html>
