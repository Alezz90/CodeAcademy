
let Sub = (x,y, ...args)=>{
    let total = x-y;
    if(args.length !=0){
        for(let i=0; i<args.length;i++){
              total =  total  - args[i];
        }
    }
    return total;
}
console.log(Sub(5,3));
console.log(Sub(5,3,10,15,2));

let array1 = [10,9,8];
let array2 = [...array1,20,15];
console.log(array2);
