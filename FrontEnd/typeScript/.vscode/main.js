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