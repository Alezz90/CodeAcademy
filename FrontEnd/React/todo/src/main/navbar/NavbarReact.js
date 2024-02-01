import React from 'react';
import './NavbarReact.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import changeLang from '../../store/Action/Langaction'
import { useDispatch, useSelector } from 'react-redux'

export default function NavbarReact() {
  const lang   = useSelector((state) =>state.lang)
  const dispatch = useDispatch();

  const ChangeLanguage = (payload)=>{
    dispatch(changeLang(payload))
  }
  return (
    <div>
   <Navbar expand="lg" className="NavCl">
    <Container>
      <Navbar.Brand href="/">full Stuck Developer</Navbar.Brand>
      <Navbar.Toggle aria-controls="basic-navbar-nav" />
      <Navbar.Collapse id="basic-navbar-nav">
        <Nav className="me-auto">
      
          <Nav.Link className="nav-link active" aria-current="page" href="/TodoList">To do list</Nav.Link>
          <Nav.Link href="/AddTodDo">Add</Nav.Link>
        
          <button type="button" onClick={lang ==="en" ?  ()=>ChangeLanguage("ar") : ()=>ChangeLanguage("en") } className="btn btn-primary position-relative">
  Language
  <span className="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
    {lang}
    <span className="visually-hidden">unread messages</span>
  </span>
</button>
        </Nav>
      </Navbar.Collapse>
    </Container>
  </Navbar>
</div>
  )
}
