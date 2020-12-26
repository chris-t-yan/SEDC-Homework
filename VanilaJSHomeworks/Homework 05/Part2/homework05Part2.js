let howManyStudents=prompt("how many students do you want to enter?");

function userArrayName (userInput){
    let firstNames=[];
    for (let i=0; i<userInput; i++){
        firstNames[i] = prompt('Enter Name ');
    }
    return firstNames;
    
}
function userArrayLastname (userInput){
    let lastNames=[];
    for (let i=0; i<userInput; i++){
        lastNames[i] = prompt('Enter Last name ');
    }
    return lastNames;
}

let firstName = userArrayName(howManyStudents);
let lastName = userArrayLastname(howManyStudents);


function fullNames (firstName, lastName){
    let arrNames=[];
    for(let i=0; i<howManyStudents; i++){
        arrNames.push((i + 1 + ". ") + firstName[i] + " " + lastName[i] + " ");
        }    
    return arrNames;
}


let fullStudentNames = fullNames(firstName, lastName)
console.log (fullStudentNames);
alert (fullStudentNames);
