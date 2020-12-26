let mainNode = document.getElementById("main")
let nameRecipe = prompt("What's the name of the recipe");
let howManyIngredients = prompt("How many ingrediants do we need for the recipe?");

function userArray (userInput){
    let inputArr = [];
    for (let i = 0; i < userInput; i++){
         inputArr[i] = prompt('Write the ingrediant ');
    }
    return inputArr;
}
let arrIngrediants = userArray(howManyIngredients);




function renderElement(element, parentEl) {
    parentEl.append(element)
}

function generateElement(elementType, content, id) {
    let element = document.createElement(elementType)
    if(id)
        element.setAttribute("id", id)
    if(content)
        element.textContent = content
    return element
}

let recipeTitleNode = generateElement("h2", nameRecipe, "recipeTitle")
renderElement(recipeTitleNode, mainNode)

function makeUlWithContent(contentArr) {
    let ul = generateElement("ul")
    for (const contentItem of contentArr) {
        let li = generateElement("li", contentItem)
        ul.append(li)
    }
    return ul
}

let ulNode = makeUlWithContent(arrIngrediants)
renderElement(ulNode, mainNode)

// let mainDiv = document.getElementById("main");
// mainDiv.innerHTML += `<h1>Name of the recipe is ${nameRecipe}</h1>`;
// mainDiv.innerHTML += 
// `<ul>
// <li>The ingrediants for the recipe are: ${arrIngrediants}</li>
// </ul>
// `;
