import { Component, OnInit } from "@angular/core";
import { GetDataService } from "../get-data.service";

@Component({
  selector: "app-nav-menu",
  templateUrl: "./nav-menu.component.html",
  styleUrls: ["./nav-menu.component.css"],
})
export class NavMenuComponent implements OnInit {
  constructor(public service: GetDataService) {}

  ngOnInit(): void {}
  isExpanded = false;

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
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
