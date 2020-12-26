let howManyNumbers=prompt("how many numbers do you want to enter?");

function userArray (userInput){
    let inputArr=[];
    for (let i=0; i<userInput; i++){
         inputArr[i] = prompt('Enter Number ');
    }
    return inputArr;
}

let arrNumbers = userArray(howManyNumbers);

function sumMaxMin (arr){
    let maxNumber = Math.max(...arr);
    let minNumber = Math.min(...arr);
    let sum = maxNumber + minNumber;
    return (`Biggest number is ${maxNumber}, smallest number is ${minNumber} and the sum of those two numbers is ${sum}`);
}
    
    let sum = sumMaxMin(arrNumbers);
    console.log(sum);
    alert(sum);