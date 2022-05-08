import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'qb-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

public imagePath: string = "https://hippotential.files.wordpress.com/2012/12/buy-sell-dice.jpg"

  constructor() { }

  ngOnInit(): void {
  }

}
