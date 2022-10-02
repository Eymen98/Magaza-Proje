<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sepetEkle.aspx.cs" Inherits="magaza.sepetEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 240px;
        }
        .auto-style2 {
            width: 58px;
        }

        .naf{
            margin-left:53.5rem;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h4 class="mb-4 container">Sepete Ekle</h4>
  
    <table class="w-100 container table table-dark table-bordered  table-striped">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Müşteri Adı Seçiniz"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ad" DataValueField="mno" OnDataBound="DropDownList1_DataBound">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:magazaDB %>" SelectCommand="SELECT [mno], [ad], [soyad] FROM [Musteri]"></asp:SqlDataSource>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Boş geçirilmez" ForeColor="Red" InitialValue="Lütfen Seçiniz"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Ürün Seçiniz"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="urun_adi" DataValueField="urunno" OnDataBound="DropDownList2_DataBound">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:magazaDB %>" SelectCommand="SELECT [urunno], [urun_adi] FROM [Urun]"></asp:SqlDataSource>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Boş geçirilmez" ForeColor="Red" InitialValue="Lütfen Seçiniz"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Adet Giriniz"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş geçirilmez" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Ekle" class="btn btn-primary" OnClick="Button1_Click1" />
            </td>
        </tr>
    </table>

    <br />

    <div class="d-flex justify-content-center">
        <button class="btn btn-success"><a href="sepetListe.aspx" style="text-decoration:none" class="text-white" >Listeye dön</a></button>
    </div>


    <div class="alert alert-danger" role="alert" id="basarisiz" runat="server" visible="false">Kayıt işlemi Başarısız</div>

    <div class=naf>
        <div id="liveToast" class="toast" role="alert" aria-live="assertive" aria-atomic="true" data-bs-delay="3000">
            <div class="toast-header " style="margin-left: 18.5rem">
                <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
            </div>
            <div class="toast-body fs-5 text-success">
                işlem başarıyla kaydedildi
            </div>
        </div>
    </div>
</asp:Content>
