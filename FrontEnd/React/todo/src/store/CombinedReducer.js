import { combineReducers } from "redux";
import Langreducer from "./Reducer/Langreducer";


const combinedReducers = combineReducers({
    language : Langreducer, 
    
}
)
export default combinedReducers ;