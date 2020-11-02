import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-motherboard",
  templateUrl: "./motherboard.component.html",
  styleUrls: ["./motherboard.component.css"],
})
export class MotherboardComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
