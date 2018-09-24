<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcluirCliente.aspx.cs" Inherits="LojaDoTioWell.Adm.ExcluirCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Css/EstiloSite.css" rel="stylesheet" />
<link href="Css/materialize.min.css" rel="stylesheet" />
<head runat="server">
    <script>          
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="confirm_form">
         <asp:Label runat="server" ID="txtexcluir"  class="txtExcluir"/>
            <br />
         <asp:Button text="Sim" runat="server" id="btnSim" class="submit input" OnClick="btnSim_Click" />  <asp:Button text="Não" runat="server" id="btnNao" class="submit input" OnClick="btnNao_Click" />  
        </div>
    </form>
</body>
</html>
