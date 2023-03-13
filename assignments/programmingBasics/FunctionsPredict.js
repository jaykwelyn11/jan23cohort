// Predict the Output

// Predict #1:
// Function prints 'Hello' since it is "returning" and ending function at that point. So when console.log(word) is done, it takes the var word = greeting() and starts the function.
// Final print is - "Hello"

function greeting() {
  return "Hello";
  console.log("World");
}

var word = greeting();
console.log(word);

console.log("*************************");

// Predict #2:
// Function is called twice for 'var result1' and 'var result2'
// Function is called for result1: Function begins by printing "Summing Numbers!" on one line; "num1 is:" + num1 of result1 on second line; the third line will have "num2 is:" + num2 of result1;
// Function is called for result2: Fourth line will repeat "Summing Numbers!"; fifth line will repeat "num1 is:" + num1 for result2; sixth line will repeat "num2 is:" + num2 for result2;
// last two lines printed are results of the called function for var result1 and  var result2

function add(num1, num2) {
  console.log("Summing Numbers!");
  console.log("num1 is: " + num1);
  console.log("num2 is: " + num2);
  var sum = num1 + num2;
  return sum;
}

var result1 = add(3, 5);
var result2 = add(4, 7);
console.log(result1);
console.log(result2);

console.log("*************************");

// // Predict #3
// Nothing will print here because the function is never called.
// If a parameter was called, it would loop through for statement and if it ever was presented with 5 exactly, it would print "High Five!", any other number would just be printed as i.

function highFive(num) {
  for (var i = 0; i < num; i++) {
    if (i == 5) {
      console.log("High Five!");
    } else {
      console.log(i);
    }
  }
}

console.log("*************************");
