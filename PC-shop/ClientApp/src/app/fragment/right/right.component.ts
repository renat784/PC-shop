import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { GetDataService } from "src/app/get-data.service";
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
  productsSorted;
  componentName;
  queryParams;

  @Input() view;
  @Output() productsChanged = new EventEmitter();
  @Output() countChanged = new EventEmitter<number>();

  constructor(public service: GetDataService, private route: ActivatedRoute) {}

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

    console.log(query);

    if (query.price) {
      console.log(this.productsSorted);

      let prices = query.price.split("-");
      let min = parseInt(prices[0]);
      let max = parseInt(prices[1]);

      let some = [];
      this.productsSorted.map((i) => {
        if (i.price >= min && i.price <= max) some.push(i);
      });
      this.productsSorted = some;
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

    // specific for hdd and ssd:
    if (this.componentName == "hdd" || this.componentName == "ssd") {
      console.log(this.productsSorted);

      if (query.capacity) {
        this.QueryUrl("capacity");
      }

      if (query.readSpeed) {
        this.QueryUrl("readSpeed");
      }
    }

    // specific for keyboard:
    if (this.componentName == "keyboard") {
      console.log(this.productsSorted);

      if (query.connectionType) {
        this.QueryUrl("connectionType");
      }

      if (query.interface) {
        this.QueryUrl("interface");
      }

      if (query.type) {
        this.QueryUrl("type");
      }
    }

    // specific for monitor:
    if (this.componentName == "monitor") {
      console.log(this.productsSorted);

      if (query.size) {
        this.QueryUrl("size");
      }

      if (query.frequency) {
        this.QueryUrl("frequency");
      }

      if (query.resolution) {
        this.QueryUrl("resolution");
      }

      if (query.matrixType) {
        this.QueryUrl("matrixType");
      }

      if (query.aspectRatio) {
        this.QueryUrl("aspectRatio");
      }
    }

    // specific for motherboard:
    if (this.componentName == "motherboard") {
      console.log(this.productsSorted);

      if (query.socket) {
        this.QueryUrl("socket");
      }

      if (query.formFactor) {
        this.QueryUrl("formFactor");
      }

      if (query.memorySupport) {
        this.QueryUrl("memorySupport");
      }

      if (query.videoExit) {
        this.QueryUrl("videoExit");
      }
    }

    // specific for mouse:
    if (this.componentName == "mouse") {
      console.log(this.productsSorted);

      if (query.connectionType) {
        this.QueryUrl("connectionType");
      }

      if (query.interface) {
        this.QueryUrl("interface");
      }

      if (query.size) {
        this.QueryUrl("size");
      }

      if (query.purpose) {
        this.QueryUrl("purpose");
      }
    }

    // specific for ram:
    if (this.componentName == "ram") {
      console.log(this.productsSorted);

      if (query.capacity) {
        this.QueryUrl("capacity");
      }

      if (query.memoryType) {
        this.QueryUrl("memoryType");
      }

      if (query.frequency) {
        this.QueryUrl("frequency");
      }

      if (query.purpose) {
        this.QueryUrl("purpose");
      }
    }

    // specific for videocard:
    if (this.componentName == "videocard") {
      console.log(this.productsSorted);

      if (query.memorySize) {
        this.QueryUrl("memorySize");
      }

      if (query.memoryType) {
        this.QueryUrl("memoryType");
      }

      if (query.purpose) {
        this.QueryUrl("purpose");
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
        // send data to top component
        this.countChanged.emit(this.productsSorted.length);
        // send data to right component

        this.productsChanged.emit(this.productsSorted);
      });
    });
  }
}
