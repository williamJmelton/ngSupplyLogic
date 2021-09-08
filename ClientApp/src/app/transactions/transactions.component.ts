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
  arTrans: MatTableDataSource<ArTrans> = new MatTableDataSource();
  arTransFilter: MatTableDataSource<ArTrans> = new MatTableDataSource();
  filterString: string = '';
  displayedColumns = [
    'customerNumber',
    'customerName',
    'paymentType',
    'entryDate'
  ]
  selectedDate: Date = new Date(); // this will be used to get trans. for a specific date


  constructor(private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string) {
    this.url = baseUrl;
    this.selectedDate = new Date()
    this.getTransForDate();
  }

  ngOnInit(): void {
    this.getTransForDate();
  }

  // applyFilter(event: Event) {
  //   const filterValue = (event.target as HTMLInputElement).value;
  //   this.arTrans.filter = filterValue;
  // }

  transType(type: number | string): string {
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

  }

  handleDateChange(event: MatDatepickerInputEvent<Date>) {
    this.selectedDate = event.value;
    this.getTransForDate();
  }

  FilterTransactions(transType: number | null, customerName?: string): void {
    if (transType == null) { // we are filting by customer name
      console.log(`filtering by name: ${this.transType(customerName)}`);
      this.arTrans.filter = customerName.trim().toLowerCase();
    } else { // we are filtering by trans type
      console.log(`filtering by payment type: ${this.transType(transType)}`);
      this.arTrans.filter = transType.toString();
    }
  }

  clearFilter(): void {
    this.arTrans.filter = '';
  }

  filterByTransType(transType: number): void {
    this.arTransFilter.data = this.arTrans.data.filter((trans: ArTrans) => {
      return trans.type == transType
    })
  };

  getTransForDate(): void {
    console.log(`getting transactions for date: ${this.selectedDate}`)
    this.http.get<ArTrans[]>(this.url + `transactions/date/${this.selectedDate.toISOString()}`).subscribe(
      (result) => {
        this.arTrans = new MatTableDataSource<ArTrans>(
          result
        );
        console.log("applying filter predicate");

        this.arTrans.filterPredicate = function (data, filter: number | null | string): boolean {
          //TODO: Predicate function needs to filter both the payment type AND 
          //      the customer name!
          if (filter) {
            if (typeof (filter) == 'number') {
              console.log('filter by payment type');
              return data.paymentType == filter;
            } else if (typeof (filter) == 'string') {
              console.log('filter by customer name')
              return data.customerName.indexOf(filter) != -1;
            }
          }
          // } else if (filter) {
          //   // if filter is null, we are filtering the 
          // } else {
          //   console.log(`parseint result: ${parseInt(filter)}`)
          //   // if parseInt fails, we have a customer name
          //   console.log('filter by customer name');
          //   return data.customerName.indexOf(filter) != -1
          //   // return data.customerName.toString() == filter;
          // }
        };

        console.log(result);
      },
      (error) => console.error(error)
    );
  }

}
