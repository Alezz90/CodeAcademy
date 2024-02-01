


let Displ = document.getElementById("productTable");
let table="";
async function getproduct(){
   
    const res = await fetch(`https://fakestoreapi.com/products`);
    const answer = await res.json();
   
    //console.log(answer);
    return  answer;
   }  
    //getproduct(); 
    //let id = 1;
   let Pro=  getproduct() ;
console.log(  Pro);
  
  
    async function displayData(){
        let productList = await getproduct();   
        
        for(let i =0 ; i < productList.length ; i++){
            console.log("call " + i)
             console.log(productList[i].id)
      

     table += `<table class="table">
    <thead>
      <tr>
        <th scope="col">ID</th>
        <th scope="col">Title</th>
        <th scope="col">Price</th>
        <th scope="col">Edit</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <th scope="row">1</th>
        <td>${productList[i].ID}</td>
        <td>${productList[i].title}</td>
        <td>${productList[i].price}</td>
      </tr>`
     
    }
    Displ.innerHTML = table;
    }displayData();

// async function displayData(){
//     let productList = await getproduct();   
   
// for(let i =0; i<productList.lenght;i++){
//     console.log(productList);
//  table += `<table class="table">
// <thead>
//   <tr>
//     <th scope="col">ID</th>
//     <th scope="col">Title</th>
//     <th scope="col">Price</th>
//     <th scope="col">Edit</th>
//   </tr>
// </thead>
// <tbody>
//   <tr>
//     <th scope="row">1</th>
//     <td>${productList[i].ID}</td>
//     <td>${productList[i].title}</td>
//     <td>${productList[i].price}</td>
//   </tr>`

// }
// Displ.innerHTML = table;
// }displayData();