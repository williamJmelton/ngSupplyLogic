import { Component } from '@angular/core';
import { UiService } from './../ui.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.scss']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private _ui: UiService, private _router: Router) {

  }

  collapse() {
    this.isExpanded = false;
  }

  tryNavigate(route: string): void {
    if (this._ui.isValidated) {
      // user has already validated this session, so 
      // just navigate them to where they wanna go.
      this._router.navigateByUrl(route);
    } else {
      // user hasn't inputed a password this session.
      // make sure they are authorized.
      this._ui.openAuthDialog(route);
    }
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
