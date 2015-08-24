<%@ Page language="c#" Codebehind="Default.aspx.cs" AutoEventWireup="false" Inherits="WebEcho._Default" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Default</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<h1>ECHO</h1>
			<h2>Host:
				<asp:Label runat="server" id="HostLabel"></asp:Label></h2>
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
		</form>
	</body>
</HTML>
