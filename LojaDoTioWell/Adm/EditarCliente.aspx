<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="LojaDoTioWell.Adm.EditaCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Css/EstiloSite.css" rel="stylesheet" />
<link href="Css/materialize.min.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div class="login_form" runat="server">
            <label class="Label_login" id="lblNome" title="Nome">Nome</label>
            <input type="text" runat="server" id="txtNome" class="input" placeholder="Digite o Nome do cliente aqui." />
            <label class="Label_login" id="lblEmail" title="CPF">Email</label>
            <input type="text" runat="server" id="txtEmail" class="input" placeholder="Digite o Email do cliente aqui." />
            <label class="Label_login" id="lblCelular" title="Login">Celular</label>
            <input type="text"  runat="server" id="txtCelular" class="input" placeholder="(XX) XXXXXXXXX." />
             <label class="Label_login" id="lblSaldo" title="Login">Saldo</label>
            <input type="text"  runat="server" id="txtSaldo" class="input" placeholder="Digite o Saldo inicial do cliente aqui." />
            <asp:Button text="Atualizar Cliente" runat="server" id="AtualizarCliente" class="submit input" OnClick="AtualizarCliente_Click" />  
            </div>
    </form>
</body>
</html>
