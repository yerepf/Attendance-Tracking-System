import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { Router } from 'express';
import exp from 'constants';

export const routes: Routes = [
    {
        path: '', 
        component: LoginComponent
    },
    {
        path: 'home', 
        component: HomeComponent, 
        children: [
            {
                path: 'dashboard', 
                component: DashboardComponent
            }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {}