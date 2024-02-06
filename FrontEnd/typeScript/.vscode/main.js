//import
import {IPrepare} from "./models/prepare.model.ts"
import {ICard} from "./models/card.model.ts"
//#region varible
const prepare =IPrepare={};
prepare.cards =[];
prepare.progress =0;
prepare.fullTrack = new Audio("");
prepare.flipAudio = new Audio("");
prepare.goodAudio = new Audio("");
prepare.failAudio = new Audio("");
prepare.gameOverAudion = new Audio("");
prepare.fullTrack.loop =true;

const numberOfCards =20;
const temNumber =[];
let cardsHtmlContent ='';
//# endregion
//#region Function 
 const getRandomInt =(min,max) =>{
    let result: number;
    let exists = true;
    min = Math.ceil(min);
    max = Math.floor(max);
    while(exists){
        result = Math.floor(Math.random()*(max-min + 1))+min;
        if(!tempNumbers.find(no => no === result.toString())){
            exists =false;
            tempNumbers.push(result.toString());
        }
    }return result;
 } 
 const toggleFlip =(index) =>{
    prepare.fullTrack.play();
    const card = prepare.cards[index];
    if(!card.flip && card.clickable){
        flip(card,index);
        selectCard(card,index);
    }
 }
 const flip =(card: ICard,index:number)=>{
    prepare.flipAudio.play();
    if(card){
        card.flip = card.flip=== ''? 'flip':'';
        document.getElementById('card-flip-${index}').classList.value = card.flip;
    }
 }
 const selectCard =(card:ICard,index:number)=>{
 if(!prepare.selectCard_1){
    prepare.selectCard_1 = card;
    prepare.selectedIndex_1 = index;
 }
 if(prepare.selectCard_1 && prepare.selectCard_2){
    if(prepare.selectCard_1.src === prepare.selectCard_2.src){
        prepare.selectCard_1.clickable = false;
        prepare.selectCard_2.clickable =false;
        prepare.selectCard_1 =null;
        prepare.selectCard_2 = null;
        stopAudio(prepare.failAudio);
        stopAudio(prepare.goodAudio);
        prepare.goodAudio.play();
        changeProgress();
        checkFinish();
    }else{
        
    }
 }
 }
 //#endregion
 //#region Game Logic
 for(let index =0; index<numberOfCards/2;index++){
    prepare.cards.push({
        id:getRandomInt(0,numberOfCards),
        src:'../assets/خلفيات-وردية-للبنات-18.jpg',
        flip:'',
        clickable:true,
        index
    });
    prepare.cards.push({
        id:getRandomInt(0,numberOfCards),
        src:'../assets/خلفيات-وردية-للبنات-18.jpg',
        flip:'',
        clickable:true,
        index
    });
 }
 prepare.cards.sort((a,b)=> a.id > b.id ? 1:-1);
 prepare.cards.array.forEach((item,index) => {
    cardsHtmlContent += `  
    <span class = "col-sm-3 col-lg-2">
    <!--Card Flip-->
    <div onclick="toggleFlip(${index})" class="card-flip">
    <div id = "card-flip-${index}">
    <div class="front">
    <!-- content -->
    <div class="card">
      <img class="card-image" src="../assets/خلفيات-وردية-للبنات-18.jpg" alt="Loding">
      <span class="card-content">${index+1}</span>
      </div>
      </div>
      <div class="back">
      <!--back content-->
      <div class="card">
      <img src="../assets/${item.index}.jpg" alt="frontImage" data-holder-rendered= style="height:120px;width:100%;display:block;">
      </div>
      </div>
      </div>
      </div>
      <!-- End card Flip -->
      </span>
       `;
 });
 
document.getElementById('cards').innerHTML = cardsHtmlContent;
//#endregion