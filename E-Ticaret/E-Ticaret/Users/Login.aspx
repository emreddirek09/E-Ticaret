<%@ Page Title="" Language="C#" MasterPageFile="~/Users/User.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_Ticaret.Users.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="checkout spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h6 class="coupon__link"><span class=" fa fa-user"></span>Giriş</h6>
                </div>
            </div>
            <div style="background-color: aliceblue" class="row">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label1" runat="server" Text="E-Posta"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox1" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2 col-sm-2">
                            <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
                        </div>
                        <div class="col-lg-10 col-md-10 col-sm-10">
                            <asp:TextBox ID="TextBox2" CssClass=" form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:Button ID="Button1" CssClass="btn-danger" runat="server" Text="Giriş" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
