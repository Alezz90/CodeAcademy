import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { HeaderComponent } from '../component/header/header.component';
import { FooterComponent } from '../component/footer/footer.component';
import { MainComponent } from '../component/main/main.component';
//import { AppRoutingModule } from './app-routing.module';
import { Router } from '@angular/router';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,HeaderComponent,FooterComponent,MainComponent,RouterModule,],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent {
 
  title = 'UdatedAngular';
}
