<%@ Page Title="" Language="C#" MasterPageFile="~/Users/User.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="E_Ticaret.Users.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="categories">
        <div class="container-fluid">
            <div class="row">

                <div class="col-lg-6">
                    <div class="row">
                        <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                            <div class="categories__item set-bg" data-setbg="img/categories/category-2.jpg" style="background-image: url(&quot;img/categories/category-2.jpg&quot;);">
                                <%--<div class="categories__text">
                                    <h4>Men’s fashion</h4>
                                    <p>358 items</p>
                                    <a href="#">Shop now</a>
                                </div>--%>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                            <div class="categories__item set-bg" data-setbg="img/categories/category-3.jpg" style="background-image: url(&quot;img/categories/category-3.jpg&quot;);">
                                <%--<div class="categories__text">
                                    <h4>Kid’s fashion</h4>
                                    <p>273 items</p>
                                    <a href="#">Shop now</a>
                                </div>--%>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                            <div class="categories__item set-bg" data-setbg="img/categories/category-4.jpg" style="background-image: url(&quot;img/categories/category-4.jpg&quot;);">
                                <%--<div class="categories__text">
                                    <h4>Cosmetics</h4>
                                    <p>159 items</p>
                                    <a href="#">Shop now</a>
                                </div>--%>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                            <div class="categories__item set-bg" data-setbg="img/categories/category-5.jpg" style="background-image: url(&quot;img/categories/category-5.jpg&quot;);">
                                <%--<div class="categories__text">
                                    <h4>Accessories</h4>
                                    <p>792 items</p>
                                    <a href="#">Shop now</a>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6 p-0">
                    <div class="categories__item categories__large__item set-bg" data-setbg="img/categories/category-1.jpg" style="background-image: url(&quot;img/categories/category-1.jpg&quot;);">
                        <%--<div class="categories__text">
                            <h1>Women’s fashion</h1>
                            <p>
                                Sitamet, consectetur adipiscing elit, sed do eiusmod tempor incidid-unt labore
                        edolore magna aliquapendisse ultrices gravida.
                            </p>
                            <a href="#">Shop now</a>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="banner set-bg" data-setbg="img/banner/banner-1.jpg" style="background-image: url(&quot;img/banner/banner-1.jpg&quot;);">
        <div class="container">
            <div class="row">
                <div class="col-xl-7 col-lg-8 m-auto">
                    <div class="banner__slider owl-carousel owl-loaded owl-drag">

                    </div>
                </div>
            </div>
        </div>
    </section>
    <br />
    <section class="services spad">
    <div class="container">
        <div class="row">
            <div class="col-lg-3 col-md-4 col-sm-6">
                <div class="services__item">
                    <i class="fa fa-car"></i>
                    <h6>Free Shipping</h6>
                    <p>For all oder over $99</p>
                </div>
            </div>
            <div class="col-lg-3 col-md-4 col-sm-6">
                <div class="services__item">
                    <i class="fa fa-money"></i>
                    <h6>Money Back Guarantee</h6>
                    <p>If good have Problems</p>
                </div>
            </div>
            <div class="col-lg-3 col-md-4 col-sm-6">
                <div class="services__item">
                    <i class="fa fa-support"></i>
                    <h6>Online Support 24/7</h6>
                    <p>Dedicated support</p>
                </div>
            </div>
            <div class="col-lg-3 col-md-4 col-sm-6">
                <div class="services__item">
                    <i class="fa fa-headphones"></i>
                    <h6>Payment Secure</h6>
                    <p>100% secure payment</p>
                </div>
            </div>
        </div>
    </div>
</section>
</asp:Content>
