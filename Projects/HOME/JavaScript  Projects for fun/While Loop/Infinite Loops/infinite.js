let flag = true;
let counter = 0;
while(flag === true){
  console.log(counter);
  counter+=1;
  if (counter === 37){   /* lines 6 and 7 will ensure that the program does not go in an infinite loop */
    break;
  }
}