import {
  Component,
  OnInit,
  Inject,
  AfterViewInit,
  ViewChild,
} from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { MatTableDataSource } from "@angular/material/table";
import { MatSort } from "@angular/material/sort";
import { SelectionModel } from "@angular/cdk/collections";
import { MatDatepickerInputEvent } from "@angular/material/datepicker";
import { Clipboard } from "@angular/cdk/clipboard";

import { Parser } from "json2csv";

import UnPostedInvoice from "../../models/UnPostedInvoice.model";

interface Month {
  value: number,
  viewValue: string
}

@Component({
  selector: "app-invoices",
  templateUrl: "./invoices.component.html",
  styleUrls: ["./invoices.component.scss"],
})
export class InvoicesComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = [
    "select",
    "view",
    "repFirstName",
    "num",
    "name",
    "invoicedDate",
    "totalPrice",
    "totalProfit",
    // "marlQty"
  ];

  monthNames = ["January", "February", "March", "April", "May", "June",
  "July", "August", "September", "October", "November", "December"
];

 d = new Date();

  months: Month[] = [
    {viewValue: '01 January', value: 1},
    {viewValue: '02 Feburary', value: 2},
    {viewValue: '03 March', value: 3},
    {viewValue: '04 April', value: 4},
    {viewValue: '05 May', value: 5},
    {viewValue: '06 June', value: 6},
    {viewValue: '07 July', value: 7},
    {viewValue: '08 August', value: 8},
    {viewValue: '09 September', value: 9},
    {viewValue: '10 October', value: 10},
    {viewValue: '11 November', value: 11},
    {viewValue: '12 December', value: 12},
  ]

  // Select the current month by default.
  selectedMonth: Month = this.months[new Date().getMonth()];
  selectedMonthName: string;

  unPostedDataSource: MatTableDataSource<UnPostedInvoice> = null;
  ordersForSelectedDate: UnPostedInvoice[];
  customerNumber: number = null;
  selectedDate: Date = new Date();
  currentInvoiceView: string = "Un-Posted";
  marlQty: number = 0;

  url: string;
  selection = new SelectionModel<UnPostedInvoice>(true, []);

  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private clipboard: Clipboard
  ) {
    this.url = baseUrl;
  }

  ngOnInit(): void {
    // console.log(this.url + `invoices/date/`)
  }

  displaySelectedMonth(): string {
    return this.selectedMonth.viewValue;
  }

  ngAfterViewInit(): void {
    this.http.get<UnPostedInvoice[]>(this.url + "invoices/unposted").subscribe(
      (result) => {
        result.forEach(val => {
          console.log('getting marl qty')
        })
        this.unPostedDataSource = new MatTableDataSource<UnPostedInvoice>(
          result
        );
        console.log(result);
      },
      (error) => console.error(error)
    );
    setTimeout(() => (this.unPostedDataSource.sort = this.sort), 5000);
  }

  getCustomersMarlQty(customerNum: number): number {
    let marlQty: number;

    this.http.get<number>(this.url + "invoices/marl/" + customerNum).subscribe(
      (result) => {
        this.marlQty = result;
        console.log("result was: " + result);
        return result;
      }
    );
    console.log(marlQty);

    return marlQty;
  }

  getCustomersMarlQtyForSelectedMonth(customerNum: number, monthNum: number): void {
    let marlQty: number;
    this.selectedMonth = this.months[monthNum - 1];
    console.log("getting marl for C#" + customerNum + "for month of " + monthNum);

    this.http.get<number>(this.url + "invoices/marl/" + customerNum + "/" + monthNum).subscribe(
      (result) => {
        this.marlQty = result;
        console.log("result was: " + result);
        return result;
      }
    );
  }

  getInvoicesByDate(selectedDate: Date) {
    // getting invoices for a specific date
    this.http
      .get<UnPostedInvoice[]>(
        this.url + `invoices/date/${selectedDate.toISOString()}`
      )
      .subscribe(
        (result) => {
          this.currentInvoiceView = `${selectedDate.getMonth()}/${selectedDate.getDate()}/${selectedDate.getFullYear()}`;
          this.unPostedDataSource = new MatTableDataSource<UnPostedInvoice>(
            result
          );
          this.unPostedDataSource.sort = this.sort;
          console.log(result);
        },
        (error) => console.error(error)
      );
  }

  getInvoicesByCustomerNumber(): void {
    console.log(`Getting customers for customer # ${this.customerNumber}`);
    this.http
      .get<UnPostedInvoice[]>(
        this.url + `invoices/byCustomer/${this.customerNumber}`
      )
      .subscribe(
        (result) => {
          this.currentInvoiceView = `For Customer Number: ${this.customerNumber}`;
          this.unPostedDataSource = new MatTableDataSource<UnPostedInvoice>(
            result
          );
          this.unPostedDataSource.sort = this.sort;
          console.log(result);
        },
        (error) => console.error(error)
      );
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected(): boolean {
    if (this.unPostedDataSource) {
      const numSelected = this.selection.selected.length;
      const numRows = this.unPostedDataSource.data.length;
      return numSelected === numRows;
    }
  }

  selectAllByRep(repName: string): void {
    this.selection.clear();
    this.unPostedDataSource.data.forEach((row) => {
      this.selection.deselect(row);
    })
    this.unPostedDataSource.data.forEach(invoice => {
      console.log(`Comparing ${invoice.repFirstName} to ${repName}`)
      if (invoice.repFirstName.trim() == repName) {
        this.selection.selected.push(invoice)
      }
    })
    this.copySelectedCustomers()
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle(): void {
    this.isAllSelected()
      ? this.selection.clear()
      : this.unPostedDataSource.data.forEach((row) =>
        this.selection.select(row)
      );
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: UnPostedInvoice): string {
    if (!row) {
      return `${this.isAllSelected() ? "select" : "deselect"} all`;
    }
    return `${this.selection.isSelected(row) ? "deselect" : "select"} row ${row.name
      }`;
  }

  getTotalProfits(): number {
    let total = 0;
    this.unPostedDataSource.data.forEach((invoice) => {
      total += invoice.totalProfit;
    });

    return total;
  }

  clear() {
    this.http.get<UnPostedInvoice[]>(this.url + "invoices/unposted").subscribe(
      (result) => {
        this.unPostedDataSource = new MatTableDataSource<UnPostedInvoice>(
          result
        );
        this.currentInvoiceView = "Un-Posted";
        console.log(result);
      },
      (error) => console.error(error)
    );
    setTimeout(() => (this.unPostedDataSource.sort = this.sort), 5000);
  }

  getTotalSales(): number {
    let total = 0;
    this.unPostedDataSource.data.forEach((invoice) => {
      total += invoice.totalPrice;
    });

    return total;
  }

  handleDateChange(event: MatDatepickerInputEvent<Date>) {
    this.selectedDate = event.value;
  }

  copySelectedCustomers() {
    // docs for json2csv lib: https://www.npmjs.com/package/json2csv
    const fields = ["num", "name", "invoicedDate", "totalPrice", "totalProfit"];
    const opts = { fields, excelStrings: false, delimiter: "," };
    const data = this.selection.selected;

    // loop thru and format the dates so they aren't ass
    data.forEach(invoice => {
      // TODO: Fix the date formatting
      //invoice.invoicedDate = invoice.invoicedDate.toDateString();
    })

    let csv = "";

    try {
      const parser = new Parser(opts);
      csv = parser.parse(this.selection.selected);
      this.clipboard.copy(csv);
      console.log(csv);
    } catch (err) {
      console.error(err);
    }
  }
}
