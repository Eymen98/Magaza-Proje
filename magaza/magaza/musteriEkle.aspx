﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="musteriEkle.aspx.cs" Inherits="magaza.musteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 207px;
        }
        .auto-style2 {
            width: 43px;
        }

         .naf{
            margin-left:53.5rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="container">MÜŞTERİLER</h4>
    <table class="w-100 container table table-success table-bordered table-striped">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Müşteri No"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Müşterinin Adi"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Müşterinin Soyadı"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Doğum Tarihi"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="Cep Telefon"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" placeholder="05555555555" TextMode="Phone"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Boş geçirilmez" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="girildiği telefon numarası geçerli değil" ForeColor="Red" ValidationExpression="0\d{3}\d{3}\d{2}\d{2}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" class="btn btn-warning" />
            </td>
        </tr>
    </table>

    <br />

    <div class="d-flex justify-content-center">
        <button class="btn btn-primary"><a href="musteriListe.aspx" style="text-decoration:none" class="text-white" >Listeye dön</a></button>
    </div>
    
    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">Kayıt işlemi Başarısız</div>

    <div class="naf" >
        <div id="liveToast" class="toast" role="alert" aria-live="assertive" aria-atomic="true" data-bs-delay="3000">
            <div class="toast-header " style="margin-left:18.5rem">
                <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
            </div>
            <div class="toast-body fs-5 text-success">
                işlem başarıyla kaydedildi
            </div>
        </div>
    </div>

</asp:Content>
