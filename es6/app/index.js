import {circle,rectangle,cylinder} from './Ques8.js' // importing the modules for calculating area of circle,rectangle,cylinder.
import{outputArray} from './Ques9.js' // imported the Question 4 js file.
import {stackUsingLinkList} from './Ques13.js'
import  {Node,LinkedList} from './Ques11.js'



console.log(" Question 1: Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, create an array of the numbers greater than `70`.");
const numArray = [3, 62, 234, 7, 23, 74, 23, 76, 92]; 
const result = numArray.filter(numArray => numArray > 70);
console.log("Ans 1:" + result);

  //------------------------------------------------------------------------------------------------------------------//

console.log("Question 2: It is done in the Ques2.html page that is in --- './build/Ques2.html'");

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 3: Create a markup template using string literal")
/* 
const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};
Result:
"<div class="song">
   <p>
     Dying to live — Tupac
     (Featuring Biggie Smalls)
   </p>
 </div>
“
*/
const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};
const literal = `<div class="song">
        <p>
            ${song.name} - ${song.artist}
            (Featuring ${song.featuring})
        </p>
    </div>`;

console.log("Ans 3: "+literal); 

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 4: Extract all keys inside address object from user object using destructuring ")
/* 
const user = {
firstName: ‘Sahil’,
lastName: ‘Dua’,
Address: {
Line1: ‘address line 1’,
Line2: ‘address line 2’,
State: ‘Delhi’,
Pin: 110085,
Country: ‘India’,
City: ‘New Delhi’,
},
phoneNo: 9999999999
} */
const user = {
firstName: 'Sahil',
lastName: 'Dua',
Address: {
Line1: 'address line 1',
Line2: 'address line 2',
State: 'Delhi',
Pin: 110085,
Country: 'India',
City: 'New Delhi',
},
phoneNo: 9999999999
};
let{Line1,Line2,State,Pin,Country,City}=user.Address;
console.log("Ans 4: " + Line1,Line2,State,Pin,Country,City);

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 5: Find the possible combinations of a string and store them in a MAP")
function getAll(string)
{
    var results = [];

  if (string.length === 1) {
    results.push(string);
    return results;
  }
  
  for (var i = 0; i < string.length; i++) {
    var char1 = string[i];
    var char2 = string.substring(0, i) + string.substring(i + 1);
    var inner = getAll(char2);
    for (var j = 0; j < inner.length; j++) {
      results.push(char1 + inner[j]);
    }
  }
  return results;
}

console.log("Ans 5: ");
console.log(getAll("arpit"));

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 6: Write a program to implement inheritance upto 3 classes.The Class must public variables and static functions.")
 class Drivers
 {
   constructor(name)
   {
     this.name = name;
   }
   static experience()
   {
     console.log("Ans 6 : Marsh having experience of 3 years.");
   }
   Wins()
   {
     console.log(`${this.name} having 3 wins.`);
   }
}
class Corider extends Drivers // inherited the Driver class
{
    Wins()
  {
    console.log(`${this.name} having 1 win.`); // method is overrided
  }
}
class carcompany extends Corider // inherited the Corider class
{
    Wins()
    {
      super.Wins(); // it invokes the method from the parent class
      console.log(`${this.name} having 10 wins`);

    }

}
let a = new carcompany('Haas');
console.log(Drivers.experience()); // static method ivoked by class name
console.log(a.Wins()); // method inherited from parent class

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 7: Write a program to implement a class having static functions");

class Driver {
  static category() {
    return 'Ans 7 : Category of Driver is returned.';
  }
}

console.log(Driver.category());

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 8: Import a module containing the constants and method for calculating area of circle, rectangle, cylinder.");

console.log("Ans 8 : Area of circle with radii(10) is : " + circle(10));
console.log(" Area of rectangle with height(10) and breadth(20) is : " + rectangle(10,20));
console.log(" Area of cylinder with radiius(5) and height(10) is : " + cylinder(5,10));

//------------------------------------------------------------------------------------------------------------------//

console.log ("Question 9: Import a module for filtering unique elements in an array.");
// implemented the array filtering using set as we have done Ques4 

console.log("Ans 9: " + outputArray); 

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 10: Write a program to flatten a nested array to single level using arrow functions.");
const nonFlatenedArray= [[0,[2]],[1,2,[3]],[4,[5,16,7,[3,4,5]]]];
console.log("Ans 10: " + nonFlatenedArray.flat(Infinity));

//------------------------------------------------------------------------------------------------------------------//

console.log("Question 11: Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)");
console.log("Ans 11 :")

let linklist= new LinkedList();
linklist.addFirst(23);
linklist.addFirst(12);
linklist.addLast(99);
linklist.print(); 
console.log("Length of the Linked List : " + linklist.length());
console.log("First element of the Linked List " + linklist.getFirst());
console.log("Last element of the Linked List " + linklist.getLast());

//------------------------------------------------------------------------------------------------------------------//

//Question 12 : implement Map and Set.
console.log("Ans 12 : Implement Map and Set using Es6");
console.log("Implementing Map");

 let string= "arpit";

 let letters= new Map();

 for(let i=0;i<string.length;i++)
 {
     let letter = string[i];

     if(!letters.has(letter))
     {
         letters.set(letter,1);
     }
     else{
         letters.set(letter, letters.get(letter)+1);
     }
 }

 console.log(letters);

 console.log("Implementing Set");

 let array= [90,36,90,66,36,40];
 let newSet= new Set(array);
 newSet.add(50);
 newSet.delete(36);
 console.log(newSet);

 //------------------------------------------------------------------------------------------------------------------//

 console.log ("Question 13:  Implementation of stack (using linked list)");
 console.log("Ans 13 : ");

let stack = new stackUsingLinkList();

stack.push(23);
stack.push(56);
stack.pop();
stack.push(10);
stack.push(25);
stack.push(100);
stack.pop();

console.log("Elememts in stack are ");
console.log( stack.toArray());
console.log("Is the Stack Empty : " + stack.isEmpty());
console.log("size of stack is : " + stack.size());
