import {Component, Input, OnInit} from '@angular/core';
import {Employee} from '../models/employee';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  @Input()
  employees: Employee[];

  constructor() { }

  ngOnInit(): void {
  }

}
