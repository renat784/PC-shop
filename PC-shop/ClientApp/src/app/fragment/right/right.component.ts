import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import {
  Category,
  CategoryName,
  GetDataService,
} from "src/app/get-data.service";
import { Router } from "@angular/router";
import { ActivatedRoute } from "@angular/router";
import { stringify } from "querystring";

@Component({
  selector: "app-right",
  templateUrl: "./right.component.html",
  styleUrls: ["./right.component.css"],
})
export class RightComponent implements OnInit {
  categoryId;
  products;
  productsSorted;
  componentName;
  queryParams;

  @Input() view;
  @Output() productsChanged = new EventEmitter();
  @Output() countChanged = new EventEmitter<number>();

  constructor(
    public service: GetDataService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  // sets checked checkboxes from url
  QueryUrl(propertyName) {
    let value = this.queryParams[propertyName] as string;

    // gets unique names in property
    let array = new Set();
    console.log(this.productsSorted);
    this.productsSorted.map((i) => array.add(i[propertyName]));
    // 1 value
    if (value.indexOf(",") == -1) {
      console.log(this.productsSorted);

      array.forEach((i) => {
        let name = i;

        if (value == name) {
          this.productsSorted = this.productsSorted.filter(
            (i) => i[propertyName] == value
          );
        }
      });
    }
    // many values
    if (value.indexOf(",") != -1) {
      // this.productsSorted = this.products;

      // gets unique names in property
      // let array = new Set();
      // this.productsSorted.map((i) => array.add(i[propertyName]));

      console.log("many values");
      let localSorted = [];
      let queryArray = value.split(",");

      array.forEach((i) => {
        let name = i.toString();

        console.log(array);
        console.log(name);
        console.log(queryArray);
        console.log(this.productsSorted);

        if (queryArray.indexOf(name) != -1) {
          console.log("found:" + name);

          let filtered = this.productsSorted.filter(
            (i) => i[propertyName] == name
          );
          localSorted = [...filtered, ...localSorted];
        }
      });
      this.productsSorted = localSorted;

      console.log(this.productsSorted);
      // notice left component about changes in products
      // this.productsChanged.emit(this.productsSorted);
    }
  }

  //  query = {sort: 'price_asc', make: 'intel', ...}
  Sort(query) {
    // we get all data to filter and display
    this.productsSorted = this.products;

    console.log("sorting...");

    if (query.make) {
      this.QueryUrl("make");
    }

    // specific for cpu:
    if (this.componentName == "cpu") {
      console.log(this.productsSorted);

      if (query.countOfCores) {
        this.QueryUrl("countOfCores");
      }

      if (query.countOfThreads) {
        this.QueryUrl("countOfThreads");
      }

      if (query.graphics) {
        this.QueryUrl("graphics");
      }

      if (query.techProcess) {
        this.QueryUrl("techProcess");
      }
    }

    if (query.sort) {
      switch (query.sort) {
        case "price_asc":
          this.productsSorted.sort((a, b) => a.price - b.price);
          break;
        case "price_desc":
          this.productsSorted.sort((a, b) => b.price - a.price);
          break;
        case "asc":
          this.productsSorted.sort((a, b) => a.id - b.id);
          break;
      }
    }
  }

  ngOnInit() {
    console.log("init");

    //  get view pref for products
    this.view = this.service.getViewPref().view;

    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    this.categoryId = this.service.GetCategoryId(this.componentName);

    this.service.GetProductList(this.categoryId).subscribe((i) => {
      this.products = i;
      this.productsSorted = i;

      // sort products
      // method Sort() runs everytime when query string in url changes
      this.route.queryParams.subscribe((i) => {
        if (Object.keys(i).length == 0) {
          this.productsSorted = this.products;
        } else {
          this.queryParams = { ...i };
          this.Sort(this.queryParams);
          console.log("query changed");
        }

        console.log(this.productsSorted);
        this.countChanged.emit(this.productsSorted.length);
      });
    });
  }
}
