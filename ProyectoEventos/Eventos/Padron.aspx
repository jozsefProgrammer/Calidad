<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Padron.aspx.cs" Inherits="Eventos.Padron" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="padding-top:50px;">

        <div class="row">
            <div class="col-lg-12 ">
                <div class="col-lg-12">
                    <div>
                        <asp:DropDownList ID="ddlEvento" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                    <div class="row">
                        <ajaxToolkit:AjaxFileUpload ID="afuExcel" CssClass="" Width="300" AllowedFileTypes="xls,xlsx" MaximumNumberOfFiles="1" runat="server" ThrobberID="MyThrobber" OnUploadComplete="afuExcel_UploadComplete"/>
                    </div>
                    <div class="row">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-dark" runat="server" Text="Guardar" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>

                <div class="col-lg-12">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gvPadron" runat="server"
                                CellPadding="4"
                                AllowPaging="true"
                                PageSize="10"
                                OnPageIndexChanging="gvPadron_PageIndexChanging"
                                EnableModelValidation="True" BackColor="White"
                                BorderColor="#000" BorderStyle="Solid"
                                BorderWidth="1px" GridLines="None"
                                CssClass="table table-condensed table-pedido"
                                AutoGenerateColumns="false"
                                OnSelectedIndexChanging="gvPadron_SelectedIndexChanging"
                                DataKeyNames="">

                                <AlternatingRowStyle BackColor="White" />
                                <Columns>

                                    <asp:BoundField HeaderText="ID" DataField="id" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Evento" DataField="idEvento" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Cedula" DataField="Cedula" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Estatus" DataField="Estatus1" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Estado" DataField="Estado2" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Correo" DataField="Correo" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Telefono" DataField="Telefono" ReadOnly="true"></asp:BoundField>
                                    

                                </Columns>
                                <HeaderStyle BackColor="#000" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                <PagerStyle CssClass="pagination-ys" HorizontalAlign="Center" />
                                <RowStyle BackColor="White" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                            </asp:GridView>
                        </div>
                    </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    
                </div>
            </div>
        </div>

    </div>

</asp:Content>
