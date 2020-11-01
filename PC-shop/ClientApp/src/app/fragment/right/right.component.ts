import { Component, OnInit } from "@angular/core";
import {
  Category,
  CategoryName,
  GetDataService,
} from "src/app/get-data.service";
import { Router } from "@angular/router";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-right",
  templateUrl: "./right.component.html",
  styleUrls: ["./right.component.css"],
})
export class RightComponent implements OnInit {
  categoryId;
  products;
  componentName;
  constructor(
    public service: GetDataService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  Sort(query) {
    console.log(query);
    switch (query.price) {
      case "asc":
        return this.products.sort((a, b) => a.price - b.price);
      case "desc":
        return this.products.sort((a, b) => b.price - a.price);
      default:
        return this.products.sort((a, b) => a.id - b.id);
    }
  }

  ngOnInit() {
    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    this.categoryId = this.service.GetCategoryId(this.componentName);

    console.log(this.componentName);

    this.service.GetProductList(this.categoryId).subscribe((i) => {
      this.products = i;

      // sort products
      this.route.queryParams.subscribe((i) => {
        if (Object.keys(i).length == 0) {
          console.log("no params");
        } else {
          this.products = this.Sort(i);
        }
      });
    });
  }
}
