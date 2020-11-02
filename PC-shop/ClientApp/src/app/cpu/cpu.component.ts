import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cpu",
  templateUrl: "./cpu.component.html",
  styleUrls: ["./cpu.component.css"],
})
export class CpuComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
