import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { GetDataService } from "../get-data.service";

@Component({
  selector: "app-checkout",
  templateUrl: "./checkout.component.html",
  styleUrls: ["./checkout.component.css"],
})
export class CheckoutComponent implements OnInit {
  cart = [];
  constructor(public service: GetDataService, private router: Router) {}

  ngOnInit() {
    this.cart = this.service.GetItemsFromCart();
    if (this.cart.length == 0) this.router.navigate(["/"]);
  }

  // GetImage(item) {
  //   return "images/parts/cpu/" + item.images.split(";")[0].trim();
  // }
}
