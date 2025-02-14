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
        <h1>Défis</h1>
        <div class="card border-primary mb-3">
            <div class="card-header text-white bg-primary">
                <h3>Premier défi</h3>
                <a href="verifPremierDefi.php" class="btn btn-warning">Valider</a>
            </div>
            <div class="card-body">
            <pre class="border p-3">
Le premier défi consiste à valider si on a reçu (ou non) les <strong>deux paramètres</strong> requis (a et b).
Si tous les paramètres attendus sont présents:
   on affiche "<span class="badge text-bg-warning">Tous les paramètres sont reçus (a et b)</span>"
sinon
   on affiche "<span class="badge text-bg-warning">Pas reçu tous les paramètres</span>";</pre>
            </div>
        </div>
        
        <div class="card border-primary mb-3">
            <div class="card-header text-white bg-primary">
                <h3>Second défi</h3>
                <a href="verifSecondDefi.php" class="btn btn-warning">Valider</a>
            </div>
            <div class="card-body">
            <pre class="border p-3">
Comme second défi, on va plus loin que le défi #1... On veut savoir combien de paramètres manquent à l'appel.
Si tous les paramètres attendus badge présents:
   on affiche "<span class="badge text-bg-warning">Tous les paramètres sont reçus (a et b)</span>"
sinon
   on affiche 
      "<span class="badge text-bg-warning">Il manque 1 paramètre</span>" ou bien 
      "<span class="badge text-bg-warning">Il manque 2 paramètres</span>"</pre>
            </div>
        </div>

        <div class="card border-primary mb-3">
            <div class="card-header text-white bg-primary">
                <h3>Troisième défi</h3>
                <a href="verifTroisiemeDefi.php" class="btn btn-warning">Valider</a>
            </div>
            <div class="card-body">
            <pre class="border p-3">
Pour le 3<sup>e</sup> défi, on considère que les deux paramètres sont fournis (ne pas faire les <strong>isset()</strong>).
On affiche l'un des trois messages suivants:
   "<span class="badge text-bg-warning">a &lt; b</span>" ou
   "<span class="badge text-bg-warning">a &gt; b</span>" ou 
   "<span class="badge text-bg-warning">a, b identiques</span>"
</pre>
            </div>
        </div>
        
        <div class="card border-primary mb-3">
            <div class="card-header text-white bg-primary">
                <h3>Quatrième défi</h3>
                <a href="verifQuatriemeDefi.php" class="btn btn-warning">Valider</a>
            </div>
            <div class="card-body">
            <pre class="border p-3">
Pour le 4<sup>e</sup> défi, on considère que le paramètre est toujours fourni (pas besoin du <strong>isset()</strong>).
On veut afficher le <span class="badge text-bg-warning">nom du mois</span> et son <span class="badge text-bg-warning">nombre de jours</span>.
Vous devez utiliser un <span class="badge text-bg-success">tableau (array) pour les noms des mois</span>.
Vous <span class="badge text-bg-danger">ne devez pas utiliser de tableau</span> pour le nombre de jours (faire des <strong>if</strong>).
</pre>
            </div>
        </div>
        
        <div class="card border-primary mb-3">
            <div class="card-header text-white bg-primary">
                <h3>Cinquième défi</h3>
                <a href="verifCinquiemeDefi.php" class="btn btn-warning">Valider</a>
            </div>
            <div class="card-body">
            <pre class="border p-3">
Pour le 5<sup>e</sup> défi, on veut afficher quatre ampoules Nixie.
La <span class="badge text-bg-danger">première ampoule</span> sera éteinte si le <span class="badge text-bg-warning">paramètre a</span> est manquant.  
Sinon, on affiche l'image de l'ampoule correspondant au numéro du <span class="badge text-bg-warning">paramètre a</span>.

La <span class="badge text-bg-danger">seconde ampoule</span> sera éteinte si le <span class="badge text-bg-warning">paramètre b</span> est manquant.  
Sinon, on affiche l'image de l'ampoule correspondant au numéro du <span class="badge text-bg-warning">paramètre b</span>.

La <span class="badge text-bg-danger">troisième ampoule</span> sera éteinte si le <span class="badge text-bg-warning">paramètre c</span> est manquant.  
Sinon, on affiche l'image de l'ampoule correspondant au numéro du <span class="badge text-bg-warning">paramètre c</span>.

La <span class="badge text-bg-danger">quatrième ampoule</span> sera éteinte si le <span class="badge text-bg-warning">paramètre d</span> est manquant.  
Sinon, on affiche l'image de l'ampoule correspondant au numéro du <span class="badge text-bg-warning">paramètre d</span>.

</pre>
            </div>
        </div>
        
    </div>
</div>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>