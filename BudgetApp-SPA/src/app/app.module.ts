import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BudgetItemComponent } from './budgetItem/budgetItem.component';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
   declarations: [
      AppComponent,
      BudgetItemComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
