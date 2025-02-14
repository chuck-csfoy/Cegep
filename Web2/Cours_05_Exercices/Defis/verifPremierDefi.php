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
            <h1>Validation 1<sup>er</sup> défi</h1>
            <a class="btn btn-success" href="premierDefi.php?a=10&b=20">a=10, b=20</a> Tous les paramètres sont reçus (a et b)<br><br>
            <a class="btn btn-danger" href="premierDefi.php?a=10">a=10</a> Pas reçu tous les paramètres<br> <br>
            <a class="btn btn-danger" href="premierDefi.php?b=20">b=20</a> Pas reçu tous les paramètres<br> <br>
            <a class="btn btn-danger" href="premierDefi.php">aucun paramètre</a> Pas reçu tous les paramètres<br><br>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>