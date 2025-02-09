import { Injectable } from '@angular/core';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {

  username:string = '';
  password:string = '';

  constructor() { }

  login(username: string, password: string): boolean {

    if(username == '' && password == ''){
      Swal.fire({
        title: '¡Error!',
        text: 'Rellene todos los campos',
        icon: 'error',
        confirmButtonText: 'Aceptar',
        confirmButtonColor: '#db001b',
      });
      return false;
    }
    else if(username != 'YeremyPF' || password != '1234'){
      Swal.fire({
        title: '¡Error!',
        text: 'Usuario o contraseña incorrectos',
        icon: 'error',
        confirmButtonText: 'Aceptar',
        confirmButtonColor: '#db001b',
      });
      return false
    }
    else{

      this.username = username;
      this.password = password;

      Swal.fire({
        title: '¡Bienvenido!',
        text: 'Inicio de sesión correcto.',
        icon: 'success',
        confirmButtonText: 'Aceptar',
        confirmButtonColor: '#db001b',
        timer: 2000
      });
      return true;
    }
}
}
