let title = prompt("The name of the title");
let author = prompt("The name of the author");
let statusRead = prompt("Have you read it ?");

function Book (title, author, isReaded) {
    this.title = title;
    this.author = author;
    this.isReaded = isReaded;
   
    this.statusMethod = function() {
        if (this.isReaded==="true")
            return `Already readed  ${this.title} by ${this.author}`
        else if (this.isReaded==="false")
            return `You must read ${this.title} by ${this.author}!!!`
        else return `enter true or false`
    }
  }
//   so klasicna logika 

//     if (this.isReaded)
//            return `Already readed  ${this.title} by ${this.author}`
//     else return `You must read ${this.title} by ${this.author}!!!`

// ne mi funkcionira, pretpostavuvam radi toa sto preku prompt dobivam string
// i zatoa staviv "pokomplicirana" logika na proverka na stringovi

  let bookObj = new Book (title, author, statusRead);
  let status = bookObj.statusMethod();
  alert (status);
  console.log(bookObj)
