// 1. Biggie Size - Given an array, write a function that changes all positive numbers in the array to the string "big".  Example: makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].
function bigArr(arr) {
  for (i = 0; i < arr.length; i++) {
    if (arr[i] > 0) {
      arr[i] = "big";
    }
  }
  console.log("Positive #s switch to 'big':", arr);
  return arr;
}
bigArr([-1, 3, 5, -5]);

console.log("************************************************");

// 2. Print Low, Return High - Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.
function printLowHigh(arr) {
  var low = 0;
  var high = 0;

  for (i = 0; i < arr.length; i++) {
    if (arr[i] < low) {
      low = arr[i];
    }
  }
  for (i = 0; i < arr.length; i++) {
    if (arr[i] > high) {
      high = arr[i];
    }
  }
  console.log("Low of array:", low, "High of array:", high);
  return arr;
}
printLowHigh([-1, 3, 5, -5, 10, -2, 4]);

console.log("************************************************");

// 3. Print One, Return Another - Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.
function print1Return1(arr) {
  console.log("Second-to-last value:", arr[arr.length - 2]);
  for (i = 0; i < arr.length; i++) {
    if (arr[i] % 2 != 0) {
      return arr[i];
    }
  }
}
print1Return1([-1, 3, 5, -5, 10, -2, 4]);

console.log("************************************************");

// 4. Double Vision - Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.
function doubleVision(arr) {
  doubleArr = [];

  for (i = 0; i < arr.length; i++) {
    arr[i] = arr[i] * 2;
    doubleArr.push(arr[i]);
  }

  console.log("Double array:", doubleArr);
  return arr;
}
doubleVision([1, 2, 3, 4, 5, 6]);

console.log("************************************************");

// 5. Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countPos(arr) {
  sum = 0;

  for (i = 0; i < arr.length; i++) {
    if (arr[i] > 0) {
      sum += 1;
    }
  }
  arr.splice(arr.length - 1, 1, sum);
  console.log("# of positives:", arr);
  return arr;
}
countPos([-1, 1, 1, 1]);

console.log("************************************************");

// 6. Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
function evenAndOdd(arr) {
  for (var i = 0; i < arr.length; i++) {
    if (arr[i] % 2 !== 0) {
      if (arr[i + 1] % 2 !== 0) {
        if (arr[i + 2] % 2 !== 0) {
          console.log("That's odd!");
        }
      }
    }
    if (arr[i] % 2 == 0) {
      if (arr[i + 1] % 2 == 0) {
        if (arr[i + 2] % 2 == 0) {
          console.log("Even more so!");
        }
      }
    }
  }
}
evenAndOdd([1, 1, 1, 2, 5, 7, 4, 4, 4, 5, 6, 8, 8]);

console.log("************************************************");

// ********// 7. Increment the Seconds - Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function incrementSeconds(arr) {
  for (i = 1; i < arr.length; i += 2) {
    // if (arr[i] % 2 != 0) {
    arr[i] = arr[i] + 1;
    // }
  }
  console.log("Increment seconds:", arr);
  return arr;
}
incrementSeconds([2, 9, 4, 1, 5, 8, 7, 7, 4]);

// function incrementSeconds1(arr) {
// 	for(let i = 0; i <= arr.length; i+=2) {
//     arr[i] = arr[i] + 1;
//     arr[i + 1] = arr[i] + 1
// }
// console.log("Increment seconds:", arr)
// return arr
// }

// incrementSeconds1([2,3,5,8,4]);

console.log("************************************************");

// 8. Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
function previousLengths(arr) {
  for (i = 1; i > 0; i--) {
    arr[i] = arr[i].length + 1;
    arr[i + 1] = arr[i] - 1;
  }
  console.log("previous lengths:", arr);
  return arr;
}
previousLengths(["hello", "dojo", "awesome"]);

console.log("************************************************");

// 9. Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven(arr) {
  var plus7 = [];

  for (i = 0; i < arr.length; i++) {
    plus7.push(arr[i] + 7);
  }
  console.log("Add seven array:", plus7);
  return arr;
}
addSeven([1, 2, 3]);

console.log("************************************************");

// 10. Reverse Array - Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
function reverse(arr) {
  var temp = 0;
  for (let i = 0; i < arr.length / 2; i++) {
    [arr[i], arr[arr.length - 1 - i]] = [arr[arr.length - 1 - i], arr[i]];
  }
  console.log("reverse array:", arr);
  return arr;
}
reverse([3, 1, 6, 4, 2]);

console.log("************************************************");

// 11. Outlook: Negative - Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].
function outlookNeg(arr) {
  var negArray = [];

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] > 0) {
      negArray[i] = arr[i] * -1;
    } else {
      negArray[i] = arr[i];
    }
  }
  console.log("Outlook: Negative array:", negArray);
  return negArray;
}
outlookNeg([1, -3, 5, -7, 8]);

console.log("************************************************");

// 12. Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
function alwaysHungry(arr) {
  let hungry = 0;

  for (i = 0; i < arr.length; i++) {
    if (arr[i] == "food") {
      console.log("yummy");
    } else if (arr[i] != "food") {
      console.log("I'm hungry");
    }
  }
}
alwaysHungry([1, 2, "food", 4, "food", 6]);

console.log("************************************************");

// 13. Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
function swapArr(arr) {
  for (i = 0; i < arr.length / 2; i++) {
    var temp = arr[0];
    arr[0] = arr[arr.length - 1];
    arr[arr.length - 1] = temp;
  }
  console.log("Swapped array:", arr);
  // return arr
}
swapArr([true, 42, "Ada", 2, "pizza"]);

console.log("************************************************");

// 14. Scale the Array - Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.  For example, scaleArray([1,2,3], 3) should return [3,6,9].
function scaleArr(arr, num) {
  for (i = 0; i < arr.length; i++) {
    arr[i] = arr[i] * num;
  }
  console.log("Scaled array:", arr);
}
scaleArr([1, 2, 3], 3);
