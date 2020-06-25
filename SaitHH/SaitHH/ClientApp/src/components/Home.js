import React, { Component } from 'react';
import './stle.css';
import Deny from './Deny.jpg';

export class Home extends Component {
  static displayName = Home.name;

  render () {
      return (
          <div>

             

              <form>
                  <div>
                      <div class="container col-6" >

                          <img src="" />
                          <input class="jpg" src={Deny} type="image" />

                          <i> "Мы больше заботимся о людях, чем о транспортных средствах, которыми они управляют. Удовлетворенность  наших клиентов самое важное для нас. Мы стремимся помочь нашим клиентам сэкономить деньги, предоставить им лучший сервис и услуги в нашей отрасли. Мы также стремимся продолжать разработку экологически чистых продуктов, которые помогают улучшить нашу жизнь."</i>
                      </div>
                  </div>
              </form>

          </div>
      );
  }
}
