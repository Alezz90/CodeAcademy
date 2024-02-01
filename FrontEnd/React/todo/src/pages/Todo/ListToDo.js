import React, { useEffect, useState } from "react";
import { Link, useLocation, useNavigate, useParams } from "react-router-dom";

import axios from "axios";

export default function ListToDo() {
  const [todos, setTodos] = useState([]);

  useEffect(() => {
    //https://localhost:7040/api/ToDo/getListTodo
    axios.get("https://localhost:7040/api/ToDo/getListTodo", {
     /*   params: {
          limit: 5,
        },*/
      })
      .then((res) => setTodos(res.data))
      .catch((err) => console.log(err));
  }, []);

/*  return (
    <div>
      <h2 className="card-title">Listing todos </h2>
      {todos.map((item) => (
                <Link to={`/getListTodo`}>
                   <li key={item.ID}></li>
      <div className=" w-75">
        <div className="card w-75 bg-transparent border border-dark rounded-3 m-3">
          <div className="card-body d-flex justify-content-between">
            <h3 className="card-title">
                {item.Title}
            </h3>
            <a href="/AddTodDo" className="btn btn-danger">
              <span className="material-symbols-outlined">delete</span>
            </a>

            <a href="/AddTodDo" className="btn btn-primary">
              <span className="material-symbols-outlined">Update</span>
            </a>
          </div>
        </div>
      </div>
      </Link>
              ))}
    </div>
  );*/
  return (
    <div>
      <h2 className="card-title">Listing todos </h2>
      {todos.map((item) => (
        <div key={item.ID} className="w-75">
          <div className="card w-75 bg-transparent border border-dark rounded-3 m-3">
            <div className="card-body d-flex justify-content-between">
              <h3 className="card-title">{item.Title}</h3>
              {/* Use Link for navigation, passing the todo ID as a parameter */}
              <Link to={`/AddTodo/${item.ID}`} className="btn btn-primary">
                Update
              </Link>
              <button
                
                className="btn btn-danger"
              >
                Delete
              </button>
            </div>
          </div>
        </div>
      ))}
    </div>
  );
}
