// //Predict 1: 
// // Lists the array value at each index going up until 7; basically relisting the array since console.log(arr[i])

var arr = [8,6,7,5,3,0,9]
for(var i = 0; i < arr.length; i++){
    console.log(arr[i])
}

//8
//6
//7
//5
//3
//0
//9




//Predict 2: 
//Lists the array value at each index starting with index 0 (7) and going through each index in the array length. [7] prints each index if it is divisible by 2 with no remainder; else console will print "That's odd".

var arr = [7,3,8,4,2,0,1];
for(var i = 0; i < arr.length; i++){
    if(arr[i] % 2 == 0) {
        console.log(arr[i]);
    }
    else {
        console.log("That's odd!");
    }
}

//That's odd!
//That's odd!
//8
//4
//2
//0
//That's odd!




//Predict 3:
//There is an array given and goes through for loop to determine new values. newArr given that is empty.
// Loop i starts at 0 and goes through length of array increasing by 1 each loop
// for loop checks if value in array is either less than 0; ==0; or more than 0.
// If less than zero value is "pushed" to newArray and multiplied by -1
// If ==0, current value of i becomes "Zero"
// If else then current value of i * -1;

var arr = [1,3,8,-5,0,-2,4,-1];
var newArr = [];
for(var i = 0; i< arr.length; i++){
    if(arr[i] < 0){
        newArr.push(arr[i]);
        arr[i] = arr[i] * -1;
    }
    else if(arr[i] == 0){
        arr[i] = "Zero";
    }
    else{
        arr[i] = arr[i] * -1;
    }
}
console.log(arr);
console.log(newArr); 

// //arr = [-1,-3,-8,5,'Zero',2,-4,1]
// //newArr = [-5,-2,-1]