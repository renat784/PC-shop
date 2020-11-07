import { Component, EventEmitter, OnInit } from "@angular/core";

import { GetDataService } from "../get-data.service";

export let orderChanged = new EventEmitter<boolean>();
// export let promocodeChanged = new EventEmitter();

@Component({
  selector: "app-nav-menu",
  templateUrl: "./nav-menu.component.html",
  styleUrls: ["./nav-menu.component.css"],
})
export class NavMenuComponent implements OnInit {
  // oldTotal = 0;

  constructor(public service: GetDataService) {}

  OrderChanged() {
    orderChanged.emit(true);
  }

  // InputForPromocodeChanged(val) {
  //   if (val == "RENAT") {
  //     this.oldTotal = this.service.PriceTotal();
  //     this.discount = 75;
  //     promocodeChanged.emit({ name: "RENAT", percents: this.discount });
  //   } else {
  //     this.oldTotal = 0;
  //     this.discount = 0;
  //   }
  // }

  ngOnInit(): void {}
  isExpanded = false;
  // discount = 0;

  // GetImage(item) {
  //   return "images/parts/cpu/" + item.images.split(";")[0].trim();
  // }

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
