import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {Employee} from '../models/employee';
import {ToDoTask} from '../models/todotask';
import {ToDoTaskEntityService} from '../services/task-entity.service';
import {defaultDialogConfig} from '../default-dialog-config';
import {EditTaskDialogComponent} from '../edit-task-dialog/edit-task-dialog.component';
import {MatDialog} from '@angular/material/dialog';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  @Input() employee: Employee;
  @Input() expanded: true;

  @Output()
  taskChanged = new EventEmitter();

  constructor(
    private dialog: MatDialog,
    private toDoTaskEntityService: ToDoTaskEntityService) {
  }

  ngOnInit(): void {
  }

  deleteTask(task: ToDoTask) {
    this.toDoTaskEntityService.delete(task);
  }

  editTask(task: ToDoTask) {
    const dialogConfig = defaultDialogConfig();

    dialogConfig.data = {
      dialogTitle: 'Edit Task',
      toDoTask: task,
      mode: 'update'
    };

    this.dialog.open(EditTaskDialogComponent, dialogConfig)
      .afterClosed()
      .subscribe(() => this.taskChanged.emit());
  }


}
