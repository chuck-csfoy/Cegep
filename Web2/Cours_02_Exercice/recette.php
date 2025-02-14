<?php
    $nbPersonnes = 2;
    $ratio = $nbPersonnes / 4;
    
    $nbOeufs = 2 * $ratio;
    $motOeuf = "oeuf";
    if ($nbOeufs > 1)
        $motOeuf = "oeufs";
?>

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Recette</title>
</head>

<body>
    <h1>Brownies moelleux</h1>
    <p>Ingrédients pour réaliser cette recette pour <?= $nbPersonnes ?> :</p>
    <ul>
        <li><?=200 * $ratio?>g de chocolat noir pâtissier,</li>
        <li><?=100 * $ratio?>g de beurre,</li>
        <li><?=80 * $ratio?>g de sucre en poudre,</li>
        <li><?=50 * $ratio?>g de farine,</li>
        <li><?=2 * $ratio?>oeuf(s),</li>
        <li>des noix concassées</li>
    </ul>
    <img width="265" src="https://images.ricardocuisine.com/services/recipes/992x1340_1035-v2.jpg">
</body>
</html>