<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Padrones.aspx.cs" Inherits="Eventos.Padrones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">

            <div class="col-lg-6 offset-lg-3">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-6 offset-lg-3">
                            <div class="col-lg-12">
                                <div class="row">
                                    <div class="table-responsive">
                                        <asp:GridView ID="gvUsuarios" runat="server"
                                            CellPadding="4"
                                            AllowPaging="true"
                                            PageSize="10"
                                            OnPageIndexChanging="gvUsuarios_PageIndexChanging"
                                            EnableModelValidation="True" BackColor="White"
                                            BorderColor="#000" BorderStyle="Solid"
                                            BorderWidth="1px" GridLines="None"
                                            CssClass="table table-condensed table-pedido"
                                            AutoGenerateColumns="false"
                                            OnSelectedIndexChanging="gvUsuarios_SelectedIndexChanging"
                                            OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged"
                                            DataKeyNames="">

                                            <AlternatingRowStyle BackColor="White" />
                                            <Columns>

                                                <asp:BoundField HeaderText="id" DataField="id" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Nombre" DataField="Nombre" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Cédula" DataField="Cedula" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Estatus1" DataField="Estatus1" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Estado2" DataField="Estado2" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Correo" DataField="Correo" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Teléfono" DataField="Telefono" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField HeaderText="Evento" DataField="idEvento" ReadOnly="true"></asp:BoundField>

                                                <asp:CommandField ShowSelectButton="true" SelectText="<span class='glyphicon glyphicon-pencil'></span> Editar" ControlStyle-CssClass="btn btn-primary btn-sm input-sm" ControlStyle-ForeColor="White" />

                                            </Columns>
                                            <HeaderStyle BackColor="#000" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                            <PagerStyle CssClass="pagination-ys" HorizontalAlign="Center" />
                                            <RowStyle BackColor="White" ForeColor="#333333" />
                                            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
