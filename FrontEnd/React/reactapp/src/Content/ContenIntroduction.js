import React from 'react'
import image from './image/GirlBaby.jpg'
import './ContenIntroduction.css';
export default function ContenIntroduction() {
  return (
    <div className='container'>
        <div class="Card">
            <img
              src={image}
              alt="MyImage"
            />
            <div class="textIntrodactio">
              <h1>ALEZZ</h1>
              <h2>Full stack developer</h2>
              <br />
              {/* <p>
                Hello! 👋 I'm a passionate full-stack developer specializing in
                the .NET framework.also I excel in crafting robust applications.
                On the front end, I thrive with HTML, SCSS, and JavaScript, and
                I've delved deep into the intricacies of Angular. Whether it's
                back-end development or creating captivating front-end
                experiences, I'm dedicated to delivering top-notch solutions.
                Let's collaborate and bring your ideas to life!"
              </p> */}
              <a href="#" className='btn btn-success'>New List</a>
            </div>
          </div>
    </div>
  )
}
