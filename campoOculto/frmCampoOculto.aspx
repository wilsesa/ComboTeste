<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCampoOculto.aspx.cs" Inherits="campoOculto.frmCampoOculto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.15/css/bootstrap-multiselect.css" type="text/css" />
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.15/js/bootstrap-multiselect.js"></script>--%>

    <%--<script src="jquery-2.1.4.min.js"></script>--%>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="JavaScript.js"></script>
    <link href="StyleSheet.css" rel="stylesheet" />

    <%--<script type="text/javascript">
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
    </script>--%>
</head>
<body>
    <div class="container">
        <div style="text-align: center">
            <h1>Campos Ocultos</h1>
        </div>
    </div>

    <select id='select' name='select'>
        <option value="">--Seleccione--</option>
        <option value='div1'>Div 1</option>
        <option value='div2'>Div 2</option>
        <option value='div3'>Div 3</option>
    </select>

    <div id="pai">
        <div id="div1">
            Qualquer texto........
        </div>

        <div id="div2">
            <img src="Img/paris.jpg" alt="Paris" />
        </div>
        &nbsp &nbsp

        <div id="div3">
        Nome:
        <input type="text" id="form"></input>
        </div>
    </div>

</body>
</html>
