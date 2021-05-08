<%@ Page Title="" Language="C#" MasterPageFile="~/Users/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="E_Ticaret.Users.WebForm2" %>

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
                            <asp:TextBox ID="TextBox1" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label2" runat="server" Text="Soyad"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox2" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label3" runat="server" Text="E-Posta"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox3" CssClass=" form-control" runat="server"></asp:TextBox>
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
                            <asp:TextBox ID="TextBox4" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label5" runat="server" Text="İl"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox5" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label6" runat="server" Text="İlçe"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox6" CssClass=" form-control" runat="server"></asp:TextBox>
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
                            <asp:TextBox ID="TextBox7" CssClass=" form-control" runat="server"></asp:TextBox>
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
                            <asp:TextBox ID="TextBox8" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label9" runat="server" Text="Şifre Onay"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox9" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:Button ID="Button1" CssClass="btn btn-danger" runat="server" Text="Ekle" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
