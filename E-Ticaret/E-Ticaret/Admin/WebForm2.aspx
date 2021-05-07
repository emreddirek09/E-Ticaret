﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="main-content">
                <section class="wrapper">
                    <div class="row">
                        <div class="col-lg-12">
                            <h3 class="page-header"><i class="fa fa-files-o"></i>Form Validation</h3>
                            <ol class="breadcrumb">
                                <li><i class="fa fa-home"></i><a href="#">Home</a></li>
                                <li><i class="icon_document_alt"></i>Forms</li>
                                <li><i class="fa fa-files-o"></i>Form Validation</li>
                            </ol>
                        </div>
                    </div>                  
                    <div class="row">
                        <div class="col-lg-12">
                            <section class="panel">
                                <header class="panel-heading">
                                    Form validations
                                </header>
                                <div class="panel-body">
                                    <div class="form">
                                        <form class="form-validate form-horizontal" id="feedback_form" method="get" action="" novalidate="novalidate">
                                            <div class="form-group ">
                                                <label for="cname" class="control-label col-lg-2">Full Name <span class="required">*</span></label>
                                                <div class="col-lg-10">
                                                    <input class="form-control" id="cname" name="fullname" minlength="5" type="text" required="">
                                                </div>
                                            </div>
                                            <div class="form-group ">
                                                <label for="cemail" class="control-label col-lg-2">E-Mail <span class="required">*</span></label>
                                                <div class="col-lg-10">
                                                    <input class="form-control " id="cemail" type="email" name="email" required="">
                                                </div>
                                            </div>
                                            <div class="form-group ">
                                                <label for="curl" class="control-label col-lg-2">Website</label>
                                                <div class="col-lg-10">
                                                    <input class="form-control " id="curl" type="url" name="url">
                                                </div>
                                            </div>
                                            <div class="form-group ">
                                                <label for="cname" class="control-label col-lg-2">Subject <span class="required">*</span></label>
                                                <div class="col-lg-10">
                                                    <input class="form-control" id="subject" name="subject" minlength="5" type="text" required="">
                                                </div>
                                            </div>
                                            <div class="form-group ">
                                                <label for="ccomment" class="control-label col-lg-2">Feedback</label>
                                                <div class="col-lg-10">
                                                    <textarea class="form-control " id="ccomment" name="comment" required=""></textarea>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <div class="col-lg-offset-2 col-lg-10">
                                                    <button class="btn btn-primary" type="submit">Save</button>
                                                    <button class="btn btn-default" type="button">Cancel</button>
                                                </div>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eTicaretConnectionString %>" SelectCommand="SELECT * FROM [AltKategori]"></asp:SqlDataSource>
                                            </div>
                                        </form>
                                    </div>

                                </div>
                            </section>
                        </div>
                    </div>
                </section>
            </section>
</asp:Content>