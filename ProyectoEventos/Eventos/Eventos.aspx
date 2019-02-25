<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="Eventos.Eventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-top:50px;">
        
        <div class="row">

            <div class="col-lg-6 offset-lg-3">
                <div class="col-lg-12">    
                    <div class="row">
                        <label>Nombre del Evento</label>
                        <asp:TextBox ID="txtNombreEvento" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <label>Fecha</label>
                        <asp:TextBox ID="txtFecha" CssClass="form-control " runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <label for="inputState">Estado</label>
                        <asp:DropDownList ID="ddlEstado" CssClass="form-control" runat="server">
                            <asp:ListItem Value="A">Activo</asp:ListItem>
                            <asp:ListItem Value="I">Inactivo</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="row">
                        <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-dark" runat="server" Text="Guardar" />
                        <asp:Button ID="btnEditar" Visible="false" OnClick="btnEditar_Click" CssClass="btn btn-dark" runat="server" Text="Editar" />
                        <asp:Button ID="btnLimpiar" Visible="false" OnClick="btnLimpiar_Click" CssClass="btn btn-dark" runat="server" Text="Limpiar" />
                    </div>
                    
                </div>
            </div>

        </div>

        <div class="row">
            <div class="col-lg-6 offset-lg-3">
                <div class="col-lg-12">
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gvEventos" runat="server"
                                CellPadding="4"
                                AllowPaging="true"
                                PageSize="10"
                                OnPageIndexChanging="gvEventos_PageIndexChanging"
                                EnableModelValidation="True" BackColor="White"
                                BorderColor="#000" BorderStyle="Solid"
                                BorderWidth="1px" GridLines="None"
                                CssClass="table table-condensed table-pedido"
                                AutoGenerateColumns="false"
                                OnSelectedIndexChanging="gvEventos_SelectedIndexChanging"
                                DataKeyNames="id,Nombre,Fecha,Estado">

                                <AlternatingRowStyle BackColor="White" />
                                <Columns>

                                    <asp:BoundField HeaderText="Número de Evento" DataField="id" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Fecha del Evento" DataField="Fecha" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Estado" DataField="Estado" ReadOnly="true"></asp:BoundField>

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

    

</asp:Content>
