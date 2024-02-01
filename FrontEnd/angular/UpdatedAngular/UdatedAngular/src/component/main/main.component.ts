import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { User } from '../../DataStorge/Model/user';
@Component({
  selector: 'app-main',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './main.component.html',
  styleUrl: './main.component.scss'
})
export class MainComponent {
  UserValue :User ;
  constructor(){
  this.UserValue = new User("Azza","1990",['React','Angular','Bootstrap','express']);
  }
}
