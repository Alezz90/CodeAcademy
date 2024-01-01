

let cityZip=document.getElementById("cityZip");
//6182e1a8c845975d69d912eb1f9a8a1e
const apikey = "6182e1a8c845975d69d912eb1f9a8a1e";
let cityId ="London"




cityZip.addEventListener('keypress', (event) => {
  
  if (event.key === 'Enter') {
    let city = cityZip.value;
    fetch(`http://api.openweathermap.org/data/2.5/weather?q=${city}&units=metric&appid=${apikey}`)
  .then (Response => Response.json())
  .then(data =>{
    wetherDegre = data.main.temp;
    description = data.weather[0].description;
   WeatherwindSpeed = data.wind.speed;

    const windspeed = document.querySelector('#windspeed');
    windspeed.innerHTML = WeatherwindSpeed;
    const wetherTem= document.querySelector('#wetherDegre');
    wetherTem.innerHTML = wetherDegre;
    const name = document.querySelector('#name');
    name.innerHTML = description;
console.log(data)
 })
  
.catch(err => console.log(err))
  }
});
///////////////////////////////////////////////////////////////////////////



/*let city = "12345";
fetch(baseURL + city + apikey)
.then (Response => Response.json())
.then(data => console.log(data))   
.catch(err => console.log(err))
*/
/*
let user = prompt("Enter github user name ")
fetch("https://api.github.com/users/" + user)
.then (Response => Response.json())
//.then(data => console.log(data))
.then(data => {
    result.name = data.login;
    result.id = data.id;

    const usernameElements = document.querySelectorAll('.username');
    usernameElements.forEach(element => {
      element.textContent = result.name;
    });

   })
   
.catch(err => console.log(err))
*/