var testArr = [6,3,5,1,2,4]

//Print values and sum

let sum = 0
for(let i = 0; i <testArr.length; i++){
        sum = sum + testArr[i]
console.log('Num',testArr[i], 'Sum', sum)
}




//Value * Position

for(let i = 0; i <testArr.length; i++){
    testArr[i] = (i * testArr[i])
}
console.log(testArr)
