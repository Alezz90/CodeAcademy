import React from "react";
import UserFunction  from './UserFunction ';
class ClassCompo extends React.Component{
    constructor(){
        super();
        this.state ={
            name :"ALezz",
        
        }
    }
       changename = (name)=>{
            this.setState({
                name,
            })
        }
    
    render(){
        return(
            <>
           <UserFunction name={this.state.name} ></UserFunction>
            <button onClick={()=>this.changename("Subrin")}>Change</button>
            <button onClick={()=>this.changename("Halima")}>Change</button>
            </>
        );
    }
    
}
export default ClassCompo ;