<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EchoWeb2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>ECHO</h1>
    
        <h2>Host: <asp:Label runat="server" id="HostLabel"></asp:Label></h2>
        
        <h2>Request - Misc</h2>
        <ul>
            <asp:Label runat="server" id="RequestMiscLabel"></asp:Label>
        </ul>
    
        <h2>Request - Server Variable</h2>
        <ul>
            <asp:Label runat="server" id="ServerVariablesLabel"></asp:Label>
        </ul>

        <h2>Request - Headers</h2>
        <ul>
            <asp:Label runat="server" id="HeadersLabel"></asp:Label>
        </ul>
    
        <h2>Request - Form Values
        </h2>
        <ul>
            <asp:Label runat="server" id="FormValuesLabel"></asp:Label>
        </ul>
    
        <h2>Request - Cookies Values
        </h2>
        <ul>
            <asp:Label runat="server" id="CookiesLabel"></asp:Label>
        </ul>

    </div>
    </form>
</body>
</html>
