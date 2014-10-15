<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScreenScraper.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="SearchDropDown" runat="server"><asp:ListItem Text="Allabolag.se" Value="Allabolag.se"></asp:ListItem>
            <asp:ListItem Text="Eniro.se" Value="Eniro.se"></asp:ListItem></asp:DropDownList>
        <input id="OrgNoTextBox" type="text" runat="server"  /> 
        <asp:Button ID="SearchButton" runat="server" Text="Sök" OnClick="SearchButton_Click" />
    </div>
        <div id="ResponseDiv" runat="server"></div>
    </form>
</body>
</html>
