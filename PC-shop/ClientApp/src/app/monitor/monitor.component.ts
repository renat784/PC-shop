import { Component, OnInit } from "@angular/core";
import { productsEvent } from "../get-data.service";

@Component({
  selector: "app-monitor",
  templateUrl: "./monitor.component.html",
  styleUrls: ["./monitor.component.css"],
})
export class MonitorComponent implements OnInit {
  view;
  countOfProducts = 0;

  constructor() {}

  // large or small
  GetView(view) {
    this.view = view;
  }

  // count of products
  GetCount(count) {
    this.countOfProducts = count;
  }

  // notice left component about product list changes
  GetProducts(e) {
    productsEvent.emit(e);
  }

  ngOnInit() {}
}
