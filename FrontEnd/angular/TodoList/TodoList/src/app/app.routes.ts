import { Routes } from '@angular/router';
import { WeekListComponent } from './component/week-list/week-list.component';
import { HttpClientModule } from '@angular/common/http';
import {DataComponent} from './DataStorage/data/data.component';
import { MyVisionComponent } from './component/my-vision/my-vision.component';
export const routes: Routes = [
    {path:'WeekList',component:WeekListComponent},
    {path: 'firsttry',component:DataComponent},
    {path:'Vision',component:MyVisionComponent}
];
