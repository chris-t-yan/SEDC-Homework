let btnClear = document.getElementById("btnClear")

let displayValElement = document.getElementById ("displayVal")
let displayOperationElement = document.getElementById ("displayOperation")

let displayVal = "0"
let pendingVal = [];
let evalStringArray = [];

let btnsNum = document.getElementsByClassName("btnNumber")
let btnsOperator = document.getElementsByClassName("btnOperator")

    let performOperation = (clicked)=>{
        let operator = clicked.target.innerText;
        switch (operator) {
            case "+":
                pendingVal = displayVal;
                displayVal = "" ;
                displayValElement.innerText=displayVal;
                evalStringArray.push(pendingVal);
                evalStringArray.push("+")
                break;
           case "-":
               pendingVal = displayVal;
               displayVal = "";
               displayValElement.innerText=displayVal;
               evalStringArray.push(pendingVal);
               evalStringArray.push("-")
                break;     
           case "*":
               pendingVal = displayVal;
               displayVal = "";
               displayValElement.innerText=displayVal;
               evalStringArray.push(pendingVal);
               evalStringArray.push("*")
                break; 
            case "/":
               pendingVal = displayVal;
               displayVal = "";
               displayValElement.innerText=displayVal;
               evalStringArray.push(pendingVal);
               evalStringArray.push("/")
                break;
            case "=":
               evalStringArray.push(displayVal);
               let evaluation = CalcInputArr (evalStringArray)
               displayVal = evaluation + "";
               displayValElement.innerText = displayVal;
               
               let displayArr = "";
                for(let i = 0; i < evalStringArray.length; i++) {
                    displayArr = displayArr + evalStringArray[i] ;
                }
               displayOperationElement.innerText = displayArr + " =";
               evalStringArray = [];
                break;            
            default:
                break;
        }
    }
   
    let updateDisplayVal = (clicked) => {
        let btnText = clicked.target.innerText;
        if (displayVal === "0")
            displayVal = "";
        displayVal += btnText;
        displayValElement.innerText=displayVal;
        }

    for (let i=0; i < btnsNum.length; i++ ){
        btnsNum[i].addEventListener("click", updateDisplayVal)
    }
    
    for (let i=0; i < btnsOperator.length; i++ ){
        btnsOperator[i].addEventListener("click", performOperation)
    }

    btnClear.onclick=()=>{
        displayVal = "";
        evalStringArray = [];
        displayValElement.innerHTML = displayVal;
        displayOperationElement.innerHTML = displayVal;

    }

function CalcInputArr(evalStringArray){
    let result = evalStringArray[0];
    let dividedByZero = 0;
    
    for ( let i=2; i<evalStringArray.length; i=i+2) {

        switch (evalStringArray[i-1]) {
            case "+":
                result = parseFloat(result) + parseFloat(evalStringArray[i]);
                break;
            case "-":
                result = result - evalStringArray[i];
                break;
            case "/": if (evalStringArray[i] === "0")   
                        dividedByZero = 1;
                    else result = result / evalStringArray[i];
                break;
            case "*": result = result * evalStringArray[i];
                break;
        }                  

    }      
            result = parseFloat(result);

            let numOfDigits = result.toString().length
            if(numOfDigits > 15){
                result = "ERROR: The number has too many digits!"
            } 

            if (dividedByZero === 1) { 
                result = "ERROR: Deviding with zero is not possible!"
            } 
            
            return result
}






