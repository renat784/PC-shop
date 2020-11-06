import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, NavigationEnd, Router } from "@angular/router";
import { filter } from "rxjs/operators";
import { GetDataService } from "../get-data.service";
import { Location } from "@angular/common";
import { RouterExtService } from "../router-ext.service";

@Component({
  selector: "app-details",
  templateUrl: "./details.component.html",
  styleUrls: ["./details.component.css"],
})
export class DetailsComponent implements OnInit {
  product;
  nameOfCategory;

  constructor(
    private route: ActivatedRoute,
    public location: Location,
    public service: GetDataService
  ) {}

  ngOnInit() {
    this.route.params.subscribe((i) => {
      let productId = i["productId"];
      let categoryId = i["categoryId"];

      this.service.GetProduct(categoryId, productId).subscribe((i) => {
        this.product = i;
        console.log(this.product);
        this.nameOfCategory = this.service.getNameById(categoryId);
        console.log(categoryId);
      });
    });
  }
}
