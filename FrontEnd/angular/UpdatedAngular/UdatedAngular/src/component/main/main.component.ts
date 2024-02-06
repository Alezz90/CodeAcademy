import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Product } from '../../DataStorge/Model/product';
import { Category } from '../../DataStorge/Model/category';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-main',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './main.component.html',
  styleUrl: './main.component.scss'
})
export class MainComponent {
 
  ProductList: Product[];
  Catgories:Category[];
  totalselle:number;
  Categorynumber:number;
  Categoryname:string;
   catName:string;
  selectedCategory:string;

  //constructor
  constructor(){
    this.Catgories=[
      {id:1,Name:"OutputHardware"},
      {id:2,Name:"Software"},
      {id:3,Name:"InputHardware"},
      {id:4,Name:"storgeHardware"}
    ]
   this.totalselle = 0;
  this.Categorynumber=0;
  this.Categoryname='';
  this.catName='';
  this.selectedCategory='';
 
  this.ProductList = [
  {id:1,Name:"Mouse",Quntity:20,ImageURL:"assets/computer-mouse.png",price:1.000,categoryID:1},
  {id:2,Name:"Screen",Quntity:5,ImageURL:"assets/screen-1315650_1280.png",price:3.000,categoryID:2},
  {id:3,Name:"Labtob",Quntity:10,ImageURL:"assets/HH.jpg",price:4.000,categoryID:3},
  {id:4,Name:"server",Quntity:25,ImageURL:"assets/HH.jpg",price:3.500,categoryID:1},
]
  }
  TotalPrice(price:number,Quntity:string){
    let Qut:number =Number(Quntity)
this.totalselle += Qut * price;
  }
  CategoryNumber(catName:string){
     const selectedCategory = this.Catgories.find(category => category.Name === catName);
     this.Categorynumber=Number(selectedCategory?.id);
  
  }
  CategoryNam(NumbC : number){
    const selectedCategory = this.Catgories.find(category => category.id === NumbC );
    return selectedCategory?.Name;
 }
 
 ngOnChanges(changes:MainComponent) {
  console.log(`ngOnChanges - data is`);
}
ngOnDestroy() {
  console.log("ngOnDestroy");
}
}
