const formulaireInscription = document.getElementById("formulaireInscription");

const presenceEmployeOui = document.getElementById("oui")
const presenceEmployeNon = document.getElementById("non")
const choixRepasEmploye1 = document.getElementById("choixRepasEmploye1");
const choixRepasEmploye2 = document.getElementById("choixRepasEmploye2");
const seraAccompagne1 = document.getElementById("seraAccompagne1");
const seraAccompagne2 = document.getElementById("seraAccompagne2");
const checkbox1 = document.getElementById("checkbox1");
const checkbox2 = document.getElementById("checkbox2");
const ouiAccompagne = document.getElementById("ouiAccompagne");
const nonAccompagne = document.getElementById("nonAccompagne");
const nomAccompagnateur1 = document.getElementById("nomAccompagnateur1");
const nomAccompagnateur2 = document.getElementById("nomAccompagnateur2");
const choixRepasInvite1 = document.getElementById("choixRepasInvite1");
const choixRepasInvite2 = document.getElementById("choixRepasInvite2");

const traineau = document.getElementById("traineau");
const noelDisco = document.getElementById("noelDisco");
const karaoke = document.getElementById("karaoke");
const glissades = document.getElementById("glissades");
const laserTag = document.getElementById("laserTag");
const casino = document.getElementById("casino");

const messageErreur = document.getElementById("messageErreur");

formulaireInscription.onsubmit = ValiderFormulaire;

function ValiderVisibilite(element, isVisible)
{
    if (!isVisible)
    {
        element.classList.add('d-none');
    }
    else
    {
        element.classList.remove('d-none');
    }
}

presenceEmployeOui.addEventListener('click', ValiderPresenceEmploye);
presenceEmployeNon.addEventListener('click', ValiderPresenceEmploye);

function ValiderPresenceEmploye()
{
    if (presenceEmployeOui.checked)
    {
        ValiderVisibilite(choixRepasEmploye1, true);
        ValiderVisibilite(choixRepasEmploye2, true);
        ValiderVisibilite(seraAccompagne1, true);
        ValiderVisibilite(seraAccompagne2, true);
        ValiderVisibilite(checkbox1, true);
        ValiderVisibilite(checkbox2, true);
        return true;
    }
    else if (presenceEmployeNon.checked)
    {
        ValiderVisibilite(choixRepasEmploye1, false);
        ValiderVisibilite(choixRepasEmploye2, false);
        ValiderVisibilite(seraAccompagne1, false);
        ValiderVisibilite(seraAccompagne2, false);
        ValiderVisibilite(checkbox1, false);
        ValiderVisibilite(checkbox2, false);
        ValiderVisibilite(nomAccompagnateur1, false);
        ValiderVisibilite(nomAccompagnateur2, false);
        ValiderVisibilite(choixRepasInvite1, false);
        ValiderVisibilite(choixRepasInvite2, false);
        return true;
    }
    else
    {
        messageErreur.textContent = 'Vous devez confirmer votre présence!';
        return false;
    }
}

choixRepasEmploye2.addEventListener("click", ValiderChoixRepasEmploye);

function ValiderChoixRepasEmploye()
{
    if (choixRepasEmploye2.querySelector("input:checked"))
    {
        return true;
    } 
    else 
    {
        messageErreur.textContent = "Veuillez sélectionner votre repas employé.";
        return false;
    }
}

ouiAccompagne.addEventListener('click', ValiderPrensenceSiSeraAccompagne);
nonAccompagne.addEventListener('click', ValiderPrensenceSiSeraAccompagne);

function ValiderPrensenceSiSeraAccompagne()
{
    if (ouiAccompagne.checked)
    {
        ValiderVisibilite(nomAccompagnateur1, true);
        ValiderVisibilite(nomAccompagnateur2, true);
        ValiderVisibilite(choixRepasInvite1, true);
        ValiderVisibilite(choixRepasInvite2, true);
        return true;
    }
    else if (nonAccompagne.checked)
    {
        ValiderVisibilite(nomAccompagnateur1, false);
        ValiderVisibilite(nomAccompagnateur2, false);
        ValiderVisibilite(choixRepasInvite1, false);
        ValiderVisibilite(choixRepasInvite2, false);
        return true;
    }
    else
    {
        messageErreur.textContent = 'Veuillez confirmer si vous serez accompagné(e)!';
        return false;
    }
}

function ValiderNominvite()
{
    if (nomAccompagnateur2.value === null) 
    {
        messageErreur.textContent = "Veuillez entrer le nom de votre invité(e).";
        return false;
    }
    else
    {
        return true;
    }
}

choixRepasInvite2.addEventListener('click', ValiderChoixRepasInvite);

function ValiderChoixRepasInvite()
{
    if (choixRepasInvite2.querySelector("input:checked"))
    {   
        return true;
    }
    else
    {
        messageErreur.textContent = "Veuillez sélectionner un repas de votre invité(e).";
        return false;
    }
}

function ValiderCheckbox()
{
    let cptChecked = 0;
    
    if (traineau.checked)
    {
        cptChecked++;
    }
    if (noelDisco.checked)
    {
        cptChecked++;
    }
    if (karaoke.checked)
    {
        cptChecked++;
    }
    if (glissades.checked)
    {
        cptChecked++;
    }
    if (laserTag.checked)
    {
        cptChecked++;
    }
    if (casino.checked)
    {
        cptChecked++;
    } 
    
    if (cptChecked === 2)
    {
        return true;
    }
    else
    {
        messageErreur.textContent += "Veuillez cocher deux choix d'activités!"
        return false;
    }
}

function ValiderFormulaire(evenement) 
{
    let nbChampsInvalides = 0;
    
    messageErreur.textContent = "";

    if (presenceEmployeNon.checked)
    {
        messageErreur.classList.add('d-none');
        return true;
    }
    else if (presenceEmployeOui.checked)
    {
        if(!ValiderChoixRepasEmploye())
        {
            ++nbChampsInvalides;
        }
        
        if (!ValiderPrensenceSiSeraAccompagne())
        {
            ++nbChampsInvalides;
        }

        if (ouiAccompagne.checked && !ValiderNominvite())
        {
            ++nbChampsInvalides;
        }

        if(ouiAccompagne.checked && !ValiderChoixRepasInvite())
        {
            ++nbChampsInvalides;
        }

        if (!ValiderCheckbox()) 
        {
            ++nbChampsInvalides;
        }
        
        if (nbChampsInvalides > 0) 
        {
            messageErreur.classList.remove('d-none');
            evenement.preventDefault();
        }
        
        else 
        {
            messageErreur.classList.add('d-none');
            formulaireInscription.submit()
            alert('Formulaire envoyé');
        }
    }
}
