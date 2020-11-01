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

  // GetImage(ssd) {
  //   return "images/parts/ssd/" + ssd.images.split(";")[0].trim();
  // }

  // GetImages() {
  //   let array = this.ssd.images.split(";");
  //   for (let index = 0; index < array.length; index++) {
  //     const element = array[index];
  //     array[index] = "images/parts/ssd/" + element.trim();
  //   }
  //   return array;
  // }

  ngOnInit() {
    this.route.params.subscribe((i) => {
      let id = i["id"];

      this.service.GetProduct(Category.Ssd, id).subscribe((i) => {
        this.ssd = i as Ssd;
      });
    });
  }
}
