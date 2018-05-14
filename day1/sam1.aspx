<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sam1.aspx.cs" Inherits="sam1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
    <% foreach (string key in Request.QueryString.AllKeys)
       { %>
            <tr><td><%= key %></td>
                <td><%= Request.QueryString[key] %></td>
            </tr>
    <% } %>
        </table>
    </div>
    </form>
</body>
</html>
