
import { RouterModule, Routes } from '@angular/router';
import { HeaderComponent } from '../component/header/header.component';
import { MainComponent } from '../component/main/main.component';
import { IntroComponent } from '../component/intro/intro.component';

export const routes: Routes = [
    {path: 'Intro',component:IntroComponent,},
    { path: 'Main',   component:MainComponent},
];

 