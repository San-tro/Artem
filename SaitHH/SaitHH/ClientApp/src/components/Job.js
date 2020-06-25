import React, { Component } from 'react';
import { Pagination, PaginationItem, NavLink, PaginationLink } from 'reactstrap';
import './stle.css';
const fakeBooks = [
    {
        name: 'Nordway Combi',
        money: 1199
    }
];

export class Job extends Component {
    static displayName = Job.name;

    constructor(props) {
        super(props);
        this.state = {
            service: fakeBooks,
            countView: 6,
            countPagination: 1,
            sortValue: 'down'
        };
    }

    componentDidMount() {
        this.getCarts();
    }


    onClickPagination = (str) => {
        const {
            service,
            countView
        } = this.state;

        const maxStep = Math.ceil(service.length / countView);
        if (str !== 0 && str <= maxStep) {
            this.setState({ countPagination: str })
        }
    }

    testPagination = (props) => {
        return (
            <Pagination size="sm" aria-label="Page navigation example">
                <PaginationItem>
                    <PaginationLink previous onClick={() => this.onClickPagination(this.state.countPagination - 1)} />
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(1)}>
                        1
</PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(2)}>
                        2
</PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(3)}>
                        3
</PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(4)}>
                        4
</PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(5)}>
                        5
</PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink next onClick={() => this.onClickPagination(this.state.countPagination + 1)} />
                </PaginationItem>
            </Pagination>
        );
    };



    renderservices = () => {
        const {
            service,
            countView,
            countPagination,
        } = this.state;

        const minValue = countView * (countPagination - 1);//с какой карточки начинается стр
        const maxValue = countView * countPagination;

        return service.map((service, i) => {
            if (minValue <= i && i < maxValue) {
                return (
                    <div class="col-md-4 information" >
                        <div class="into">
                            <h2 >
                                {service.name}
                            </h2>
                            <p class="costt">Стоимость: {service.cost}</p>
                            <p><a class="btn" href="http://coursach/public/job/18" role="button">Подробно»</a></p>
                        </div>
                    </div>
                );
            }
        })
    }

    async getCarts() {
        const response = await fetch('Jobs');
        const data = await response.json();
        this.setState({ service: data });
    }



    render() {
        return (
            <div>

                <div id="app" >





                    <div id="main-content" class="container">
                        <div class="row">
                            <div class="col-md-3 " id="filter" >
                                <div class="filter-sidebar filt" >
                                    <div class="row card-body py-2 mb-3  up">
                                        <h4><i class="fa fa-car "></i> Фильтры </h4>
                                    </div>
                                    <form method="post" action="http://coursach/public/home">
                                        <input type="hidden" name="_token" value="wRsI4TfowuQu36DyB6AzHBUMAYpEVAjOAlr2BPv8" />
                                        <div class="form-group">
                                            <select class="form-control" id="conditionsselect1" name="name">
                                                <option value="" disabled selected>Седан</option>
                                                <option value="Верстальщик">Внедорожник </option>
                                                <option value="Веб-дизайнер">Купе</option>
                                                <option value="Тестировщик">Универсал</option>
                                            </select>
                                        </div>
                                        <div class="form-group">
                                            <select class="form-control" id="conditionsselect2" name="experience">
                                                <option value="" disabled selected>Мойка кузова</option>
                                                <option value="Нет опыта">Чистка солона</option>
                                                <option value="От 1 года до 3 лет">Чистка солона</option>
                                            </select>
                                        </div>
                                        <div class="form-group">
                                            <select class="form-control" id="make1" name="shedule">
                                                <option value="" disabled selected>Экспресс</option>
                                                <option value="Полный день">Обычная</option>
                                            </select>
                                        </div>
                                        <div class="form-group">
                                            <select class="form-control" id="make1" name="education">
                                                <option value="" disabled selected>Доп услуги</option>
                                                <option value="Неполное среднее">Промыв кондиционера</option>
                                            </select>
                                        </div>
                                        <div class="form-group">
                                            <p class="form-group" >Цена от</p>
                                            <input type="number" class="form-control" id="mileage1" name="money1" />
                                        </div>

                                        <div class="form-group">
                                            <p class="form-group" >Цена до</p>
                                            <input type="number" class="form-control" id="mileage1" name="money2" />
                                        </div>


                                        <button type="submit" href="#" class="btn btn-primary">Найти</button>
                                        <div class="pb-3">
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <main role="main" class="col-md-9" >

                                <div class="container">
                                    <div class="row" >
                                        {this.renderservices()}
                                    </div>
                                </div>
                                {this.testPagination()}
                            </main>
                        </div>
                    </div>
                </div>
                <div class="row">

                </div>

                <footer class="page-footer font-small blue fot" >

                    <div class="footer-copyright text-center py-3" >© 2020 Copyright:
        <a href="">TMNWork</a>
                    </div>


                </footer>

                <script src="http://coursach/public/js/app.js"></script>
                <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
                <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
                <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
                <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.0/jquery.min.js"></script>
                <script src="js/maskedinput.js"></script>

            </div>
        );
    }
}