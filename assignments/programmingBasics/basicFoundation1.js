// 1. Get 1 to 255 - Write a function that returns an array with all the numbers from 1 to 255.
function arr255() {
  var allNum = [];

  for (i = 1; i <= 255; i++) {
    allNum.push(i);
  }
  console.log(allNum);
}
arr255();

console.log("************************************************");

// 2. Get even 1000 - Write a function that would get the sum of all the even numbers from 1 to 1000.  You may use a modulus operator for this exercise.
function getEven() {
  var sumEven = 0;

  for (let i = 1; i <= 1000; i++) {
    if (i % 2 == 0) {
      sumEven = sumEven + i;
    }
  }
  console.log("Sum of even:", sumEven);
}
getEven();

console.log("************************************************");

// 3. Sum odd 5000 - Write a function that returns the sum of all the odd numbers from 1 to 5000. (e.g. 1+3+5+...+4997+4999).
function getOdd() {
  var sumOdd = 0;
  for (let i = 1; i <= 1000; i += 2) {
    sumOdd = sumOdd + i;
  }
  console.log("Sum of odd:", sumOdd);
}
getOdd();

console.log("************************************************");

// 4. Iterate an array - Write a function that returns the sum of all the values within an array. (e.g. [1,2,5] returns 8. [-5,2,5,12] returns 14).
function arrSum(arr) {
  let sum = arr[0];
  for (let i = 1; i < arr.length; i++) {
    sum = sum + arr[i];
  }
  console.log("Sum of values in array:", sum);
  return sum;
}
arrSum([-5, 2, 5, 12]);

console.log("************************************************");

// 5. Find max - Given an array with multiple values, write a function that returns the maximum number in the array. (e.g. for [-3,3,5,7] max is 7)
function arrMax(arr) {
  var max = arr[0];
  for (let i = 1; i < arr.length; i++) {
    if (max < arr[i]) {
      max = arr[i];
    }
  }
  console.log("Max:", max);
  return max;
}
arrMax([-3, 3, 5, 7]);

console.log("************************************************");

// 6. Find average - Given an array with multiple values, write a function that returns the average of the values in the array. (e.g. for [1,3,5,7,20] average is 7.2)
arr1 = [1, 3, 5, 7, 20];

function avgNum(arr) {
  let sum = 0;
  let avg = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  avg = sum / arr.length;
  console.log("Avg:", (avg = sum / arr.length));
  return avg;
}
avgNum(arr1);

console.log("************************************************");

// 7. Array odd - Write a function that would return an array of all the odd numbers between 1 to 50. (ex. [1,3,5, .... , 47,49]). Hint: Use 'push' method.
function oddArr() {
  var oddArr = [];

  for (i = 1; i <= 50; i += 2) {
    oddArr.push(i);
  }
  console.log("Odd num array:", oddArr);
}
oddArr();

console.log("************************************************");

// 8. Greater than Y - Given value of Y, write a function that takes an array and returns the number of values that are greater than Y. For example if arr = [1, 3, 5, 7] and Y = 3, your function will return 2. (There are two values in the array greater than 3, which are 5, 7).
function numGreater(arr, y) {
  var numGreater = 0;

  for (i = 0; i < arr.length; i++) {
    if (arr[i] > y) {
      numGreater++;
    }
  }
  console.log("# of values greater than y:", numGreater);
  return numGreater;
}
numGreater([1, 3, 5, 7], 3);

console.log("************************************************");

// 9. Squares - Given an array with multiple values, write a function that replaces each value in the array with the value squared by itself. (e.g. [1,5,10,-2] will become [1,25,100,4])
function squareArr(arr) {
  for (let i = 0; i < arr.length; i++) {
    arr[i] *= arr[i];
  }
  console.log("Squared array:", arr);
}
squareArr([1, 5, 10, -2]);

console.log("************************************************");

// 10. Negatives - Given an array with multiple values, write a function that replaces any negative numbers within the array with the value of 0. When the program is done the array should contain no negative values. (e.g. [1,5,10,-2] will become [1,5,10,0])
function negArr(arr) {
  for (i = 0; i < arr.length; i++) {
    if (arr[i] < 0) {
      arr[i] = 0;
    }
  }
  console.log("Zero out array:", arr);
}
negArr([1, 5, 10, -2]);

console.log("************************************************");

// 11. Max/Min/Avg - Given an array with multiple values, write a function that returns a new array that only contains the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])
function maxMinAvg(arr) {
  var max = 0;
  var min = 0;
  var sum = 0;
  var newArr = [];

  for (i = 1; i < arr.length; i++) {
    if (arr[i] > max) {
      max = arr[i];
    }
  }
  for (i = 0; i < arr.length; i++) {
    if (arr[i] < min) {
      min = arr[i];
    }
  }
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  let avg = sum / arr.length;
  newArr.push("Max:", max, "Min:", min, "Avg:", avg);
  console.log(newArr);
  return max;
  return min;
  return avg;
}
maxMinAvg([1, 5, 10, -2]);

console.log("************************************************");

// 12. Swap Values - Write a function that will swap the first and last values of any given array. The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).
function swapValues(arr) {
  let temp = arr[0];
  arr[0] = arr[arr.length - 1];
  arr[arr.length - 1] = temp;
  console.log("First/Last values swapped:", arr);
  return arr;
}
swapValues([1, 5, 10, -2]);

// Another way of doing it
// function swapValues(arr) {
//     [arr[0], arr[arr.length - 1]] = [arr[arr.length - 1], arr[0]]
//     console.log('First/Last values swapped:', arr)
//     return arr
// }
// swapValues([1,5,10,-2])

console.log("************************************************");

// 13.  Number to String - Write a function that takes an array of numbers and replaces any negative values within the array with the string 'Dojo'. For example if array = [-1,-3,2], your function will return ['Dojo','Dojo',2].
function result(arr) {
  for (i = 0; i < arr.length; i++)
    if (arr[i] < 0) {
      arr[i] = "Dojo";
    }
  console.log("Dojo replace negatives:", arr);
  return arr;
}

result([-1, -3, 2]);
