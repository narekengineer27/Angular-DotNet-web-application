import {RouterModule, Routes} from '@angular/router';
import {CommonModule} from '@angular/common';
import {NgModule} from '@angular/core';
import { HomeComponent } from './home/home.component';
import {EmployeesResolver} from './services/employees.resolver';
import {EmployeeEntityService} from './services/employee-entity.service';
import {EntityDataService, EntityDefinitionService, EntityMetadataMap} from '@ngrx/data';
import {Employee} from './models/employee';
import {ToDoTask} from './models/todotask';
import {EmployeesDataService} from './services/employees-data.service';
import { EmployeesListComponent } from './employees-list/employees-list.component';
import {MatCardModule} from '@angular/material/card';
import {MatExpansionModule} from '@angular/material/expansion';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

export const employeesRoutes: Routes = [
  {
    path: '',
    component: HomeComponent,
    resolve: {
      employees: EmployeesResolver
    }
  }
];

const entityMetadata: EntityMetadataMap = {
  Employee: {
    selectId: (employee: Employee) => employee.employeeId,
    entityDispatcherOptions: {
      optimisticUpdate: true
    }
  },
  ToDoTask: {
    selectId: (todoTask: ToDoTask) => todoTask.toDoTaskId,
    entityDispatcherOptions: {
      optimisticUpdate: true
    }
  }
};

@NgModule({
  imports: [
    CommonModule,
    MatExpansionModule,
    RouterModule.forChild(employeesRoutes)
  ],
  declarations: [HomeComponent, EmployeesListComponent],
  exports: [
    HomeComponent
  ],
  entryComponents: [],
  providers: [EmployeesResolver, EmployeeEntityService, EmployeesDataService]
})
export class EmployeesModule {
  constructor(
    private entityDefinitionService: EntityDefinitionService,
    private entityDataService: EntityDataService,
    private employeesDataService: EmployeesDataService) {

    entityDefinitionService.registerMetadataMap(entityMetadata);
    entityDataService.registerService('Employee', employeesDataService);
  }
}
