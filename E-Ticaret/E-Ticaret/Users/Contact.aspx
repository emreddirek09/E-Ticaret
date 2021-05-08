<%@ Page Title="" Language="C#" MasterPageFile="~/Users/User.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="E_Ticaret.Users.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="contact spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="contact__content">
                        <div class="contact__address text-center">
                            <h5>İletİşİm İçİn</h5>
                            <ul>
                                <li>
                                    <h6><i class="fa fa-map-marker"></i>Adres</h6>
                                    <p>160 Pennsylvania Ave NW, Washington, Castle, PA 16101-5161</p>
                                </li>
                                <li>
                                    <h6><i class="fa fa-phone"></i>Telefon</h6>
                                    <p><span>125-711-811</span><span>125-668-886</span></p>
                                </li>
                                <li>
                                    <h6><i class="fa fa-headphones"></i>E-Posta</h6>
                                    <p>Support.photography@gmail.com</p>
                                </li>
                            </ul>
                        </div>
                        <div class="contact__form">
                            <form action="#">
                            </form>
                        </div>
                        <div class="contact__form">
                            <h5>Mesaj Gönderin</h5>
                            <form action="#">
                                <input type="text" placeholder="İsim">
                                <input type="text" placeholder="Email">
                                <textarea placeholder="Mesajınız"></textarea>
                                <button type="submit" class="site-btn">Gönder</button>
                            </form>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
