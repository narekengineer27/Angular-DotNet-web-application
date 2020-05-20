import {Injectable} from '@angular/core';
import {DefaultDataService, HttpUrlGenerator} from '@ngrx/data';
import {Employee} from '../models/employee';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';

@Injectable()
export class EmployeesDataService extends DefaultDataService<Employee> {
  constructor(http: HttpClient, httpUrlGenerator: HttpUrlGenerator) {
    super('Employee', http, httpUrlGenerator);
  }

  getAll(): Observable<Employee[]> {
    return this.http.get('https://localhost:44339/api/employees')
      .pipe(
        map((response: Employee[]) => response)
      );
  }
}
