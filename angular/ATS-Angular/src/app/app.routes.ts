import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MainlayoutComponent } from './mainlayout/mainlayout.component';
import { AttendanceComponent } from './attendance/attendance.component';
import { NavbarComponent } from './navbar/navbar.component';
import { Router } from 'express';
import exp from 'constants';
import path from 'path';

export const routes: Routes = [
    {
        path: '', redirectTo: 'login', pathMatch: 'full'
    },
    {
        path: 'login', 
        component: LoginComponent
    },
    {
        path: 'dashboard', 
        component: MainlayoutComponent,
        children: [
            { path: '', component: DashboardComponent }
        ]
    },
    {
        path: 'attendance', 
        component: MainlayoutComponent,
        children: [
            { path: '', component: AttendanceComponent }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {}