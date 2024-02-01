let title = document.querySelector('#title');
let price = document.querySelector('#price');
let taxes = document.querySelector('#taxes');
let discount =document.querySelector("#discount");
let ads = document.querySelector('#ads');
let total = document.querySelector('#total');
let count = document.querySelector('#count');
let category = document.querySelector('#category');
let submit = document.querySelector('#submit');
let Delete = document.querySelector("#Delete");
let mood="create";
let temp;

console.log(submit);
//get total

function getTotal(){
if(price.value !=''){
    let result =(+price.value + +taxes.value + +ads.value) - +discount.value;
    total.innerHTML =result;
    total.style.background='#3c9660';
    total.style.color='#ffff';
}else{
    total.innerHTML="";
    total.style.color='red';
}

}
//create product
 let dataProduct;
if(localStorage.product != null){
    dataProduct = JSON.parse(localStorage.product);
}else{
    dataProduct = [];
}
//submit.oncllick = function() {
submit.addEventListener('click',()=>{
    let newProduct={
        title:title.value.toLowerCase(),
        price:price.value,
        taxes:taxes.value,
        discount:discount.value,
        ads:ads.value,
        total:total.innerHTML,
        count:count.value,
        category:category.value.toLowerCase(),
    }
    if(title.value!="" && price.value != "" && taxes !="" && count != "" && category !=""){
        if(mood == 'create'){
            for(let i=0; ii< newProduct.count;i++){
                dataProduct.push(newProduct);
            }
        }else{
            dataProduct.push(newProduct);
        }dataProduct[temp]=newProduct;
        mood='create';
        submit.innerHTML = 'create';
    }else{
        clearData();
    }
    
    localStorage.setItem('product',JSON.stringify(dataProduct))
    showProduct();
    clearData();
})

    
//save localally
//clear 
function clearData(){
    title.value='';
    price.value='';
    taxes.value='';
    discount.value='';
    ads.value='';
    total.value='';
    count.value='';
    category.value='';
    
}
//read
function showProduct(){
 let table =" ";
 for(let i =0; i<dataProduct.length; i++){
   console.log=(dataProduct[i].title);
    table += `<tr>
    <td>${i}</td>
    <td>${dataProduct[i].title}</td>
    <td>${dataProduct[i].price}</td>
    <td>${dataProduct[i].taxes}</td>
    <td>${dataProduct[i].ads}</td>
    <td>${dataProduct[i].discount}</td>
    <td>${dataProduct[i].total}</td>
    <td>${dataProduct[i].category}</td>
    <td>
    <a class="btn bg-primary" id="Update">Update</a>
    <a class="btn bg-danger delete"  id="Delete" onclick="deleteBut(${i})" >Delete</a>
     </td>
    </tr>`;

 }
 //console.log(table);
 document.getElementById('tobody').innerHTML = table;
 let btnDelete = document.getElementById('');
 if(dataProduct.lenght>0){
    btnDelete.innerHTML=
    `<a class="btn bg-danger delete"  id="Delete" onclick="deleteAll()" >Delete All</a>`
 }else
 btnDelete.innerHTML="";
 
}
//count

//delete
Delete.addEventListener("click", (e)=>{
/*if(e.target.classList=="btn btn-danger dlt"){
        e.target.parentElement.parentElement.remove();
    }*/
if(e.target.classList =="btn bg-danger delete"){
    e.target.parentElement.parentElement.remove();
}
})

function deleteBut(i){
dataProduct.splice(i,1);
localStorage.product=JSON.stringify(dataProduct);
showProduct();
}
//deleteAll
function deleteAll(){
    localStorage.clear();
    dataProduct.splice(0);
    showProduct()
}
//update

//search
//clean data