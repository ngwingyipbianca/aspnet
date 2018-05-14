<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/images/singapore-map.jpg">
              <asp:CircleHotSpot AlternateText="CCK" 
     HotSpotMode="Navigate" NavigateUrl="cck.html" 
     X="68" Y="102"
     Radius="30" />
  <asp:RectangleHotSpot AlternateText="Central" 
     HotSpotMode="Navigate" NavigateUrl="central.html"
     Left="146" Bottom="145" Right="233" Top="72" />
  <asp:PolygonHotSpot AlternateText="City" 
     HotSpotMode="Navigate" NavigateUrl="city.html"
     Coordinates="194,174,244,183,204,219,168,184" />

        </asp:ImageMap>
    </div>
    </form>
</body>
</html>
