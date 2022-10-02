<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sepetListe.aspx.cs" Inherits="magaza.sepetListe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="tabloliste" runat="server" ></div>

    <div class="alert alert-success" role="alert" id="basarili" runat="server" visible="false">Silme işlemi Başarılı</div>
    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">Silme işlemi Başarısız</div>
</asp:Content>
