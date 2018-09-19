<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarProduto.aspx.cs" Inherits="LojaDoTioWell.Adm.EditarProduto" %>

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
                <asp:Button Text="Atualizar Produto" runat="server" ID="atualizarProduto" class="submit input" OnClick="atualizarProduto_Click" />
            </div>
        </div>
    </form>
</body>
</html>
