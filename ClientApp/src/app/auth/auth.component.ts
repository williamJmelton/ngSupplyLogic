import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UiService } from './../ui.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.scss']
})
export class AuthComponent implements OnInit {
  toRoute: string;
  password: string = "";

  constructor(@Inject(MAT_DIALOG_DATA) public data: { route: string }, private _router: Router, private dialogRef: MatDialogRef<any>) {

  }

  ngOnInit(): void {
    this.toRoute = this.data.route;
    console.log(`From dialog component: Navigate to ${this.data.route}`)
  }

  checkPassword(): boolean {
    if (this.password == '1120') {
      console.log(`password was: ${this.password}`)
      return true;
    } else {
      return false;
    }
  }

  end() {
    let passIsGood = this.checkPassword();
    this.dialogRef.close({ passwordStatus: passIsGood, route: this.data.route })
  }

}
