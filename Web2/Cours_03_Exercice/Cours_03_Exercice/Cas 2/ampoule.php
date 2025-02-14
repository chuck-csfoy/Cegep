<!doctype html>
<html lang="fr">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>420-W24-SF</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</head>

<body>
    <div class="navbar navbar-light bg-dark">
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
        <div class="row">
            <div class="col">
                <h1>Ampoule</h1>
                <?php
        
                    $etatPresent = isset($_GET['etat']);
                    //Var_dump($etatPresent);
                    
                    $etatInverse = "On";

                    if ($etatPresent === true )
                    {
                        $etat = $_GET['etat'];
                        if ($etat == "On")
                        {
                            echo "<img src= \"on.png\" height=\"439\">";
                            $etatInverse = "Off";
                        }
                        else if ($etat == "Off")
                            echo "<img src= \"off.png\" height=\"439\">";
                    }

                    else
                    {
                        echo "<img src= \"off.png\" height=\"439\">";
                    }
                ?>
                <hr/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <a href="ampoule.php?etat=<?= $etatInverse?>" class="btn btn-lg btn-danger" role="button">
                    Mettre l'ampoule à <?= $etatInverse?>
                </a>
            </div>
        </div>
    </div>
    
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>