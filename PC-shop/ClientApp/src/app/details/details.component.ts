import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { GetDataService } from "../get-data.service";

@Component({
  selector: "app-details",
  templateUrl: "./details.component.html",
  styleUrls: ["./details.component.css"],
})
export class DetailsComponent implements OnInit {
  product;
  constructor(private route: ActivatedRoute, public service: GetDataService) {}

  ngOnInit() {
    this.route.params.subscribe((i) => {
      let productId = i["productId"];
      let categoryId = i["categoryId"];

      this.service.GetProduct(categoryId, productId).subscribe((i) => {
        this.product = i;
        console.log(this.product);
      });
    });
  }
}
