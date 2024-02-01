
let flage = false;
const playbutton = document.getElementById('Playagin');

playbutton.style.display='none';
let randomNumber = Math.floor(Math.random() * 100);
console.log(randomNumber);

function checkGuess() {
    let Guess = parseInt(document.getElementById('Guess').value);
    const Result = document.getElementById('message');
  
    if (isNaN(Guess)) {
      messageElement.textContent = 'Please enter a valid number.';
    } else {
      if (Guess === randomNumber) {
        Result.className="alert alert-success" ;
        Result.textContent = 'Congratulations! You guessed the correct number!';
        playbutton.style.display='block';
        document.getElementById('submit').style.display='none'
      } else if (Guess < randomNumber) {
        Result.textContent = 'Try a higher number';
        Result.className='alert alert-primary';
      } else {
        Result.className='alert alert-primary';
        Result.textContent = 'Try a lower number';
      }
    }
  }

function playAgin(){

    window.location.reload();
}