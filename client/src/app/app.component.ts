import { Component, OnInit } from '@angular/core';
import { User } from './_models/User';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Datinh App';
  users: any;

  constructor(private accontServie: AccountService){

  }

  ngOnInit() {
  }

  setCurrentUser(){
    const user: User =  JSON.parse(localStorage.getItem('user') || '{}');
    this.accontServie.setCurrentUser(user)
  }

} 
