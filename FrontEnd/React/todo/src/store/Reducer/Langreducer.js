import React from 'react'
const initialState={
    lang: "en"
}

const LangugechangeReducer= (state=initialState, action)=>{
    switch(action.type){
        case "CHANGELANGUGE":
            return{
                ...state,
                lang:action.payload
            };
            default:
                return state;
    }
};
export default LangugechangeReducer;