<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CalcuNET._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="css/style.css" />

    <title>Calculadora</title>
    <style type="text/css">
        .auto-style1 {
            width: 437px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Titulo">
            <asp:Label ID="LabelTitulo" CssClass="fuente" runat="server" Text="Calculadora"></asp:Label>
        </div>
        <div id="Calculadora">
            <table class="estiloTabla1">
                 <tr>
                      <td class="auto-style1">
                          <asp:TextBox CssClass="estiloTextbox1 fuente alinearDerecha" ID="TextBox1" Width="459px" runat="server"></asp:TextBox></td>
                 </tr>
                </table>
             <table class="estiloTabla">
                 <tr>
                       <td class="">
                          <asp:Button ID="ButtonPorcentaje" CssClass="button fuente2" runat="server" Text="%" OnClick="ButtonPorcentaje_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonCE" CssClass="button fuente2" runat="server" Text="CE" OnClick="ButtonCE_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonC" CssClass="button fuente2" runat="server" Text="C" OnClick="ButtonC_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonBorrar" CssClass="button fuente2 " runat="server" Text="<=" OnClick="ButtonBorrar_Click" />
                      </td >
                 </tr>
                 <tr>
                    <td class="">
                          <asp:Button ID="ButtonFrac" CssClass="button fuente2" runat="server" Text="1/X" OnClick="ButtonFrac_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonPotencia" CssClass="button fuente2" runat="server" Text="x^2" OnClick="ButtonPotencia_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonRaiz" CssClass="button fuente2" runat="server" Text="√x" OnClick="ButtonRaiz_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonDividir" CssClass="button fuente2" runat="server" Text="/" OnClick="ButtonDividir_Click" />
                      </td >
                 </tr>
                 <tr>
                     <td class="">
                          <asp:Button ID="Button7" CssClass="button fuente2" runat="server" Text="7" OnClick="Button7_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button8" CssClass="button fuente2" runat="server" Text="8" OnClick="Button8_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button9" CssClass="button fuente2" runat="server" Text="9" OnClick="Button9_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonMultiplicacion" CssClass="button fuente2" runat="server" Text="*" OnClick="ButtonMultiplicacion_Click" />
                      </td >
                 </tr>
                 <tr>
                    <td class="">
                          <asp:Button ID="Button4" CssClass="button fuente2" runat="server" Text="4" OnClick="Button4_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button5" CssClass="button fuente2" runat="server" Text="5" OnClick="Button5_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button6" CssClass="button fuente2" runat="server" Text="6" OnClick="Button6_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonResta" CssClass="button fuente2" runat="server" Text="-" OnClick="ButtonResta_Click" />
                      </td >
                 </tr>
                 <tr>
                     <td class="">
                          <asp:Button ID="Button1" CssClass="button fuente2" runat="server" Text="1" OnClick="Button1_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button2" CssClass="button fuente2" runat="server" Text="2" OnClick="Button2_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button3" CssClass="button fuente2" runat="server" Text="3" OnClick="Button3_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonSuma" CssClass="button fuente2" runat="server" Text="+" OnClick="ButtonSuma_Click" />
                      </td >
                 </tr>
                   <tr>
                     <td class="">
                          <asp:Button ID="ButtonMM" CssClass="button fuente2" runat="server" Text="+/-" OnClick="ButtonMM_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="Button0" CssClass="button fuente2" runat="server" Text="0" OnClick="Button0_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonPunto" CssClass="button fuente2" runat="server" Text="." OnClick="ButtonPunto_Click" />
                      </td >
                       <td class="">
                          <asp:Button ID="ButtonResult" CssClass="button fuente2" runat="server" Text="=" OnClick="ButtonResult_Click" />
                      </td >
                 </tr>
             </table>
        </div>
    
    </form>
</body>
</html>
