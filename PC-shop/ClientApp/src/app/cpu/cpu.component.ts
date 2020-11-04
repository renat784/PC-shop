import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cpu",
  templateUrl: "./cpu.component.html",
  styleUrls: ["./cpu.component.css"],
})
export class CpuComponent implements OnInit {
  view;
  productsUpdated;
  countOfProducts = 0;
  constructor() {}

  GetView(view) {
    this.view = view;
  }

  GetCount(count) {
    this.countOfProducts = count;
  }

  ProductsChanged(e) {}

  ngOnInit() {}
}
