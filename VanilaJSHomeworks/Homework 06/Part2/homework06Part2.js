let howManyNumbers=prompt("how many numbers do you want to enter?");
let mainNode = document.getElementById("main");

function userArray (userInput){
    let inputArr = [];
    for (let i = 0; i < userInput; i++){
         inputArr[i] = Number(prompt('Enter Number '));
    }
    return inputArr;
}

let arrNumbers = userArray(howManyNumbers);




// let arrNumbers = [5,6,8,9,1,4,5,6];

function sumArray(someArray){
    let sum = 0 ;
    for (let i = 0; i < someArray.length; i++){
        sum = sum + someArray[i];
    } 
    return sum;
}
let sum = sumArray(arrNumbers);

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

function makeUlWithContent(contentArr) {
    let ul = generateElement("ul")
    for (const contentItem of contentArr) {
        let li = generateElement("li", contentItem)
        ul.append(li)
    }
    return ul
}

let ulNode = makeUlWithContent(arrNumbers)
renderElement(ulNode, mainNode)

renderElement(sum, mainNode)

// let mainDiv = document.getElementById("main");
// mainDiv.innerHTML += 
// `<ul>
// <li>The numbers you entered are: ${arrNumbers}</li>
// <li>The sum of those numbers is ${sum}</li>
// </ul>
// `;
