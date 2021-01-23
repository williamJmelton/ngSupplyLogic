import { Component, OnInit, Inject, AfterViewInit, ViewChild } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { MatTableDataSource } from "@angular/material/table";

import ArTrans from '../../Models/ArTransaction.model';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';

@Component({
  selector: 'app-transactions',
  templateUrl: './transactions.component.html',
  styleUrls: ['./transactions.component.scss']
})
export class TransactionsComponent implements OnInit, AfterViewInit {
  url: string;
  arTrans: MatTableDataSource<ArTrans>;
  displayedColumns = [
    'customerNumber',
    'customerName',
    'paymentType',
    'entryDate'
  ]
  selectedDate: Date = null; // this will be used to get trans. for a specific date


  constructor(private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string) {
    this.url = baseUrl;
  }

  ngOnInit(): void {
    this.arTrans.filterPredicate = (data: ArTrans, filter: string) => {
      return data.paymentType.toString().trim() == filter.trim();
    };
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.arTrans.filter = filterValue.trim().toLowerCase();
  }

  transType(type: number): string {
    switch (type) {
      case 1:
        return "Cash"
      case 2:
        return "Check"
      case 3:
        return "Unknown 3"
      case 4:
        return "Unknown 4"
      case 5:
        return "Unknown 5"
      case 6:
        return "Money Wire"
    }
  }

  ngAfterViewInit(): void {
    //setTimeout(() => (this.arTrans.sort = this.sort), 5000);
  }

  getTransactionsByType(type: number): void {
    this.http.get<ArTrans[]>(this.url + `transactions/${type}`).subscribe(
      (result) => {
        this.arTrans = new MatTableDataSource<ArTrans>(
          result
        );
        this.arTrans.filterPredicate = function (data, filter: string): boolean {
          return data.customerNumber.toString() === filter;
        };
        console.log(result);
      },
      (error) => console.error(error)
    );
  }

  handleDateChange(event: MatDatepickerInputEvent<Date>) {
    this.selectedDate = event.value;
    this.getTransForDate();
  }

  filterResultsByPaymentType(paymentType: number): void {
    // this.arTrans.data.filter((trans: ArTrans) => {
    //   if (trans.paymentType == paymentType) {
    //     return true;
    //   } else {
    //     return false;
    //   }
    // })
    this.arTrans.filter = paymentType.toString();
  }

  getTransForDate(): void {
    console.log(`getting transactions for date: ${this.selectedDate}`)
    this.http.get<ArTrans[]>(this.url + `transactions/date/${this.selectedDate.toISOString()}`).subscribe(
      (result) => {
        this.arTrans = new MatTableDataSource<ArTrans>(
          result
        );
        this.arTrans.filterPredicate = function (data, filter: string): boolean {
          return data.customerNumber.toString() === filter;
        };
        console.log(result);
      },
      (error) => console.error(error)
    );
  }

}
