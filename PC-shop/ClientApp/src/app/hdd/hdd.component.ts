import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-hdd",
  templateUrl: "./hdd.component.html",
  styleUrls: ["./hdd.component.css"],
})
export class HddComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
