conversionType = prompt ("Input 1 for human to dog's years conversion, or 2 for dog to human's years conversion")
 years = prompt ("How many years?");

function dogYearsConversion (input, years){
    if (input === "1"){
    return years*7;
    }else if (input === "2"){
    return years/7;
    }
}

console.log ("your dog has " + dogYearsConversion (conversionType, years) + " years");