<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcluirProduto.aspx.cs" Inherits="LojaDoTioWell.Adm.ExcluirProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:Label runat="server" ID="txtexcluir"  class="txtExcluir"/>
            <br />
         <asp:Button text="Sim" runat="server" id="btnSim" class="submit input" OnClick="btnSim_Click" />  <asp:Button text="Não" runat="server" id="btnNao" class="submit input" OnClick="btnNao_Click" />  
        </div>
    </form>
</body>
</html>
