<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EchoWeb4._Default" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
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
    
        </asp:Content>
