<?php
        
        $nombrePresent = isset($_GET['nombre']);
        //Var_dump($nombre);
        
        if ($nombrePresent === true) 
        {
            $nombre = $_GET['nombre'];
        }
        //Var_dump($nombre);
?>

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
        <h1>Table de multiplication de <?= $nombre?></h1>
        <table class="table table-striped" >
            <thead>
                <tr>
                    <th>Calcul</th>
                    <th>Résultat</th>
                </tr>
            </thead>
            <tbody>
            <?php
            //Var_dump($nombrePresent);
                if ($nombrePresent)
                {
                    for ($i = 1; $i <= 12; $i++)
                    {
            ?>
                        <tr>
                            <td><?= $nombre ?> X <?= $i ?></td>
                            <td>=
                            <?= $nombre*$i ?>
                            </td>
                        </tr>
                <?php
                    }
                }
                ?>
            </tbody>
        </table>
        <hr/>
        <em>Le paramètre reçu correspond à la clé 'nombre'.</em>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
  </body>
</html>