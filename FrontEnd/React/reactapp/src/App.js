import logo from './logo.svg';
//import lodemo from './bg-removed.png'
import './App.css';
import ClassCompo from './ClassCompo';
import NavbarReact from './navbar/NavbarReact';
import ReactFooter from './footer/ReactFooter';
import ContenIntroduction from './Content/ContenIntroduction';
import UserFunction from './UserFunction '


function App() {
  return (
    <div className="App">
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Alezz 
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
     
      <NavbarReact/>
      <ContenIntroduction/>
      <ReactFooter/>
      
      {/* <ClassCompo/> */}
      {/* <UserFunction/> */}
    </div>
  );
}

export default App;
