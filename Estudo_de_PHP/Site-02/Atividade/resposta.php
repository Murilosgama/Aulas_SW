<?php
    $nome = $_POST['nome'];
    $senha = $_POST['senha'];

    if($nome == 'BardellaDoGrau' && $senha == 'senha0102'){
        echo "Conta VALIDADA!!";
    }
    else{
        echo "Usuário INVALIDO!!";
    }

?>