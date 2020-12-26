
let animalKind = prompt("What's the kind of the animal?");
let animalName = prompt("What's the name of the animal?");
let speakAnimal = prompt("What does it say")
    
function Animal(kind, name, speak) {
    this.kind = kind;
    this.name = name;
    this.speak = speak;
    this.speakAnimalMethod = function() {
        return `${this.kind} says: ${this.speak}!!!`
    }
  }

      let animalObj = new Animal (animalKind, animalName, speakAnimal)
    console.log(animalObj.speakAnimalMethod(speakAnimal))
    console.log (animalObj)


