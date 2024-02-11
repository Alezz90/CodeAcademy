import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ListToDo } from './list-to-do';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class WeekPlanService {
private http = inject(HttpClient);
  constructor() { }

  readonly APIUrl='https://localhost:7040/api/ToDo/';
  ListToDo:any=[];  
  ID:number=3;
 // newTodo: ListToDo = { id: 0, Title: '', Description: '', CheckDone: false,dayNumber:0 };

  ngOnInit(): void {
     this.getTodos();
  }
 
  getTodos(){
   return this.http.get(this.APIUrl + "getListTodo");
  }
  getTodosDay(ID:number):Observable<any> {
   return this.http.get(`${this.APIUrl}getDayTodo/${ID}`);
    
   }
  AddToList(newTodo:ListToDo){

   return this.http.post<ListToDo>(this.APIUrl+"createTodo",newTodo);
  }

}
