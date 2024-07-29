<?php

    $nome = "MURILO";

    $nome = strtolower($nome);

    if($nome == 'murilo'){
        echo "Bem vindo";
    }
    else{
        echo "Usuário não encontrado!!";
    }

    echo "<hr>";
    echo "<br>";
    echo 'De 1 a 10:';
    echo "<br>";

    for($x=1;$x<=10;$x++){
        echo $x . "<br>";
    }

    echo "<hr>";
    echo "<br>";
    echo 'Números pares até 10:';
    echo "<br>";

    for($x=1;$x<=10;$x++){
        if($x % 2 == 0){
        echo $x . "<br>";
        }
    }

    echo "<hr>";
    echo "<br>";
    echo 'Números pares até 10 (com impar):';
    echo "<br>";

    for($x=1;$x<=10;$x++){
        if($x % 2 == 0){
        echo $x . "<br>";
        }
        else{
            echo "impar <br>";
        }
    }

    echo "<hr>";
    echo "<br>";
    echo 'Números pares até 10 (com while):';
    echo "<br>";

    $a = 1;
    while($a<=10){
        echo $a . "<br>";
        $a++;
        //ou $a = $a + 1;
    }
?>