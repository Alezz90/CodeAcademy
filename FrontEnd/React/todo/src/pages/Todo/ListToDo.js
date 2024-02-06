import React, { useEffect, useState } from "react";
import { Link, useLocation, useNavigate, useParams } from "react-router-dom";

import axios from "axios";

export default function ListToDo() {
  const params=useParams();
  const [todos, setTodos] = useState({});

  useEffect(() => {
    //https://localhost:7040/api/ToDo/getListTodo
    axios.get(`https://localhost:7040/api/ToDo/getListTodo/`)
      .then((res) => setTodos(res.data))
      .catch(err => console.log(err))
  }, [])


  return (
    <div>
      <h2 className="card-title">Listing todos </h2>
      {todos.map((item,indx) => (
        <div key={item.id} className="w-75">
          <div className="card w-75 bg-transparent border border-dark rounded-3 m-3">
            <div className="card-body d-flex justify-content-between">
              <h3 className="card-title">{item.title}</h3>
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
