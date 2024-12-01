// Exercice 1
function UpdateClasses()
{
    const newList = document.getElementsByTagName("li");
    /*ou*/
    //const newList = document.querySelectorAll("li");
    for (let i = 0; i < newList.length; i++)
    {
        //const currentItem = newList[i];
        newList[i].classList.toggle("impair")
        newList[i].classList.toggle("pair")

        console.log(currentItem); 
        /*ou*/
        // if (currentItem.classList.contains("pair"))
        // {
        //     currentItem.classList.remove("pair");
        //     currentItem.classList.add("impair");
        // }
        // else
        // {
        //     currentItem.classList.remove("impair");
        //     currentItem.classList.add("pair");
        // }
    }
}
UpdateClasses();

// Exercice 2
function InsertImage()
{

    const container = document.getElementById("div_question2");
    container.innerHTML = '<img src="img/badminton.png" alt="Badminton">';

}
InsertImage()

// Exercice 3
function ChangeImageSrc()
{

    const image = document.querySelector("#div_question3 img")
    image.src = "img/danse.png";
}
ChangeImageSrc();

// Exercice 4
function AddWinnerClass ()
{

    const participants = document.querySelectorAll(".participant");

    if (participants.length >= 2)
    {
        participants[1].classList.add("gagnant");
    }
}
AddWinnerClass ()