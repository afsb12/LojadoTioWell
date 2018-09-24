<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarProduto.aspx.cs" Inherits="LojaDoTioWell.Adm.AdicionarProduto" %>

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
                <li class="nav-item active">
                    <a class="nav-link" href="#">Produtos<span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="">Pedidos</a>
                </li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">           
            <div class="login_form" runat="server">
                <h3>Adicionar Produto</h3>
                <label class="Label_login" id="lblDescricaoProd" title="Descricao">Descrição</label>
                <input type="text" runat="server" id="txtDescricao" class="input" placeholder="Digite a Descrição do produto aqui." />
                <label class="Label_login" id="lblValorUnitario" title="Valor Unitario">Valor Unitario</label>
                <input type="text" runat="server" id="txtValorUnitario" class="input" placeholder="Digite o Valor Unitário do produto aqui." />
                <asp:Button Text="Adicionar Produto" runat="server" ID="InserirProduto" class="submit input" OnClick="InserirProduto_Click" />
            </div>
        </div>

        <div class="table_div">
            <h3>Consulta de Clientes</h3>
            <table>
                <thead>
                    <tr>
                        <th>Código do Produto </th>
                        <th>Descrição</th>
                        <th>Valor Unitário </th>
                        <th>Opções </th>
                    </tr>
                </thead>
                <tbody id="resultadoProdutos" runat="server">
                </tbody>
            </table>

        </div>
    </form>
</body>
</html>
