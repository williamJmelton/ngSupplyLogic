import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MaterialModule } from './material.module';

import { DefaultGuardGuard } from './default-guard.guard';


import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CustomerMgmtComponent } from './customer-mgmt/customer-mgmt.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CustomerDetailComponent } from './customer-detail/customer-detail.component';
import { SendMessagesComponent } from './send-messages/send-messages.component';
import { InvoicesComponent } from './invoices/invoices.component';

import { AngularFireModule } from "@angular/fire";
import { AngularFirestoreModule } from "@angular/fire/firestore";
import { environment } from "../environments/environment";

import { InvoiceComponent } from './invoices/invoice/invoice.component';
import { TransactionsComponent } from './transactions/transactions.component';
import { AuthComponent } from './auth/auth.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CustomerMgmtComponent,
    CustomerDetailComponent,
    SendMessagesComponent,
    InvoicesComponent,
    InvoiceComponent,
    TransactionsComponent,
    AuthComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "customer-mgmt", component: CustomerMgmtComponent },
      { path: "send-messages", component: SendMessagesComponent },
      { path: "invoices", component: InvoicesComponent, },
      { path: "invoice/:invoiceID", component: InvoiceComponent, canActivate: [DefaultGuardGuard] },
      { path: "transactions", component: TransactionsComponent, canActivate: [DefaultGuardGuard] }
    ]),
    BrowserAnimationsModule,
    MaterialModule,
    AngularFireModule.initializeApp(environment.firebase),
    AngularFirestoreModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
