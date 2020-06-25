import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink, Nav, UncontrolledDropdown, DropdownToggle, DropdownMenu, DropdownItem } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import './stle.css';





export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
    }



  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
      return (
          <header>
              <nav class="navbar navbar-expand-lg navbar bg-dark text-white">
                  <div class="containerr">
                      <a class="navbar-brand text-white " href="#">Автомойка</a>

                      <li class="nav-item dropdown bg-dark ent1 text-dark col-md-offset-3">
                          <a href="/Entry"><button  class="btn btn-secondary ent " type="button" >
                              Войти
            </button></a>
                      </li>
                      <li class="nav-item dropdown ent2 bg-dark text-dark  col-md-offset-3">
                          <a href="/Registration"><button class="btn btn-secondary ent  " type="button">
                              Регистрация
            </button></a>
                      </li>
                  </div>
              </nav>

              <nav class="nav nav-pills flex-column flex-sm-row">
                  <a class="flex-sm-fill text-sm-center nav-link bg-info text-dark rounded-0 font-weight-bold" href="/home">КОМПАНИЯ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/akcii">АКЦИИ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/news">НОВОСТИ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/Job" >УСЛУГИ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/order" >ОНЛАЙН ЗАПИСЬ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/job" >ВАКАНСИИ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/otzv" >ОТЗЫВЫ</a>
                  <a class="flex-sm-fill text-sm-center nav-link bg-dark text-light rounded-0 font-weight-bold" href="/kontacts" >КОНТАКТЫ</a>
              </nav>
          </header>
      );
  }
    }

