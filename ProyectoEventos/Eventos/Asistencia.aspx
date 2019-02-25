<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="Eventos.Asistencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">

            <div class="col-lg-6 offset-lg-3">
                <div class="col-lg-6">
                    <div class="wrapper">
                        
                        <h2 class="form-signin-heading">Marcar Asistencia</h2>
                        <div class="container col-lg-12">
                            <div class="row">
                                <div>
                                    <asp:TextBox CssClass="form-control" ID="txtCedula" Required="true" placeholder="Cédula" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <asp:Button OnClick="btnBuscarUsuarioPadron_Click" CssClass="btn btn-lg btn-primary btn-block" ID="btnBuscarUsuarioPadron" runat="server" Text="Buscar Usuario" />
                            </div>
                            <div class="row">
                                <div>
                                    <asp:TextBox CssClass="form-control" ID="txtidEvento" placeholder="Evento" runat="server" Enabled="false"></asp:TextBox>
                                </div>
                            </div>
                            
                            <div class="row">
                                <asp:TextBox CssClass="form-control" ID="TxtUsuarioRegistra" placeholder="Nombre" runat="server" Enabled="false"></asp:TextBox>
                            </div>
                            <div class="row">
                                <asp:TextBox CssClass="form-control" ID="TxtFechaRegistra" placeholder="Fecha del Registro" runat="server" Enabled="false"></asp:TextBox>
                            </div>
                            <div class="row">
                                <asp:DropDownList ID="ddlEstado" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="Presente">Presente</asp:ListItem>
                                    <asp:ListItem Value="Ausente">Ausente</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="row">
                                <asp:Button OnClick="btnCrearAsistencia_Click" CssClass="btn btn-lg btn-primary btn-block" ID="btnCrearAsistencia" runat="server" Text="Crear Asistencia" />
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
                            <asp:GridView ID="gvAsistencias" runat="server"
                                CellPadding="4"
                                AllowPaging="true"
                                PageSize="10"
                             
                                EnableModelValidation="True" BackColor="White"
                                BorderColor="#000" BorderStyle="Solid"
                                BorderWidth="1px" GridLines="None"
                                CssClass="table table-condensed table-pedido"
                                AutoGenerateColumns="false"
                                
                                DataKeyNames="">

                                <AlternatingRowStyle BackColor="White" />
                                <Columns>

                                    <asp:BoundField HeaderText="id" DataField="id" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="idEvento" DataField="idEvento" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="idUsuario" DataField="idUsuario" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Usuario Registra" DataField="UsuarioRegistra" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Fecha Registra" DataField="FechaRegistra" ReadOnly="true"></asp:BoundField>
                                    <asp:BoundField HeaderText="Estado" DataField="Estado" ReadOnly="true"></asp:BoundField>


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
