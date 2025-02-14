<?php

    $nom = $_POST["nom"];

    $adr1 = $_POST["adr1"];

    $adr2 = $_POST["adr2"];

    $codePostal = $_POST["codePostal"];

    $qte = $_POST["qte"];

    $noDepart = $_POST["noDepart"];

?>
<!doctype html>
<html lang="fr">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>420-W24-SF</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link rel="stylesheet" href="cheque.css">
</head>

<body>
    <div class="navbar navbar-light bg-dark mb-3">
        <div class="container">
            <div class="row">
                <div class="col">
                    <span class="badge text-bg-info text-light">420-W24-SF</span>
                    <h1 class="text-light">Programmation Web II</h1>
                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div>
            <h1>Chèques à imprimer</h1>
            <?php for ($i = 0; $i <= $qte; $i++) {?>
            <section class="cheque mb-3">
                <img src="specimen.png">
                <p class="noCheque">
                    <?= sprintf("%05d", $noDepart+$i); ?>
                </p>
                <h1 class="nom"><?= $nom ?></h1>
                <div class="adresse">
                <?= $adr1 ?><br>
                <?= $adr2 ?><br>
                <?= $codePostal ?>
                </div>
            </section> 
            <?php } ?>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
