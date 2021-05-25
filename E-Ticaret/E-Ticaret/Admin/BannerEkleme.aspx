﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BannerEkleme.aspx.cs" Inherits="E_Ticaret.Admin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa-files-o"></i>Banner</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="#">Ana Sayfa</a></li>
                        <li><i class="icon_document_alt"></i>Banner</li>
                    </ol>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            Banner Ekle
                        </header>
                        <div class="panel-body">
                            <div class="form">
                                <div class="form-group ">
                                    <label for="cname" class="control-label col-lg-2">Banner <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                        <br />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-lg-offset-2 col-lg-10">
                                        <asp:Button ID="Save" OnClick="Save_Click" class="btn btn-primary" runat="server" Text="Save" />
                                    </div>
                                </div>
                                <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </section>
    </section>
</asp:Content>
