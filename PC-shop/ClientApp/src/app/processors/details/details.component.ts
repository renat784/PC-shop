import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Category, GetDataService } from "./../../get-data.service";
import { Cpu } from "./../../Models/Cpu";

@Component({
  selector: "app-details",
  templateUrl: "./details.component.html",
  styleUrls: ["./details.component.css"],
})
export class DetailsComponent implements OnInit {
  cpu: Cpu;

  constructor(private route: ActivatedRoute, public service: GetDataService) {}

  ngOnInit() {
    this.route.params.subscribe((i) => {
      let id = i["id"];

      this.service.GetProduct(Category.Cpu, id).subscribe((i) => {
        this.cpu = i as Cpu;
      });
    });
  }
}
