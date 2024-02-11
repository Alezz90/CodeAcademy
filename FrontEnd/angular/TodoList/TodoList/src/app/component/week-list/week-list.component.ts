import { Component,OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ListToDo } from '../../DataStorage/list-to-do';
import {WeekPlanService}from'../../DataStorage/week-plan.service';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
@Component({
  
  selector: 'app-week-list',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './week-list.component.html',
  styleUrl: './week-list.component.scss'
})
export class WeekListComponent implements OnInit {
  isInputVisible = false;
 private WeekPlanService= inject(WeekPlanService);
  newTodo: any= [];
  addElemnt: string = '';
  ngOnInit(): void {
    this.getDayList();
  }
  getDayList(){
    this.WeekPlanService.getTodos()
     .subscribe({
      next:(newTodo:any) => {
      console.log(newTodo); 
      this.newTodo=newTodo;
    }, error:(error) => {
      console.error(error);
    }});
  }
  toggleInputVisibility() {
    this.isInputVisible = !this.isInputVisible;
  }
  AddEelemnt(Add:string,IDDate:number) :void{
    this.WeekPlanService.AddToList({ id: 0, Title: Add, Description: '', CheckDone: false, dayNumber:IDDate, }).
    subscribe(data=>{alert(data);this.getDayList();})
  }
   
}

