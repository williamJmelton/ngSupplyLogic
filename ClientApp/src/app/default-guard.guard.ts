import { Injectable } from '@angular/core';
import { CanActivate, CanLoad, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { UiService } from './ui.service';

@Injectable({
  providedIn: 'root'
})
export class DefaultGuardGuard implements CanActivate, CanLoad {
  constructor(private _ui: UiService, public _router: Router) { }

  canLoad(): boolean {
    if (this._ui.isValidated) {
      console.log("Already validated!")
      return true;
    } else {
      console.log("Plese get validated!")
      this._router.navigateByUrl("");
      return false;
    }
  }

  canActivate(): boolean {
    if (this._ui.isValidated) {
      console.log("Already validated!")
      return true;
    } else {
      console.log("Plese get validated!")
      this._router.navigateByUrl("");
      return false;
    }
  }
}
