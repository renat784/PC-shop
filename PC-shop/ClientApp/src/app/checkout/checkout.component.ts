import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { GetDataService } from "../get-data.service";
import { orderChanged, promocodeChanged } from "../nav-menu/nav-menu.component";

@Component({
  selector: "app-checkout",
  templateUrl: "./checkout.component.html",
  styleUrls: ["./checkout.component.css"],
})
export class CheckoutComponent implements OnInit {
  cart = [];
  promocode;

  constructor(public service: GetDataService, private router: Router) {}

  CheckCart() {
    this.cart = this.service.GetItemsFromCart();
    if (this.cart.length == 0) this.router.navigate(["/"]);
  }

  CancelOrder() {
    this.service.RemoveItemsFromCart();
    this.router.navigate(["/"]);
  }

  ngOnInit() {
    orderChanged.subscribe((i) => {
      if (i) this.CheckCart();
    });

    promocodeChanged.subscribe((i) => {
      this.promocode = i;
    });

    this.CheckCart();
  }

  // GetImage(item) {
  //   return "images/parts/cpu/" + item.images.split(";")[0].trim();
  // }
}
