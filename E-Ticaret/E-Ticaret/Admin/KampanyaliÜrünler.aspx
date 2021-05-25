<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KampanyaliÜrünler.aspx.cs" Inherits="E_Ticaret.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <h3 class="page-header"><i class="fa fa-files-o"></i>Kampanyalı Ürünler</h3>
                    <ol class="breadcrumb">
                        <li><i class="fa fa-home"></i><a href="#">Ana Sayfa</a></li>
                        <li><i class="icon_document_alt"></i>Kategori</li>
                    </ol>
                </div>
            </div>
             <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            Katagori
                        </header>
                        <div class="panel-body">
                            <div class="form">
                                <div class="form-group ">
                                    <label for="cname" class="control-label col-lg-2">Kampanya Adı <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <input class="form-control" runat="server" id="txt_KampanyaAdi" type="text"><br />
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="cname" class="control-label col-lg-2">Kampanya Banner <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <asp:FileUpload ID="FileUploadBanner" CssClass="form-control" runat="server" />
                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                        <br />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-lg-offset-2 col-lg-10">
                                        <asp:Button ID="ekle" class="btn btn-primary" OnClick="ekle_Click" runat="server" Text="Banner Ekle" />                                        
                                    </div>
                                </div>
                                <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            Kampanyalı Ürün Ekleme
                        </header>
                        <div class="panel-body">
                            <div class="form">
                                <div class="form-group ">
                                    <label for="cname" class="control-label col-lg-2">Banner Seç <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="-1">Seçiniz.</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="cname" class="control-label col-lg-2">Ürün Adı <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <input class="form-control" runat="server" id="txt_ürün_adi" name="fullname" type="text" >
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="cemail" class="control-label col-lg-2">Fiyatı <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <input class="form-control" runat="server" id="txt_fiyat">
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="curl" class="control-label col-lg-2">Beden</label>
                                    <div class="col-lg-10">
                                        <input class="form-control" runat="server" id="txt_beden">
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="cname" class="control-label col-lg-2">Adet <span class="required">*</span></label>
                                    <div class="col-lg-10">
                                        <input class="form-control" runat="server" id="txt_adet" type="text">
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="ccomment" class="control-label col-lg-2">Açıklama</label>
                                    <div class="col-lg-10">
                                        <textarea class="form-control " runat="server" id="txt_aciklama" ></textarea>
                                    </div>
                                </div>
                                <div class="form-group ">
                                    <label for="ccomment" class="control-label col-lg-2">Resim</label>
                                    <div class="col-lg-10">
                                        <asp:FileUpload ID="FileUpload1" runat="server" />
                                        <asp:HiddenField ID="HiddenField2" runat="server" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-lg-offset-2 col-lg-10">
                                        <asp:Button ID="UrunKaydet" class="btn btn-primary" OnClick="UrunKaydet_Click" runat="server" Text="Ürün Kaydet" />                                     
                                    </div>                                   
                                </div>
                                <asp:Label ID="Label2" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </section>
    </section>
</asp:Content>
