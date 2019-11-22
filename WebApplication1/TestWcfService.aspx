<%@ Page Title="TestWcfService" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestWcfService.aspx.cs" Inherits="WebApplication1.About" %>
          

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <input type="button" value="测试" onclick="GetData()"/>  
    
</asp:Content>
