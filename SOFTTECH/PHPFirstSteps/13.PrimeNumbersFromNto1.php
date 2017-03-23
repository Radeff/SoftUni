<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>First Steps Into PHP</title>

    </head>
<body>
    <form>
        N: <input type="text" name="num"/>
        <input type="submit"/>
    </form>
    <?php
    $primes = array();
    if (isset($_GET['num'])) {
        $num = intval($_GET['num']);
        for ($i = $num; $i > 2; $i--) {
            $isPrime = true;
            for ($j = 2; $j <= intval(sqrt($i)); $j++) {
                if ($i % $j == 0) {
                    $isPrime = false;
                }
            }
            if ($isPrime == true) {
                $primes[] = $i;
            }
        }
    $primes[] = 2;
    echo implode(" ", $primes);
    }
    ?>
</body>
</html>