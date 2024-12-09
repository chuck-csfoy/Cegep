const inputfield = document.getElementById("user_InputField");
const button_submit = document.getElementById("button_submit");
const errorMessage = document.getElementById("Error_message");
const cheeringUp = document.getElementById("cheering_up");
const userPrompt = document.getElementById("user_prompt");

const MIN = 1;
const MAX = 100;
let randomNumber;
let isGameOver;
let guessAttempts;

function StartNewGame()
{
    guessAttempts = 0;
    isGameOver = false;

    inputfield.value = "";
    cheeringUp.textContent = "";
    errorMessage.classList.add("d-none");
   
    userPrompt.textContent = `Choisissez un nombre entre ${MIN} et ${MAX}.`;

    randomNumber = GenerateRandomNumber();
}

function GenerateRandomNumber()
{
    return Math.floor(Math.random() * (MAX - MIN + 1)) + MIN;
}

function ManageUserInput()
{   
    let isValidInput = true;
    
    const userInput = parseInt(inputfield.value, 10);
    cheeringUp.textContent = "";
    
    if (isNaN(userInput) || userInput < MIN || userInput > MAX)
    {
        errorMessage.classList.remove("d-none");
        errorMessage.textContent = `Veuillez entrer un nombre valide entre ${MIN} et ${MAX}!`;
        isValidInput = false;
    }

    else if (isValidInput)
    {
        guessAttempts++;
        errorMessage.classList.add("d-none");
        inputfield.value = ""; 

        if (userInput === randomNumber)
        {
            cheeringUp.textContent = `Félicitations!!! Vous avez gagné!!! Vous avez trouvé le bon nombre en ${guessAttempts} essais!`;
            
            isGameOver = true;
        }
        
        else
        {
            
            if (userInput < randomNumber)
            {
                cheeringUp.textContent = `Miser plus haut que votre dernier mise ${userInput}!`;
                
            }
            else
            {
                cheeringUp.textContent = `Miser plus bas que votre dernier mise ${userInput}!`;
            }
        }

        if (isGameOver)
        {
            userPrompt.textContent = "La partie est terminée! Clickez sur soummettre pour lancer une nouvelle partie!";
        }
    }
}

function Main()
{
    if (randomNumber === undefined || isGameOver)
    {
        StartNewGame();
    }
    else
    {
        ManageUserInput();
    }
}
Main();
button_submit.addEventListener("click", Main);
