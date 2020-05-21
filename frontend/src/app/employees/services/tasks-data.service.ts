import {Injectable} from '@angular/core';
import {DefaultDataService, HttpUrlGenerator} from '@ngrx/data';
import {ToDoTask} from '../models/todotask';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';
import {Update} from '@ngrx/entity';

@Injectable()
export class ToDoTasksDataService extends DefaultDataService<ToDoTask> {
  constructor(http: HttpClient, httpUrlGenerator: HttpUrlGenerator) {
    super('ToDoTask', http, httpUrlGenerator);
  }

  getAll(): Observable<ToDoTask[]> {
    return this.http.get('https://localhost:44339/api/ToDoTasks')
      .pipe(
        map((response: ToDoTask[]) => response)
      );
  }

  update(task: Update<ToDoTask>): Observable<ToDoTask> {
    return this.http.put('https://localhost:44339/api/ToDoTasks', task.changes)
      .pipe(
        map(response => task.changes as ToDoTask)
      );
  }

  delete(key: number | string): Observable<number | string> {
    return this.http.delete('https://localhost:44339/api/ToDoTasks/' + key)
      .pipe(
        map(r => key)
      );
  }
}
