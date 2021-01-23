import { Component, OnInit, Inject, AfterViewInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { MatTableDataSource } from "@angular/material/table";
import { CustomerDetailComponent } from './../customer-detail/customer-detail.component';
import {
  animate,
  state,
  style,
  transition,
  trigger,
} from "@angular/animations";

interface Customer {
  name: string;
  num: number;
  city: string;
  rep: string;
}

interface SalesRep {
  firstName: string;
  lastName: string;
  middleName: string;
  objId: number;
}

@Component({
  selector: "app-customer-mgmt",
  templateUrl: "./customer-mgmt.component.html",
  styleUrls: ["./customer-mgmt.component.scss"],
  animations: [
    trigger("detailExpand", [
      state("collapsed", style({ height: "0px", minHeight: "0" })),
      state("expanded", style({ height: "*" })),
      transition(
        "expanded <=> collapsed",
        animate("225ms cubic-bezier(0.4, 0.0, 0.2, 1)")
      ),
    ]),
  ],
})

export class CustomerMgmtComponent implements OnInit, AfterViewInit {
  url: string;
  dataSource: MatTableDataSource<Customer> = null;
  displayedColumns = ["num", "name", "city"];
  cities: string[] = new Array();
  salesReps: SalesRep[] = null;
  expandedElement: CustomerDetailComponent | null;

  constructor(private http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.url = baseUrl;
  }

  ngOnInit(): void {}

  ngAfterViewInit(): void {
    this.http.get<Customer[]>(this.url + "customers").subscribe(
      (result) => {
        this.dataSource = new MatTableDataSource<Customer>(result);
        console.log(result);
        //this.cities = [...new Set(result.map((cust) => cust.city))];
      },
      (error) => {
        console.log("Error in getting customers data!");
        console.error(error)
        }
    );

    this.getSalesReps();
  }

  getCustomersForRep(repID: number): void {
    this.http
      .get<Customer[]>(this.url + `customers/${repID}`)
      .subscribe(
      (result) => {
        this.dataSource.data = result;
      },
      (error) => {
        console.log("Error in getting  customers for rep!");
        console.error(error)
      }
    );
  }

  getSalesReps(): void {
    this.http
      .get<SalesRep[]>(this.url + `customers/reps`)
      .subscribe((result) => {
        this.salesReps = result;
      },
        (error) => {
        console.log("Error in getting sales reps!");
        console.error(error)
        }
      )
  }
}
