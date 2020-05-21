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
import { EmployeeComponent } from './employee/employee.component';
import { TasksListComponent } from './tasks-list/tasks-list.component';
import { TaskComponent } from './task/task.component';
import {ToDoTasksDataService} from './services/tasks-data.service';
import {ToDoTaskEntityService} from './services/task-entity.service';
import { EditTaskDialogComponent } from './edit-task-dialog/edit-task-dialog.component';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatTabsModule} from '@angular/material/tabs';
import {MatInputModule} from '@angular/material/input';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSortModule} from '@angular/material/sort';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatDialogModule} from '@angular/material/dialog';
import {MatSelectModule} from '@angular/material/select';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {ReactiveFormsModule} from '@angular/forms';

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
    MatButtonModule,
    MatIconModule,
    MatCardModule,
    MatTabsModule,
    MatInputModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatProgressSpinnerModule,
    MatSlideToggleModule,
    MatDialogModule,
    MatSelectModule,
    MatDatepickerModule,
    ReactiveFormsModule,
    MatExpansionModule,
    RouterModule.forChild(employeesRoutes)
  ],
  declarations: [HomeComponent, EmployeesListComponent, EmployeeComponent, TasksListComponent, TaskComponent, EditTaskDialogComponent],
  exports: [
    HomeComponent
  ],
  entryComponents: [],
  providers: [EmployeesResolver, EmployeeEntityService, EmployeesDataService, ToDoTaskEntityService, ToDoTasksDataService]
})
export class EmployeesModule {
  constructor(
    private entityDefinitionService: EntityDefinitionService,
    private entityDataService: EntityDataService,
    private employeesDataService: EmployeesDataService,
    private toDoTasksDataService: ToDoTasksDataService) {

    entityDefinitionService.registerMetadataMap(entityMetadata);
    entityDataService.registerService('Employee', employeesDataService);
    entityDataService.registerService('ToDoTask', toDoTasksDataService);
  }
}
