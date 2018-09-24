<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarPedido.aspx.cs" Inherits="LojaDoTioWell.Adm.AdicionarPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Css/EstiloSite.css" rel="stylesheet" />
<link href="Css/materialize.min.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
<head runat="server">
    <title></title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand" href="#">Loja do Tio Well</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item ">
                    <a class="nav-link" href="#">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="ConsultarCliente.aspx">Clientes</a>
                </li>
                <li class="nav-item ">
                    <a class="nav-link" href="AdicionarProduto.aspx">Produtos<span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="#">Pedidos</a>
                </li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="login_form" runat="server">
            <h3>Adicionar Pedido</h3>
            <label class="Label_login" id="lblCliente" title="">Cliente</label>
            <asp:DropDownList ID="dpCliente" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>
            <label class="Label_login" id="lblProduto" title="">Produto</label>
            <asp:DropDownList ID="dpProduto" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>
             <label class="Label_login" id="lblQuantidade" title="">Quantidade do Produto</label>
            <asp:TextBox id="txtQuantidade" runat="server"></asp:TextBox>
            <asp:Button Text="Adicionar Item" runat="server" ID="inserirPedido" class="submit input" OnClick="inserirPedido_Click" />
        </div>
    </form>
   <div class="table_div">
            <h3>Items do Pedido</h3>
            <table>
                <%-- class="bordered striped centered"--%>
                <thead>
                    <tr>
                        <th>Código do Pedido</th>
                        <th>Descrição do Produto</th>
                        <th>Quantidade</th>
                        <th>Valor Unitário</th>
                        <th>Opções</th>
                    </tr>
                </thead>
                <tbody id="resultadoClientes" runat="server">
                </tbody>
                <tr>
                        <th>Total</th>
                        <th>  </th>
                        <th></th>
                        <th id="resultadoTotal" runat="server"> </th>
                        <th></th>
                </tr>
            </table>
       
            <%--<asp:Button Text="Fazer novo Pedido" runat="server" ID="btnPedido" class="submit input" runat="server" />--%>
        </div>
</body>
</html>
