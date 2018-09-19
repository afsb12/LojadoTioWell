<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarProduto.aspx.cs" Inherits="LojaDoTioWell.Adm.AdicionarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Css/EstiloSite.css" rel="stylesheet" />
<link href="Css/materialize.min.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="login_form" runat="server">
            <label class="Label_login" id="lblDescricaoProd" title="Descricao">Descrição</label>
            <input type="text" runat="server" id="txtDescricao" class="input" placeholder="Digite a Descrição do produto aqui." />
            <label class="Label_login" id="lblValorUnitario" title="Valor Unitario">Valor Unitario</label>
            <input type="text" runat="server" id="txtValorUnitario" class="input" placeholder="Digite o Valor Unitário do produto aqui." />
            <asp:Button text="Adicionar Produto" runat="server" id="InserirProduto" class="submit input" OnClick="InserirProduto_Click" />  
            </div>
        </div>

         <div class ="table_div">
            <h3>Consulta de Clientes</h3>
            <table class = "bordered striped centered">
                <thead>
                    <tr>
                        <th>Código do Produto </th>
                        <th> Descrição</th>
                        <th> Valor Unitário </th>
                        <th> Opções </th>
                    </tr>
                </thead>
                <tbody id="resultadoProdutos" runat="server" >   
                </tbody>
            </table>

        </div>
    </form>
</body>
</html>
