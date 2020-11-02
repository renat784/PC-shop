import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-videocard",
  templateUrl: "./videocard.component.html",
  styleUrls: ["./videocard.component.css"],
})
export class VideocardComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
