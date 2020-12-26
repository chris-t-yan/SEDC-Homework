userInput = prompt ("How much money do you want");

function atm (input){
    let totalMoney = 1000;
    if (input <= totalMoney) {
        totalMoney -= input;
        alert(`You requested ${input}$, and you have ${totalMoney}$ left on account`)
    }else alert ("You don't have enough money");
}

atm(userInput);
