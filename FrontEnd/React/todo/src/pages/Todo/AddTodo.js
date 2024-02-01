import React, { useState, useEffect } from 'react';
import axios from 'axios';

const TodoList = () => {
  const [todos, setTodos] = useState([]);
  const [newTodo, setNewTodo] = useState({
    title: '',
    description: ''
  });

  useEffect(() => {
    // Fetch todos from the API when the component mounts
    axios.get('https://localhost:7040/api/ToDo/')
      .then(response => setTodos(response.data))
      .catch(error => console.error('Error fetching todos:', error));
  }, []);

  const addTodo = () => {
    if (newTodo.title.trim() === '' || newTodo.description.trim() === '') {
      alert('Please enter both title and description for the todo.');
      return;
    }

    // Make a POST request to add a new ToDo
    axios.post('https://localhost:7040/api/ToDo/createTodo', newTodo)
      .then(response => {
        setTodos([...todos, response.data]);
        setNewTodo({
          title: '',
          description: ''
        });
      })
      .catch(error => console.error('Error adding todo:', error));
  };

  return (
    <div>
      <h2>Todo List</h2>
      
      <ul>
        {todos.map(todo => (
          <li key={todo.id}>
            <strong>{todo.title}</strong>: {todo.description}
          </li>
        ))}
      </ul>

      <div className=" container form-inline d-flex m-3">
        <input
          type="text"
          className="form-control"
          placeholder="Enter title"
          value={newTodo.title}
          onChange={(e) => setNewTodo({ ...newTodo, title: e.target.value })}
        />
        <input
          type="text"
          className="form-control"
          placeholder="Enter description"
          value={newTodo.description}
          onChange={(e) => setNewTodo({ ...newTodo, description: e.target.value })}
        />
        <button onClick={addTodo} className="btn btn-primary">Add Todo</button>
      </div>
    </div>
  );
};

export default TodoList;
