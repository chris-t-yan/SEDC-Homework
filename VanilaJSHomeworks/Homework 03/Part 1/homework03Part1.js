let firstNumber = prompt("Enter the first number");
let secondNumber = prompt("Enter the second number");
let coefficientNo1;
let coefficientNo2;

if (firstNumber !== secondNumber){

coefficientNo1 = Math.abs(firstNumber - 100);
coefficientNo2 = Math.abs(secondNumber - 100);

if (coefficientNo1 < coefficientNo2){
    alert(`Closer to 100 is the first number, which is ${firstNumber}`);
}
if (coefficientNo2 < coefficientNo1){
    alert(`Closer to 100 is the second number, which is ${secondNumber}`);
} 
else {
    alert("The two numbers are equally distanced from the number 100");
        }
}
