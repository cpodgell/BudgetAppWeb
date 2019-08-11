import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-budgetItem',
  templateUrl: './budgetItem.component.html',
  styleUrls: ['./budgetItem.component.css']
})
export class BudgetItemComponent implements OnInit {
    budgetItems: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    console.log('retreived');
    this.getBudgetItems();
  }

  getBudgetItems() {
    console.log('retreived');
    this.http.get('https://localhost:44311/api/budget').subscribe(response => {
      console.log('retreived!!!!!!!!!!!!');
      this.budgetItems = response;
      console.log('retreived!!!!!!!!!!!!');
    }, error => {
      console.log('***********************something');
      console.log(error);
    });
  }

}
