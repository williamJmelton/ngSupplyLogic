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

@Component({
  selector: "app-invoices",
  templateUrl: "./invoices.component.html",
  styleUrls: ["./invoices.component.scss"],
})
export class InvoicesComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = [
    "select",
    "view",
    "num",
    "name",
    "invoicedDate",
    "repFirstName",
    "totalPrice",
    "totalProfit",
  ];

  unPostedDataSource: MatTableDataSource<UnPostedInvoice> = null;
  ordersForSelectedDate: UnPostedInvoice[];
  customerNumber: number = null;
  selectedDate: Date = new Date();
  currentInvoiceView: string = "Un-Posted";

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

  ngOnInit(): void {}

  ngAfterViewInit(): void {
    this.http.get<UnPostedInvoice[]>(this.url + "invoices/unposted").subscribe(
      (result) => {
        this.unPostedDataSource = new MatTableDataSource<UnPostedInvoice>(
          result
        );
        console.log(result);
      },
      (error) => console.error(error)
    );
    setTimeout(() => (this.unPostedDataSource.sort = this.sort), 5000);
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
    return `${this.selection.isSelected(row) ? "deselect" : "select"} row ${
      row.name
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
