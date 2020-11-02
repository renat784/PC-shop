import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-monitor",
  templateUrl: "./monitor.component.html",
  styleUrls: ["./monitor.component.css"],
})
export class MonitorComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
