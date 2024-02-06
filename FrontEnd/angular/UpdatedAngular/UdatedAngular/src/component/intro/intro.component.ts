import { Component } from '@angular/core';
import { User } from '../../DataStorge/Model/user';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-intro',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './intro.component.html',
  styleUrl: './intro.component.scss'
})
export class IntroComponent {
  UserValue :User ;
  constructor(){
    this.UserValue = new User("Azza","1990",['React','Angular','Bootstrap','express']);
  }

}
