// Exercice 1
const eventMousePosition = document.getElementById("texte_etape_1");
function DisplayTextOnMouse(){
    eventMousePosition.textContent = "Non, plutôt JavaScript!"
    //console.log(texte_etape_1)
}
function DisplayTextOutMouse(){
    eventMousePosition.textContent = "J'aime PHP!"
}
eventMousePosition.onmouseover = DisplayTextOnMouse;
eventMousePosition.onmouseout = DisplayTextOutMouse;

// Exercice 2
function DisplayOnclick()
{
    const inputAge = parseInt(document.getElementById("texte_age").value);
    let ageDisplay = document.getElementById("resultat_age");
    
    if (inputAge < 0 || isNaN(inputAge))
    {
        ageDisplay.textContent = "Error";
    }
    else if (inputAge < 18)
    {
        ageDisplay.textContent = "mineur";
    }
    else
    {
        ageDisplay.textContent = "majeur";
    }
}
bouton_age.addEventListener("click", DisplayOnclick);

// Exercice 3
let totalNbPas = 0;
const compteurinterne = document.getElementById("compteur");
const bouton_incrementer = document.getElementById("bouton_incrementer");
const bouton_decrementer = document.getElementById("bouton_decrementer");
const bouton_raz = document.getElementById("bouton_raz");
function DisplayPodoIncremente(){
    //totalNbPas++;
    compteurinterne.textContent = ++totalNbPas;
}
function DisplayPodoDecremente(){
    //option ternaire
    AffichiageNbPas.textContent = totalNbPas !== 0 ? --totalNbPas : 0;
    // if (totalNbPas > 0)
    // {
    //     totalNbPas--;
    //     AffichiageNbPas.textContent = totalNbPas;
    // }
}
function DisplayPodoRAZ(){
    totalNbPas = 0;
    AffichiageNbPas.textContent = totalNbPas;
}

bouton_incrementer.onclick = DisplayPodoIncremente;
bouton_decrementer.onclick = DisplayPodoDecremente;
bouton_raz.onclick = DisplayPodoRAZ;
// bouton_incrementer.addEventListener("click", DisplayPodoIncremente)
// bouton_bouton_decrementer.addEventListener("click", DisplayPodoDecremente)
// bouton_raz.addEventListener("click", DisplayPodoRAZ)

// Exercice 4

