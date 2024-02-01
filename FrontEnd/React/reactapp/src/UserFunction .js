import React, { useEffect, useState } from 'react';
import { Placeholder } from 'react-bootstrap';

export default function UserFunction() {
    // Hook extension
   // const [Name, setName] = useState("Alezz");
    const [ChangInfo, setChangInfo] = useState ({
        name: "Azza",
        age:"33",
    })
 
const changeName=(e)=>{
    setChangInfo(prevState => ({
        ...prevState,
        name: e.target.value
    }));
}
const changeage=(e)=>{
    setChangInfo(prevState => ({
        ...prevState,
        age: e.target.value
    }));
}
 // const changename = (name) => {
    //     setName(name);
    // }
    useEffect(() => {
        console.log("effect used on load");
    }, []); 

    return (
        <div>
            {/* <UserFunction name={useState.Name} ></UserFunction> */}
            <h3>Welcome</h3>
            <h2> {ChangInfo.name} </h2>
            <h2> {ChangInfo.age} </h2>
            <input type='txet' onChange={(e)=>changeage(e)} placeholder='=age'/>
            <input type='text' onChange={(e)=>changeName(e)} Placeholder="Name"/>
            {/* <button onClick={() => changename("Subrin")}>Change</button>
            <button onClick={()=>changename("Halima")}>Change</button> */}
        </div>
    );
}

