<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarCliente.aspx.cs" Inherits="LojaDoTioWell.Adm.AdicionarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Css/EstiloSite.css" rel="stylesheet" />
<head runat="server">
  
        <title>Adicionar Cliente</title>
</head>
<body>
    <header class="main_header">

    </header>
    <form id="formAddCliente" runat="server">
        <div class="login_form" runat="server">
            <label class="Label_login" id="lblNome" title="Nome">Nome</label>
            <input type="text" runat="server" id="txtNome" class="input" placeholder="Digite o Nome do cliente aqui." />
            <label class="Label_login" id="lblEmail" title="CPF">Email</label>
            <input type="text" runat="server" id="txtEmail" class="input" placeholder="Digite o Email do cliente aqui." />
            <label class="Label_login" id="lblCelular" title="Login">Celular</label>
            <input type="text"  runat="server" id="txtCelular" class="input" placeholder="(XX) XXXXXXXXX." />
             <label class="Label_login" id="lblSaldo" title="Login">Saldo</label>
            <input type="text"  runat="server" id="txtSaldo" class="input" placeholder="Digite o Saldo inicial do cliente aqui." />
            <asp:Button text="Adicionar Cliente" runat="server" id="InserirCliente" class="submit input" Onclick="InserirCliente_Click" />  
            </div>
    </form>
</body>
</html>
