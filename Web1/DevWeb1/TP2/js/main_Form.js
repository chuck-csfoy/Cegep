const christmasPartyForm = document.getElementById("christmasPartyForm");
const errorMessage = document.getElementById("errorMessage");
const employeeAttendanceYes = document.getElementById("yes")
const employeeAttendanceNo = document.getElementById("no")
const employeeMealChoiceLabel = document.getElementById("employeeMealChoiceLabel");
const employeeMealChoiceInput = document.getElementById("employeeMealChoiceInput");
const pouletAnanasEmployee = document.getElementById("pouletAnanas-employee");
const boeufBraiseEmployee = document.getElementById("boeufBraise-employee");
const tourtiereEmployee = document.getElementById("tourtiere-employee");
const guestAttendanceLabel = document.getElementById("guestAttendanceLabel");
const guestAttendanceInput = document.getElementById("guestAttendanceInput");
const guestAttendanceYes = document.getElementById("guestAttendanceYes");
const guestAttendanceNo = document.getElementById("guestAttendanceNo");
const guestNameLabel = document.getElementById("guestNameLabel");
const guestNameInput = document.getElementById("guestNameInput");
const guestName = document.getElementById("guestName");
const pouletAnanasGuest = document.getElementById("pouletAnanas-guest");
const boeufBraiseGuest = document.getElementById("boeufBraise-guest");
const tourtiereGuest = document.getElementById("tourtiere-guest");
const guestMealChoiceLabel = document.getElementById("guestMealChoiceLabel");
const guestMealChoiceInput = document.getElementById("guestMealChoiceInput");
const activityChoiceLabel = document.getElementById("activityChoiceLabel");
const activityChoiceInput = document.getElementById("activityChoiceInput");
const dogSled = document.getElementById("dogSled");
const christmasDisco = document.getElementById("christmasDisco");
const karaoke = document.getElementById("karaoke");
const slides = document.getElementById("slides");
const laserTag = document.getElementById("laserTag");
const casino = document.getElementById("casino");

employeeAttendanceYes.addEventListener('click', ValidateEmployeeAttendance);
employeeAttendanceNo.addEventListener('click', ValidateEmployeeAttendance);
employeeMealChoiceInput.addEventListener("click", ValidateEmployeeMealChoice);
guestAttendanceYes.addEventListener('click', ValidateGuestAttendance);
guestAttendanceNo.addEventListener('click', ValidateGuestAttendance);
guestMealChoiceInput.addEventListener('click', ValidateGuestMealChoice);

christmasPartyForm.onsubmit = ValidateMainForm;

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

function ValidateEmployeeAttendance()
{
    if (employeeAttendanceYes.checked)
    {
        ToggleElementRequired(pouletAnanasEmployee, true);
        ToggleElementRequired(boeufBraiseEmployee, true);
        ToggleElementRequired(tourtiereEmployee, true);
        ToggleElementRequired(guestAttendanceYes, true);
        ToggleElementRequired(guestAttendanceNo, true);

        ToggleElementVisibility(employeeMealChoiceLabel, true);
        ToggleElementVisibility(employeeMealChoiceInput, true);
        ToggleElementVisibility(guestAttendanceLabel, true);
        ToggleElementVisibility(guestAttendanceInput, true);
        ToggleElementVisibility(activityChoiceInput, true);
        ToggleElementVisibility(activityChoiceLabel, true);
        return true;
    }
    else if (employeeAttendanceNo.checked)
    {
        ToggleElementRequired(pouletAnanasEmployee, false);
        ToggleElementRequired(boeufBraiseEmployee, false);
        ToggleElementRequired(tourtiereEmployee, false);
        ToggleElementRequired(guestAttendanceYes, false);
        ToggleElementRequired(guestAttendanceNo, false);

        ToggleElementVisibility(employeeMealChoiceLabel, false);
        ToggleElementVisibility(employeeMealChoiceInput, false);
        ToggleElementVisibility(guestAttendanceLabel, false);
        ToggleElementVisibility(guestAttendanceInput, false);
        ToggleElementVisibility(activityChoiceInput, false);
        ToggleElementVisibility(activityChoiceLabel, false);
        ToggleElementVisibility(guestNameLabel, false);
        ToggleElementVisibility(guestNameInput, false);
        ToggleElementVisibility(guestMealChoiceLabel, false);
        ToggleElementVisibility(guestMealChoiceInput, false);
        return true;
    }
    else
    {
        return false;
    }
}

function ValidateEmployeeMealChoice()
{
    if (employeeMealChoiceInput.querySelector("input:checked"))
    {
        return true;
    } 
    else 
    {
        return false;
    }
}

function ValidateGuestAttendance()
{
    if (guestAttendanceYes.checked)
    {
        ToggleElementRequired(guestName, true);
        ToggleElementRequired(pouletAnanasGuest, true);
        ToggleElementRequired(boeufBraiseGuest, true);
        ToggleElementRequired(tourtiereGuest, true);

        ToggleElementVisibility(guestNameLabel, true);
        ToggleElementVisibility(guestNameInput, true);
        ToggleElementVisibility(guestMealChoiceLabel, true);
        ToggleElementVisibility(guestMealChoiceInput, true);
        return true;
    }
    else if (guestAttendanceNo.checked)
    {
        ToggleElementRequired(guestName, false);
        ToggleElementRequired(pouletAnanasGuest, false);
        ToggleElementRequired(boeufBraiseGuest, false);
        ToggleElementRequired(tourtiereGuest, false);

        ToggleElementVisibility(guestNameLabel, false);
        ToggleElementVisibility(guestNameInput, false);
        ToggleElementVisibility(guestMealChoiceLabel, false);
        ToggleElementVisibility(guestMealChoiceInput, false);
        return true;
    }
    else
    {
        return false;
    }
}

function ValidateGuestName()
{
    if (guestNameInput.value === null) 
    {
        return false;
    }
    else
    {
        return true;
    }
}

function ValidateGuestMealChoice()
{
    if (guestMealChoiceInput.querySelector("input:checked"))
    {   
        return true;
    }
    else
    {
        return false;
    }
}

function ValidateActivityChoice()
{
    let cptChecked = 0;
    
    if (dogSled.checked)
    {
        cptChecked++;
    }
    if (christmasDisco.checked)
    {
        cptChecked++;
    }
    if (karaoke.checked)
    {
        cptChecked++;
    }
    if (slides.checked)
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
        errorMessage.textContent += "Veuillez côcher deux choix d'activités! ";
        return false;
    }
}

function ValidateMainForm(evenement) 
{
    let nbInvalidFields = 0;
    
    errorMessage.textContent = "";

    if (employeeAttendanceNo.checked)
    {
        errorMessage.classList.add('d-none');
        return true;
    }
    else if (employeeAttendanceYes.checked)
    {
        if (!ValidateEmployeeMealChoice())
        {
            ++nbInvalidFields;
        }
        if (!ValidateGuestAttendance())
        {
            ++nbInvalidFields;
        }
        if (guestAttendanceYes.checked && !ValidateGuestName())
        {
            ++nbInvalidFields;
        }
        if (guestAttendanceYes.checked && !ValidateGuestMealChoice())
        {
            ++nbInvalidFields;
        }
        if (!ValidateActivityChoice())
        {
            ++nbInvalidFields;
        }
        if (nbInvalidFields > 0)
        {
            errorMessage.classList.remove('d-none');
            evenement.preventDefault();
        }
        else 
        {
            errorMessage.classList.add('d-none');
            christmasPartyForm.submit()
            alert('Formulaire envoyé');
        }
    }
}
