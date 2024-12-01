const formulaireInscription=document.getElementById("formulaireInscription");
const belize= document.getElementById("belize");
const bonaire=document.getElementById("bonaire");
const grandturk=document.getElementById("grandturk");
const messageErreur = document.getElementById("messageErreur");

formulaireInscription.onsubmit = ValiderFormulaire;


// Exercice2
function ValiderCheckbox()
{
    let isChecked = true;
    
    
    if (belize.checked || bonaire.checked || grandturk.checked)
    {
        belize.classList.remove('border-danger');
        bonaire.classList.remove('border-danger');
        grandturk.classList.remove('border-danger');
        
    }
    else
    {
        isChecked = false;
        belize.classList.add('border-danger');
        bonaire.classList.add('border-danger');
        grandturk.classList.add('border-danger');
        messageErreur.textContent += 'Veuillez cocher une destination!'
    }
    return isChecked ;
}

function ValiderFormulaire(evenement) {
    let nbChampsInvalides = 0;

    if (!ValiderCheckbox()) {
        ++nbChampsInvalides;
    }

    if (nbChampsInvalides !== 0) {
        messageErreur.classList.remove('d-none');
        evenement.preventDefault();
    }

    else {
        messageErreur.classList.add('d-none');
        alert('Formulaire envoyé')
    }
}