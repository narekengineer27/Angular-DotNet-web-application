import {Injectable} from '@angular/core';
import {EntityCollectionServiceBase, EntityCollectionServiceElementsFactory} from '@ngrx/data';
import {ToDoTask} from '../models/todotask';

@Injectable()
export class ToDoTaskEntityService extends EntityCollectionServiceBase<ToDoTask> {
  constructor(serviceElementsFactory: EntityCollectionServiceElementsFactory) {
    super('ToDoTask', serviceElementsFactory);
  }
}
