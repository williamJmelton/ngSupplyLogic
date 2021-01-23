import { Injectable } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AuthComponent } from './auth/auth.component';
import { Router } from '@angular/router';

interface SecurityDialogResult {
  passwordStatus: boolean;
  route: string;
}


@Injectable({
  providedIn: 'root'
})
export class UiService {
  enteredPassword: string;
  isValidated: boolean = false;

  constructor(public dialog: MatDialog, private _router: Router) { }

  openAuthDialog(toRoute: string): void {
    const dialogRef = this.dialog.open(AuthComponent, { data: { route: toRoute } });

    dialogRef.afterClosed().subscribe((result: SecurityDialogResult) => {
      if (result.passwordStatus == true) {
        this.isValidated = true;
        this._router.navigateByUrl(result.route);
      } else {
        this.isValidated = false;
        console.log("sorry, wrong password")
        this._router.navigateByUrl("");
      }
    });
  }

  checkPassword(pwd: string): boolean {
    if (pwd == "1120") {
      this.isValidated = true;
      return true;
    } else {
      this.isValidated = false;
      return false;
    }
  }
}
