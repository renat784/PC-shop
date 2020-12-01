import { Component, EventEmitter, OnInit } from "@angular/core";

import { GetDataService } from "../get-data.service";

export let orderChanged = new EventEmitter<boolean>();

@Component({
  selector: "app-nav-menu",
  templateUrl: "./nav-menu.component.html",
  styleUrls: ["./nav-menu.component.css"],
})
export class NavMenuComponent implements OnInit {
  constructor(public service: GetDataService) {}

  OrderChanged() {
    orderChanged.emit(true);
  }

  ngOnInit(): void {}
  isExpanded = false;

  CountChangedDown(product, value) {
    if (value > 1) this.CountChanged(product, --value);
  }

  CountChangedUp(product, value) {
    this.CountChanged(product, ++value);
  }

  CountChanged(product, value) {
    product.count = value;
    console.log(product);

    this.service.ChangeProductCount(product);
    this.OrderChanged();
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
