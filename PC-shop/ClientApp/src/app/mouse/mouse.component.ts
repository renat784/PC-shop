import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-mouse",
  templateUrl: "./mouse.component.html",
  styleUrls: ["./mouse.component.css"],
})
export class MouseComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
