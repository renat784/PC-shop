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

  // GetImage(cpu) {
  //   return "images/parts/cpu/" + cpu.images.split(";")[0].trim();
  // }

  // GetImages() {
  //   let array = this.cpu.images.split(";");
  //   for (let index = 0; index < array.length; index++) {
  //     const element = array[index];
  //     array[index] = "images/parts/cpu/" + element.trim();
  //   }
  //   return array;
  // }

  ngOnInit() {
    this.route.params.subscribe((i) => {
      let id = i["id"];

      this.service.GetProduct(Category.Cpu, id).subscribe((i) => {
        this.cpu = i as Cpu;
      });
    });
  }
}
