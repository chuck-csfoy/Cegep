const formulaireInscription = document.getElementById("formulaireInscription");
const motDePasse = document.getElementById("motDePasse");
const confirmationMotDePasse = document.getElementById('confirmation')
const messageErreur = document.getElementById("messageErreur");
const voirMotDePasse = document.getElementById("voirMotDePasse");

formulaireInscription.onsubmit = ValiderFormulaire;
voirMotDePasse.onchange = BasculerMotDePasse;

function BasculerMotDePasse() {
    if (voirMotDePasse.checked === true) {
        motDePasse.type = "text";
        confirmationMotDePasse.type = "text";
    } else {
        motDePasse.type = "password";
        confirmationMotDePasse.type = "password";
    }
}
 
function ContientMajuscule(texte) {
    return texte.toLocaleLowerCase() !== texte;
}

function ContientChiffre(texte) {
    const expressionReguliere = /\d+/;
    return texte.match(expressionReguliere) !== null;
}

function ValiderMotPasse() {
    let estValide = false;

    if (!ContientChiffre(motDePasse.value) || !ContientMajuscule(motDePasse.value)) {
        motDePasse.classList.add('border-danger');
        messageErreur.textContent = 'Le mot de passe doit contenir une majuscule et un chiffre. ';
    } else {
        motDePasse.classList.remove('border-danger');
        messageErreur.textContent = '';
        estValide = true;
    }

    return estValide;
}

function ValiderConfirmationMotPasse() {
    let estValide = false;

    if (motDePasse.value !== confirmationMotDePasse.value) {
        confirmationMotDePasse.classList.add('border-danger');
        messageErreur.textContent += 'Les mots de passe doivent être identiques.'
    } else {
        confirmationMotDePasse.classList.remove('border-danger');
        estValide = true;
    }

    return estValide;
}

function ValiderFormulaire(evenement) {
    let nbChampsInvalides = 0;

    if (!ValiderMotPasse()) {
        ++nbChampsInvalides;
    }

    if (!ValiderConfirmationMotPasse()) {
        ++nbChampsInvalides;
    }

    if (nbChampsInvalides !== 0) {
        messageErreur.classList.remove('d-none');
        evenement.preventDefault();
    } else {
        messageErreur.classList.add('d-none');
        alert('Formulaire envoyé')
    }
} 