import {Injectable} from '@angular/core';
import {ActivatedRouteSnapshot, Resolve, RouterStateSnapshot} from '@angular/router';
import {Observable} from 'rxjs';
import {EmployeeEntityService} from './employee-entity.service';
import {filter, first, tap} from 'rxjs/operators';

@Injectable()
export class EmployeesResolver implements Resolve<boolean> {

  constructor(private employeeEntityService: EmployeeEntityService) {
  }

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> {
    return this.employeeEntityService.loaded$
      .pipe(
        tap(loaded => {
          if (!loaded) {
            this.employeeEntityService.getAll();
          }
        }),
        filter(loaded => !!loaded),
        first()
      );
  }

}
