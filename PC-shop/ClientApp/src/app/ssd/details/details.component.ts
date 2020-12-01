import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Category, GetDataService } from "src/app/get-data.service";
import { Ssd } from "./../../Models/Ssd";

@Component({
  selector: "app-details",
  templateUrl: "./details.component.html",
  styleUrls: ["./details.component.css"],
})
export class DetailsComponent implements OnInit {
  ssd: Ssd;

  constructor(private route: ActivatedRoute, public service: GetDataService) {}

  ngOnInit() {
    this.route.params.subscribe((i) => {
      let id = i["id"];

      this.service.GetProduct(Category.Ssd, id).subscribe((i) => {
        this.ssd = i as Ssd;
      });
    });
  }
}
