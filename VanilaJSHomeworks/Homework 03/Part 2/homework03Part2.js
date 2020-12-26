let drink = prompt("What drink would you like? We have coffee, juice, water, beer, wine or whisky");
let quanity = prompt("How many do you want?");
let totalMoney
switch(drink){
    case "coffee":
        totalMoney=quanity*2;
        alert(`Type: ${drink}, Qanity: ${quanity}, Total Price: ${totalMoney}$`);
           break;
    case "juice":
        totalMoney=quanity*3;
        alert(`Type: ${drink}, Qanity: ${quanity}, Total Price: ${totalMoney}$`);
            break;
    case "water":
        totalMoney=quanity*1;
        alert(`Type: ${drink}, Qanity: ${quanity}, Total Price: ${totalMoney}$`);
           break;
    case "beer":
        totalMoney=quanity*4;
        alert(`Type: ${drink}, Qanity: ${quanity}, Total Price: ${totalMoney}$`);
           break;
    case "wine":
        totalMoney=quanity*5;
        alert(`Type: ${drink}, Qanity: ${quanity}, Total Price: ${totalMoney}$`);
           break;
    case "whisky":
        totalMoney=quanity*10;
        alert(`Type: ${drink}, Qanity: ${quanity}, Total Price: ${totalMoney}$`);
           break;                                    
    default: alert("We don't have that drink")
        }
