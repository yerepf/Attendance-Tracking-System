import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AuthServiceService } from '../services/auth-service.service';

@Component({
  selector: 'home',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  DashboardVisible:boolean = false;

  constructor(private router: Router, public authService: AuthServiceService) {}

  ToogleDashboardVisibility(){
    if(this.DashboardVisible){
      this.router.navigate(['/home']);
      this.DashboardVisible = false;
    }
    else{
      this.router.navigate(['/home/dashboard']);
      this.DashboardVisible = true;
    }
    
  }
}
