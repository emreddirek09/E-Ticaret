<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Users/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="E_Ticaret.Users.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="checkout spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h6 class="coupon__link"><span class=" fa fa-user"></span>Kişisel Bilgileriniz</h6>
                </div>
            </div>
            <div style="background-color: aliceblue" class="row">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label1" runat="server" Text="İsim"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_İsim" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label2" runat="server" Text="Soyad"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TxtSoyad" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label3" runat="server" Text="E-Posta"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_mail" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>

                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h6 class="coupon__link"><span class=" fa fa-user"></span>Adres Bilgisi</h6>
                </div>
            </div>
            <div style="background-color: aliceblue" class="row">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label4" runat="server" Text="Adres"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_Adres" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label5" runat="server" Text="İl"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_İl" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label6" runat="server" Text="İlçe"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_İlce" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>

                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h6 class="coupon__link"><span class=" fa fa-user"></span>İletişim Bilgileriniz</h6>
                </div>
            </div>
            <div style="background-color: aliceblue" class="row">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label7" runat="server" Text="Telefon"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_Telefon" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h6 class="coupon__link"><span class=" fa fa-user"></span>Şifre Bilgileriniz</h6>
                </div>
            </div>
            <div style="background-color: aliceblue" class="row">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label8" runat="server" Text="Şifre"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_sifre" type="password" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label9" runat="server" Text="Şifre Onay"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="Txt_sifreOnay" type="password" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:Button ID="Button1" OnClientClick="BasariDurumu(); return false" OnClick="Button1_Click" runat="server" Text="Button" />                  
                </div>
                <asp:Label ID="uyari" runat="server" ForeColor="#CC0000"></asp:Label>
            </div>
        </div>
    </section>    
    <asp:ScriptManager ID="ScriptManager1" EnablePageMethods="true" runat="server"></asp:ScriptManager>
    <script type="text/javascript">
        function BasariDurumu()
        PageMethds.Getir(islemBasarili, islemHatali);
        function islemBasarili(sonuc) {
            alert("İşlem Başarılı");
        }
        function islemHatali(sonuc) {
            alert("Bir Hata Oluştu");
        }
    </script>
</asp:Content>
