import {Component, Inject, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import {ToDoTaskEntityService} from '../services/task-entity.service';
import {ToDoTask} from '../models/todotask';

@Component({
  selector: 'app-edit-task-dialog',
  templateUrl: './edit-task-dialog.component.html',
  styleUrls: ['./edit-task-dialog.component.css']
})
export class EditTaskDialogComponent implements OnInit {

  form: FormGroup;

  mode: 'create' | 'update';

  toDoTask: ToDoTask;

  constructor(
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<EditTaskDialogComponent>,
    @Inject(MAT_DIALOG_DATA) data,
    private coursesService: ToDoTaskEntityService
  ) {
    this.toDoTask = data.toDoTask;
    this.mode = data.mode;

    const formControls = {
      description: ['', Validators.required],
      title: ['', Validators.required]
    };

    if (this.mode === 'update') {
      this.form = this.fb.group(formControls);
      this.form.patchValue({...data.toDoTask});
    } else if (this.mode === 'create') {
      this.form = this.fb.group({
        ...formControls,
        description: ['', Validators.required],
        title: ['', Validators.required]
      });
    }
  }

  ngOnInit(): void {
  }

  onClose() {
    this.dialogRef.close();
  }

  onSave() {

    const task: ToDoTask = {
      ...this.toDoTask,
      ...this.form.value
    };

    if (this.mode === 'update') {
      this.coursesService.update(task);

      this.dialogRef.close();
    } else if (this.mode === 'create') {
      this.coursesService.add(task)
        .subscribe(
          newCourse => {
            this.dialogRef.close();
          }
        );
    }
  }
}
