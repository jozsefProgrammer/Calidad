<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="MantenimientoUsuarios.aspx.cs" Inherits="Eventos.MantenimientoUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">

            <div class="col-lg-6 offset-lg-3">
                <div class="col-lg-6">
                    <div class="wrapper">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <h2 class="form-signin-heading">Crear Usuario</h2>
                        <div class="container col-lg-12">
                            <div class="row">
                                <div>
                                    <asp:TextBox CssClass="form-control" ID="txtCedula" placeholder="Cédula" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <asp:TextBox CssClass="form-control" ID="TxtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
                            </div>
                            <div class="row">
                                <asp:TextBox CssClass="form-control" ID="TxtContrasenna" placeholder="Contraseña" TextMode="Password" runat="server"></asp:TextBox>
                            </div>
                            <div class="row">
                                <asp:DropDownList ID="ddlTipoUsuario" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="1">Administrador</asp:ListItem>
                                    <asp:ListItem Value="2">Registrador</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="row">
                                <asp:DropDownList ID="ddlEstado" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="1">Activo</asp:ListItem>
                                    <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="row">
                                <asp:Button OnClick="btnCrearUsuario_Click" CssClass="btn btn-lg btn-primary btn-block" ID="btnCrearUsuario" runat="server" Text="Crear Usuario" />
                            </div>
                            <div class="row">
                                <asp:Button OnClick="btnActualizar_Click" CssClass="btn btn-lg btn-primary btn-block" ID="btnActualizar" runat="server" Visible="false" Text="Actualizar Usuario" />
                            </div>
                            <div class="row">
                                <asp:Button OnClick="btnLimpiar_Click" CssClass="btn btn-lg btn-primary btn-block" ID="btnLimpiar" runat="server" Text="Limpiar" />
                            </div>
                            <div class="alert alert-danger" runat="server" style="display: none;" id="error" role="alert">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
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

                                    <asp:BoundField HeaderText="Cédula" DataField="id" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Perfil" DataField="idPerfil" ReadOnly="true"></asp:BoundField>
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
