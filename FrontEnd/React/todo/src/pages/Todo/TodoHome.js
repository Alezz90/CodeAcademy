import React from 'react'
import image from './HH.jpg'
import './TodoHome.css'

export default function TodoHome() {
  return (
 
        <div className='container'>
        <div class="Card">
            <img
              src={image}
              alt="MyImage"
            />
            <div className="textIntrodactio">
              <h1>ALEZZ</h1>
              <h2>Full stack developer</h2>
              <br />
            
              <a href="/AddTodDo" className='btn btn-success'>Add To Do</a>
            </div>
          </div>

    </div>
  )
}