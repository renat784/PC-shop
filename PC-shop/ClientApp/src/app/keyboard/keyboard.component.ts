import { Component, OnInit } from "@angular/core";
import { productsEvent } from "../get-data.service";

@Component({
  selector: "app-keyboard",
  templateUrl: "./keyboard.component.html",
  styleUrls: ["./keyboard.component.css"],
})
export class KeyboardComponent implements OnInit {
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
