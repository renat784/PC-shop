import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-keyboard",
  templateUrl: "./keyboard.component.html",
  styleUrls: ["./keyboard.component.css"],
})
export class KeyboardComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
