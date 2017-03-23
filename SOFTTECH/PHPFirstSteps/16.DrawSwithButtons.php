<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
    <?php
    $button0 = "<button>0</button>";
    $button1 = "<button style='background-color: blue'>1</button>";

    for ($i = 0; $i < 5; $i++) {
        echo $button1;
    }
    echo "<br />";

    for ($i = 0; $i < 3; $i++) {
        echo $button1;
        for ($j = 0; $j < 4; $j++) {
            echo $button0;
        }
        echo "<br />";
    }

    for ($i = 0; $i < 5; $i++) {
        echo $button1;
    }
    echo "<br />";

    for ($i = 0; $i < 3; $i++) {
        for ($j = 0; $j < 4; $j++) {
            echo $button0;
        }
        echo "$button1<br />";
    }

    for ($i = 0; $i < 5; $i++) {
        echo $button1;
    }
    ?>
</body>
</html>