<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmComboTeste.aspx.cs" Inherits="ComboTeste.frmComboTeste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.15/css/bootstrap-multiselect.css" type="text/css" />
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.15/js/bootstrap-multiselect.js"></script>

    <script type="text/javascript">
        $(function () {
            $('#ListBox1').multiselect({
                includeSelectAlloption: true
            });
        });
    </script>
    <script type="text/javascript">
        $(function () {
            $('#ListBox2').multiselect({
                includeSelectAlloption: true
            });
        });
    </script>
    <script type="text/javascript">
        $(function () {
            $('#ListBox3').multiselect({
                includeSelectAlloption: true
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div style="text-align: center">
                <h1>Multiselect Dropdown Checkbox Control</h1>
                <h2>Bootstrap|JQuery|asp.Net|C#|Sql Server</h2>
                &nbsp &nbsp
            </div>
        </div>

        <div class="container" id="Estado">
            <div style="text-align: center">
                <%--Estadual :--%>
                <asp:Label ID="lblEstadual" runat="server" Text="Estadual:"></asp:Label>
                <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>
                &nbsp &nbsp
                <%--UF:
                <asp:ListBox ID="ListBox3" runat="server" SelectionMode="Multiple"></asp:ListBox>
                Municipal :
                <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple"></asp:ListBox>--%>
            </div>
        </div>

         <div class="container" id="UF">
            <div style="text-align: center">
                &nbsp &nbsp
                <%--UF:--%>
                <asp:Label ID="lblUF" runat="server" Text="UF:"></asp:Label>
                <asp:ListBox ID="ListBox3" runat="server" SelectionMode="Multiple"></asp:ListBox>
            </div>
        </div>

        <div class="container" id="Municipio">
            <div style="text-align: center">
                &nbsp &nbsp
                <%--Municipal:--%>
                <asp:Label ID="lblMunicipio" runat="server" Text="Municipal:"></asp:Label>
                <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple"></asp:ListBox>
            </div>
        </div>

    </form>
</body>
</html>
