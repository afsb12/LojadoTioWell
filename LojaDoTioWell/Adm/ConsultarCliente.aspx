<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarCliente.aspx.cs" Inherits="LojaDoTioWell.Adm.ConsultaCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Css/materialize.min.css" rel="stylesheet" />
<link href="Css/EstiloSite.css" rel="stylesheet" />

   
<head runat="server">
    <script>
       
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="table_div">
            <h3>Consulta de Clientes</h3>
                <table><%-- class="bordered striped centered"--%>
                <thead>
                    <tr>
                        <th>Nome Completo</th>
                        <th>CPF</th>
                        <th>Login</th>
                        <th>Data</th>
                        <th>Opções</th>
                    </tr>
                </thead>
                <tbody id="resultadoClientes" runat="server" >   

                </tbody>
            </table>
             <asp:Button text="Adicionar Cliente" runat="server" id="AdcionarCliente" class="submit input" Onclick="AdcionarCliente_Click" />  
        </div>
    </form>
</body>
</html>
