import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientJsonpModule } from '@angular/common/http';
import { Component, OnInit, inject } from '@angular/core';
import { ListToDo } from '../list-to-do';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-data',
  standalone: true,
  imports: [CommonModule,HttpClientJsonpModule],
  templateUrl: './data.component.html',
  styleUrl: './data.component.scss'
})
export class DataComponent {
 /* constructor(private http: HttpClient) { }
 // httpClient = inject(HttpClient);
  readonly APIUrl='https://localhost:7040/api/ToDo/';
  ListToDo:any=[];  
  ID:number=3;
 
  newTodo: ListToDo = { id: 0, Title: '', Description: '', CheckDone: false,DayID:0 };

  ngOnInit(): void {
  
     this.getTodos();
    // this. getTodosDay(3);
  }
 
  getTodos() {
   this.http.get(this.APIUrl + "getListTodo").subscribe(( ListToDo:any)=>{
       console.log(ListToDo);
      this.ListToDo =ListToDo;
      });
  }
  getTodosDay(ID:number) {
    this.http.get(`${this.APIUrl}getDayTodo/${ID}`).subscribe(( ListToDo:any)=>{
        console.log(ListToDo);
     
       });
   }
  AddToList(newTodo:ListToDo){
 
   //  return this.http.post<ListToDo>(this.APIUrl+"createTodo",newTodo);
   return this.http.post<ListToDo>(this.APIUrl+"createTodo",newTodo).subscribe(data=>{alert(data);this.getTodos();})
  }
  onSubmit(Add:string,IDDate:number) :void{
    this.AddToList({ id: 0, Title: Add, Description: '', CheckDone: false, DayID:IDDate, })
 
  }

  onSubmit(Add: string, IDDate: number): void {
    this.AddToList({ id: 0, Title: Add, Description: '', Done: false, DayID: IDDate })
      .subscribe(() => {
        console.log('Todo added successfully');
        this.newTodo = { id: 0, Title: '', Description: '', Done: false, DayID: IDDate };
      }, error => {
        console.error(error);
      });
  }*/
}
