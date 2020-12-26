let mainNode = document.getElementById("main")
let rowsNode = document.getElementById("rows")
let columnsNode = document.getElementById("columns")
let buttonNode = document.getElementById("buttonGen")

buttonNode.addEventListener("click", function() {
    let tableNode = document.createElement("table")
    mainNode.append(tableNode);
    let tbodyNode = document.createElement("tbody")
    tableNode.append(tbodyNode)

    for (let i = 0; i < rowsNode.value; i++) {
        let trNode = document.createElement("tr")
        tbodyNode.append(trNode)
        for (let j = 0; j < columnsNode.value; j++) {
            let tdNode = document.createElement("td")
            trNode.append(tdNode)
        }
    }
    return tableNode
});