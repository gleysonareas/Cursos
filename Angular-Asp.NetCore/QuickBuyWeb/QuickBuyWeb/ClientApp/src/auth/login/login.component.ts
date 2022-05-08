import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';
import { IUser } from '../../shared/model/user.interface';

@Component({
  selector: 'qb-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public imagePath: string = "../assets/buy-logo.jpg"
  public userAuthenticated: boolean;
  public user: IUser;

  constructor(private router: Router) {
    this.user = <IUser>{};
  }

  ngOnInit(): void { }

  public enter(): void {
    if (this.user.email === 'gleysonareasdasilva@gmail.com' && this.user.password === 'Gyn.4539766') {
      localStorage.setItem('User is logged', '1');
      this.userAuthenticated = true;
      this.router.navigate(['/']);
    }
  }
}
