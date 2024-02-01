import React from 'react';
import './NavbarReact.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';

export default function NavbarReact() {
  return (
    <div>
   <Navbar expand="lg" className="NavCl">
    <Container>
      <Navbar.Brand href="#home">full Stuck Developer</Navbar.Brand>
      <Navbar.Toggle aria-controls="basic-navbar-nav" />
      <Navbar.Collapse id="basic-navbar-nav">
        <Nav className="me-auto">
          <Nav.Link href="#home">Home</Nav.Link>
          <Nav.Link href="#link">Skills</Nav.Link>
          <NavDropdown title="Projct" id="basic-nav-dropdown">
            <NavDropdown.Item href="#action/3.1">Clinc sysem</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.2">
             Space booking
            </NavDropdown.Item>
            <NavDropdown.Item href="#action/3.3">To di o list</NavDropdown.Item>
            <NavDropdown.Divider />
            <NavDropdown.Item href="#action/3.4">
              Separated link
            </NavDropdown.Item>
          </NavDropdown>
        </Nav>
      </Navbar.Collapse>
    </Container>
  </Navbar>
</div>
  )
}
