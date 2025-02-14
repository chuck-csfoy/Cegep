<?php
  # Variables à utiliser: 
  #   $heures   : valeur du paramètre (ajusté de 0 à 11, 12 [cas spécial == midi])
  #   $minutes  : valeur du paramètre
  #   $visible  : true si les deux paramètres sont présents
  #   $meridian : "am" ou "pm" (selon l'heure)
  #   $rotationHeures  : calcul (1 heure = 30 degrés, chaque minute vaut 0.5 degrés additionnels)
  #   $rotationMinutes : calcul (15 minutes = 90 degrés, 5 minutes = 30 degrés, 1 minute = ???)




  # NE PAS oublier d'afficher ou non la section de l'horloge
  # (section debutant par <div id="horloge-contenant">) en utilisant la variable $visible
  # NOTE: vous pouvez faire un IF, ou utiliser l'étiquette de classe 'invisible' ou 'd-none' pour masquer
  #       cette section.  Les deux façons sont bonnes.
?>

<!doctype html>
<html lang="fr">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>420-W24-SF</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link rel="stylesheet" href="horloge.css">
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
        <div class="row">
            <h1 class="col-md-12">Horloge</h1>

            <form method="POST" action="horloge.php">
                <div class="mb-3 col-md-2">
                    <label class="form-label" for="heures">Heures (0-23): </label>
                    <input type="number" min="0" max="23" step="1" class="form-control" id="heures" name="heures" required autofocus>
                </div>
                <div class="mb-3 col-md-2">
                    <label class="form-label" for="minutes">Minutes (0-59): </label>
                    <input type="number" min="0" max="59" step="1" class="form-control col-md-2" id="minutes" name="minutes" required>
                </div>
                <div class="mb-3 col-md-12">
                    <button type="submit" class="btn btn-primary col-md-2">Soumettre</button>
                </div>
            </form>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                <div id="horloge-contenant">
                    <h1>Heure: <?= $heures . 'h' . sprintf("%02d",$minutes) . $meridian ?></h1>
                    <article class="horloge">
                        <div style="transform: rotate(<?= $rotationHeures ?>deg)" class="heures-conteneur">
                            <div class="heures">
                            </div>
                        </div>
                        <div style="transform: rotate(<?= $rotationMinutes ?>deg)" class="minutes-conteneur">
                            <div class="minutes">
                            </div>
                        </div>
                        <div class="secondes-conteneur">
                            <div class="secondes">
                            </div>
                        </div>
                    </article>
                </div>
            </div>
        </div>
    </div>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>