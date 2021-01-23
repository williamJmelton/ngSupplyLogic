import { Component, OnInit, Input, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: "app-customer-detail",
  templateUrl: "./customer-detail.component.html",
  styleUrls: ["./customer-detail.component.scss"],
})
export class CustomerDetailComponent implements OnInit {
  @Input() customer: Customer;
  url: string;
  accountTotal: number | null;

  constructor(private http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.url = baseUrl;
    this.accountTotal = null;
  }

  ngOnInit() {
  }


  getCustomerAccountTotal(): void {
    console.log('getting total for customer #: ', this.customer.oid)
    this.http.get<number>(this.url + `customers/totals/${this.customer.oid}`).subscribe(
      (result) => {
        this.accountTotal = result;
      },
      (error) => {
        console.error(error);
        console.log("problem getting the fucking totals")
      }
    );
  }
}


interface Customer {
  name: string;
  num: number;
  oid: number;
}
