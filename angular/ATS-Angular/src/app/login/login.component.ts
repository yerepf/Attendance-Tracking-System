import { Component, input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Console } from 'console';
import Swal from 'sweetalert2';
import { Router, RouterModule } from '@angular/router';
import { AuthServiceService } from '../services/auth-service.service';


@Component({
  selector: 'login',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})

export class LoginComponent {

  constructor(
    private router: Router, public authService: AuthServiceService
  ){}

  isPasswordVisible: boolean = false;

  logearse() {
    if (this.authService.login(this.authService.username, this.authService.password)) {
      this.router.navigate(['/home']);
    }
  }

  cancelar() {
    this.authService.username = '';
    this.authService.password = '';
  }

  removeSpaces(event: any) {
    event.target.value = event.target.value.replace(/\s/g, '');
  }

  togglePasswordVisibility() {
    this.isPasswordVisible = !this.isPasswordVisible;
  }
}
