import { Component, OnInit } from "@angular/core";
import { of } from "rxjs";
import { max, min } from "rxjs/operators";
import { Category, GetDataService } from "../get-data.service";
import { Ssd } from "../Models/Ssd";

@Component({
  selector: "app-ssd",
  templateUrl: "./ssd.component.html",
  styleUrls: ["./ssd.component.css"],
})
export class SsdComponent implements OnInit {
  view;
  constructor() {}

  GetView(e) {
    this.view = e;
  }
  ngOnInit() {}
}
