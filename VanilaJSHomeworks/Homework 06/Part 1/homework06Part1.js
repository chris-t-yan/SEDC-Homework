let allParagraph = document.getElementsByTagName("p");
for(let i = 0; i < allParagraph.length; i++) {
    allParagraph[i].innerText = "Changed text to the all PARAGRAPH";
}

let allHeadersH1 = document.getElementsByTagName("h1");
for(let i = 0; i < allHeadersH1.length; i++) {
    allHeadersH1[i].innerText = "Changed text to the all HEADERS H1";
}

let allHeadersH3 = document.getElementsByTagName("h3");
for(let i = 0; i < allHeadersH3.length; i++) {
    allHeadersH3[i].innerText = "Changed text to the all HEADERS H3";
}
