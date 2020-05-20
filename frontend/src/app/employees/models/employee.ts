import {ToDoTask} from './todotask';

export interface Employee {
  employeeId: number;
  name: string;
  toDoTasks: ToDoTask[];
}
