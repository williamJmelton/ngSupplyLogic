import {
  Component,
  OnInit,
  Inject,
  AfterViewInit,
  ViewChild,
} from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { HttpClient } from "@angular/common/http";
import { MatTableDataSource } from "@angular/material/table";
import { MatSort } from "@angular/material/sort";


import InvoiceLine from './../../../Models/InvoiceLine.model';


@Component({
  selector: "app-invoice",
  templateUrl: "./invoice.component.html",
  styleUrls: ["./invoice.component.scss"],
})
export class InvoiceComponent implements OnInit, AfterViewInit {
  InvoiceLines: MatTableDataSource<InvoiceLine> = null;
  displayedColumns = ["itemName", "orderQty", "unitName", "itemProfit", "isGeneral"];
  url: string;
  invoiceID: number;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private route: ActivatedRoute
  ) {
    this.url = baseUrl;
  }

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      console.log("The id of this route is: ", params.invoiceID);
      this.invoiceID = params.invoiceID;
    });
  }

  ngAfterViewInit(): void {
    this.http
      .get<InvoiceLine[]>(this.url + `invoices/${this.invoiceID}`)
      .subscribe(
        (result) => {
          this.InvoiceLines = new MatTableDataSource<InvoiceLine>(result);
          console.log(result);
        },
        (error) => console.error(error)
    );
    setTimeout(() => (this.InvoiceLines.sort = this.sort), 5000);
  }

  getProfitTotal(): number {
    let total = 0;
    this.InvoiceLines.data.forEach((line) => {
      total += line.itemProfit;
    });

    return total;
  }

  getInvoiceTotal(): number {
    let total = 0;
    this.InvoiceLines.data.forEach((line) => {
      total += line.lineTotal;
    });

    return total;
  }
}
