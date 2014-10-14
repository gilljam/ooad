<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScreenScraper.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="OrgNoTextBox" type="text" runat="server"  /> 
        <asp:Button ID="SearchButton" runat="server" Text="Sök på AllaBolag.se" OnClick="SearchButton_Click" />
    </div>
        <div id="ResponseDiv" runat="server"></div>
    </form>
</body>
</html>
