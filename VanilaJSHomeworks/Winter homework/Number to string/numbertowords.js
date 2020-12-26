let mainNode = document.getElementById("main")
let buttonNode = document.getElementById("button");
let inputNode = document.getElementById("input")

buttonNode.addEventListener("click", () => {

let inputValue = inputNode.value;    
var ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
        "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
var tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];

function convertQuadrillions (inputNum){
    if (inputNum >= 1000000000000000){
        return convertQuadrillions(Math.floor(inputNum / 1000000000000000)) + " quadrillion " + convertTrilions(inputNum % 1000000000000000)
    } else {
        return convertTrilions(inputNum)
    }
}

function convertTrilions(inputNum){
    if (inputNum >= 1000000000000){
        return convertTrilions(Math.floor(inputNum / 1000000000000)) + " trillion " + convertBilions(inputNum % 1000000000000)
    }else {
        return convertBilions(inputNum)
    }
}

function convertBilions(inputNum){
    if(inputNum >= 1000000000){
        return convertBilions(Math.floor(inputNum / 1000000000)) + " billion " + convert_millions(inputNum % 1000000000);
    }else {
        return convert_millions(inputNum)
    }
}

function convert_millions(inputNum) {
  if (inputNum >= 1000000) {
    return convert_millions(Math.floor(inputNum / 1000000)) + " million " + convertThousands(inputNum % 1000000);
  } else {
    return convertThousands(inputNum);
  }
}

function convertThousands(inputNum) {
  if (inputNum >= 1000) {
    return convertHundreds(Math.floor(inputNum / 1000)) + " thousand " + convertHundreds(inputNum % 1000);
  } else {
    return convertHundreds(inputNum);
  }
}

function convertHundreds(inputNum) {
  if (inputNum > 99) {
    return ones[Math.floor(inputNum / 100)] + " hundred " + convertTens(inputNum % 100);
  } else {
    return convertTens(inputNum);
  }
}

function convertTens(inputNum) {
  if (inputNum <= 19) return ones[inputNum];
  else {
    return tens[Math.floor(inputNum / 10)] + " " + ones[inputNum % 10];
  }
}

function checkNum(inputNum) {
  inputNum = parseInt(inputNum)
  if (inputNum === 0) return "zero";
  if (inputNum < 0) return "Enter positive number"
  else return convertQuadrillions(inputNum);
}

let spanResultNode = document.createElement ("span");
mainNode.append(spanResultNode)
spanResultNode.textContent = "Result: "
spanResultNode.style.color = "red"

let spanNode = document.createElement ("span");
mainNode.append(spanNode)
spanNode.textContent = checkNum(inputValue)


// let number = prompt("which number")
// console.log(number)
// console.log(checkNum(number))
})