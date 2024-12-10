const xmasPartyForm = document.getElementById("formulaireInscription");

const EmployeeAttendanceYes = document.getElementById("oui")
const EmployeeAttendanceNo = document.getElementById("non")
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



xmasPartyForm.onsubmit = ValidateMainForm;

function ToggleElementVisibility(element, isVisible)
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

function ToggleElementRequired(element, isRequired)
{
    if (!isRequired)
    {
        element.removeAttribute('required');
    }
    else
    {
        element.setAttribute('required', true);
    }
}

EmployeeAttendanceYes.addEventListener('click', ValidateEmployeeAttendance);
EmployeeAttendanceNo.addEventListener('click', ValidateEmployeeAttendance);
const pouletAnanasEmployee = document.getElementById("pouletAnanas-employe");
const boeufBraiseEmployee = document.getElementById("boeufBraise-employe");
const tourtiereEmployee = document.getElementById("tourtiere-employe");

const guestYes = document.getElementById("ouiAccompagne");
const guestNo = document.getElementById("nonAccompagne");



function ValidateEmployeeAttendance()
{
    if (EmployeeAttendanceYes.checked)
    {
        ToggleElementRequired(pouletAnanasEmployee, true);
        ToggleElementRequired(boeufBraiseEmployee, true);
        ToggleElementRequired(tourtiereEmployee, true);
        ToggleElementRequired(guestYes, true);
        ToggleElementRequired(guestNo, true);

        ToggleElementVisibility(choixRepasEmploye1, true);
        ToggleElementVisibility(choixRepasEmploye2, true);
        ToggleElementVisibility(seraAccompagne1, true);
        ToggleElementVisibility(seraAccompagne2, true);
        ToggleElementVisibility(checkbox1, true);
        ToggleElementVisibility(checkbox2, true);
        return true;
    }
    else if (EmployeeAttendanceNo.checked)
    {
        ToggleElementRequired(pouletAnanasEmployee, false);
        ToggleElementRequired(boeufBraiseEmployee, false);
        ToggleElementRequired(tourtiereEmployee, false);
        ToggleElementRequired(guestYes, false);
        ToggleElementRequired(guestNo, false);

        ToggleElementVisibility(choixRepasEmploye1, false);
        ToggleElementVisibility(choixRepasEmploye2, false);
        ToggleElementVisibility(seraAccompagne1, false);
        ToggleElementVisibility(seraAccompagne2, false);
        ToggleElementVisibility(checkbox1, false);
        ToggleElementVisibility(checkbox2, false);
        ToggleElementVisibility(nomAccompagnateur1, false);
        ToggleElementVisibility(nomAccompagnateur2, false);
        ToggleElementVisibility(choixRepasInvite1, false);
        ToggleElementVisibility(choixRepasInvite2, false);
        return true;
    }
    else
    {
        //messageErreur.textContent = 'Vous devez confirmer votre présence!';
        return false;
    }
}

choixRepasEmploye2.addEventListener("click", ValidateEmployeeMealChoice);

function ValidateEmployeeMealChoice()
{
    if (choixRepasEmploye2.querySelector("input:checked"))
    {
        return true;
    } 
    else 
    {
        //messageErreur.textContent += "Veuillez sélectionner votre repas employé.";
        return false;
    }
}

ouiAccompagne.addEventListener('click', ValidateGuestAttendance);
nonAccompagne.addEventListener('click', ValidateGuestAttendance);

const guestName = document.getElementById("nomInvite");

const pouletAnanasGuest = document.getElementById("pouletAnanas-invite");
const boeufBraiseGuest = document.getElementById("boeufBraise-invite");
const tourtiereGuest = document.getElementById("tourtiere-invite");

function ValidateGuestAttendance()
{
    if (ouiAccompagne.checked)
    {
        ToggleElementRequired(guestName, true);
        ToggleElementRequired(pouletAnanasGuest, true);
        ToggleElementRequired(boeufBraiseGuest, true);
        ToggleElementRequired(tourtiereGuest, true);

        ToggleElementVisibility(nomAccompagnateur1, true);
        ToggleElementVisibility(nomAccompagnateur2, true);
        ToggleElementVisibility(choixRepasInvite1, true);
        ToggleElementVisibility(choixRepasInvite2, true);
        return true;
    }
    else if (nonAccompagne.checked)
    {
        ToggleElementRequired(guestName, false);
        ToggleElementRequired(pouletAnanasGuest, false);
        ToggleElementRequired(boeufBraiseGuest, false);
        ToggleElementRequired(tourtiereGuest, false);

        ToggleElementVisibility(nomAccompagnateur1, false);
        ToggleElementVisibility(nomAccompagnateur2, false);
        ToggleElementVisibility(choixRepasInvite1, false);
        ToggleElementVisibility(choixRepasInvite2, false);
        return true;
    }
    else
    {
        //messageErreur.textContent += 'Veuillez confirmer si vous serez accompagné(e)! ';
        return false;
    }
}

function ValidateGuestName()
{
    if (nomAccompagnateur2.value === null) 
    {
        //messageErreur.textContent += "Veuillez entrer le nom de votre invité(e). ";
        return false;
    }
    else
    {
        return true;
    }
}

choixRepasInvite2.addEventListener('click', ValidateGuestMealChoice);

function ValidateGuestMealChoice()
{
    if (choixRepasInvite2.querySelector("input:checked"))
    {   
        return true;
    }
    else
    {
        //messageErreur.textContent += "Veuillez sélectionner un repas de votre invité(e). ";
        return false;
    }
}

function ValidateActivityChoice()
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
        messageErreur.textContent += "Veuillez cocher deux choix d'activités! ";
        return false;
    }
}

function ValidateMainForm(evenement) 
{
    let nbInvalidFields = 0;
    
    messageErreur.textContent = "";

    if (EmployeeAttendanceNo.checked)
    {
        messageErreur.classList.add('d-none');
        return true;
    }
    else if (EmployeeAttendanceYes.checked)
    {
        if(!ValidateEmployeeMealChoice())
        {
            ++nbInvalidFields;
        }
        
        if (!ValidateGuestAttendance())
        {
            ++nbInvalidFields;
        }

        if (ouiAccompagne.checked && !ValidateGuestName())
        {
            ++nbInvalidFields;
        }

        if(ouiAccompagne.checked && !ValidateGuestMealChoice())
        {
            ++nbInvalidFields;
        }

        if (!ValidateActivityChoice())
        {
            ++nbInvalidFields;
        }
        
        if (nbInvalidFields > 0)
        {
            messageErreur.classList.remove('d-none');
            evenement.preventDefault();
        }
        
        else 
        {
            messageErreur.classList.add('d-none');
            xmasPartyForm.submit()
            alert('Formulaire envoyé');
        }
    }
}
