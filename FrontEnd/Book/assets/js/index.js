let Seacrchbutton  = document.getElementById("Search");
let Addbutton  = document.getElementById("Add");
let Deletebutton  = document.getElementsByClassName("dlt");
let SearchText = document.getElementById("SearchText");
let BookList  = document.getElementById("Book");
let BookName = document.getElementById("BookName");

let HideButton = document.getElementById("Hide");


console.log(BookName);

Addbutton.addEventListener("click",(e)=>{
    let name = BookName.value;
    let card = document.createElement("div")
    let newElement= document.createElement("div");
    let title = document.createElement("h3");
    let DBN = document.createElement("a");
    title.textContent=name;
    DBN.textContent= "Delete";
    newElement.appendChild(title);
    newElement.appendChild(DBN);
    card.appendChild(newElement);
    BookList.appendChild(card);
    DBN.classList="btn btn-danger dlt";
    title.classList="card-title";
    newElement.classList="card-body d-flex justify-content-between";
    card.classList="card w-75 bg-transparent border border-dark rounded-3 m-3";
    BookName.value="";
 
});

//delete element
BookList.addEventListener("click",(e)=>{
    if(e.target.classList=="btn btn-danger dlt"){
        e.target.parentElement.parentElement.remove();
    }
})
// hide 
let flag =true
HideButton.addEventListener("click", (e)=>{
    if(flag == true){
        BookList.style.display = "none";
        HideButton.textContent = "Display";
        flag=false;
    }else if(flag == false){
        BookList.style.display = "block";
        HideButton.textContent = "Hide";
        flag=true;
    }
})
//"input"
Seacrchbutton.addEventListener("click", (e)=>{
    
    let input = SearchText.value;
    input = input.toLowerCase();
    
    let x = document.getElementsByTagName("h3");
    
   
    for (i = 0; i < x.length; i++) {
      if (!x[i].innerHTML.toLowerCase().includes(input)) {
        let com = x[i];
        com.parentElement.style.display="none";
       // x[i].style.display = "none";
      }
      else {
        x[i].style.display = "block";
      }
    }
})
