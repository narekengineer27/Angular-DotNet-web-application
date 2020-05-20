import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs';
import {Employee} from '../models/employee';
import {EmployeeEntityService} from '../services/employee-entity.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  employees$: Observable<Employee[]>;
  constructor(
    private employeeEntityService: EmployeeEntityService) {
  }

  ngOnInit(): void {
    this.reload();
  }

  reload() {
    this.employees$ = this.employeeEntityService.entities$;
  }
}
