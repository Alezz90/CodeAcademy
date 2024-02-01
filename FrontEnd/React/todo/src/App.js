import logo from './logo.svg';
//React Imports 

//Styling Imports 
import 'bootstrap/dist/css/bootstrap.min.css';

import './App.css';
//Componenets Imports 
import Navbar from './main/navbar/NavbarReact';
import Footer from './main/footer/ReactFooter';
import AddTodo from './pages/Todo/AddTodo';
import TodoHome from './pages/Todo/TodoHome';
import TodoList from './pages/Todo/ListToDo';
//routing Imports 
import { BrowserRouter as Router , Routes , Route } from 'react-router-dom';
import NotFound from './pages/NotFound';
import { useSelector } from 'react-redux';


function App() {
  const lang  = useSelector((state) => state.lang);
  return (
    <>
      <div className='' dir={lang === "en" ? "ltr" :"rtl"}></div>
  <div className=''>
   <Router>
   <Navbar />
      <Routes>
      
        <Route path='/' element={<TodoHome />} />
        <Route path='/TodoList' element={<TodoList />} />
        <Route path='/AddTodDo' element={<AddTodo />} />
        
        <Route path='*' element= {<NotFound />}  />
      </Routes>
      <Footer />
   </Router>
  </div>
  
  </>
  );
}

export default App;
