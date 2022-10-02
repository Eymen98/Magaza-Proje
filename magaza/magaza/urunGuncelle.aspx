<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="urunGuncelle.aspx.cs" Inherits="magaza.urunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }

        .naf{
            margin-left:53.5rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4 >ÜRÜNLER</h4>
    <table class="w-100 container table table-secondary table-bordered  table-striped">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Ürün No"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Ürün Adi"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Fiyat"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Miktar"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Güncelle" class="btn btn-warning" />
            </td>
        </tr>
    </table>

    <br />

    <div class="d-flex justify-content-center">
        <button class="btn btn-primary"><a href="urunListe.aspx" style="text-decoration:none" class="text-white" >Listeye dön</a></button>
    </div>

    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">Güncelleme işlemi Başarısız</div>

    <div class="naf" style="z-index: 11">
        <div id="liveToast" class="toast" role="alert" aria-live="assertive" aria-atomic="true" data-bs-delay="3000">
            <div class="toast-header " style="margin-left:18.5rem">
                <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
            </div>
            <div class="toast-body fs-5 text-success">
                işlem başarıyla güncellendi
            </div>
        </div>
    </div>

</asp:Content>
