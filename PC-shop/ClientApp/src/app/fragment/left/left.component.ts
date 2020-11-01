import { Component, OnInit } from "@angular/core";
import {
  Category,
  CategoryName,
  GetDataService,
} from "src/app/get-data.service";
import { ActivatedRoute } from "@angular/router";
import { of } from "rxjs";
import { max, min } from "rxjs/operators";

@Component({
  selector: "app-left",
  templateUrl: "./left.component.html",
  styleUrls: ["./left.component.css"],
})
export class LeftComponent implements OnInit {
  products;
  componentName;
  priceMin;
  priceMax;
  makes = [];
  categoryId;
  // cpu props:
  cores = [];
  threads = [];
  graphics = [];
  techs = [];
  // ssd props:
  capacities = [];
  readSpeeds = [];

  constructor(public service: GetDataService, private route: ActivatedRoute) {}

  ngOnInit() {
    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    this.categoryId = this.service.GetCategoryId(this.componentName);

    this.service.GetProductList(this.categoryId).subscribe((i) => {
      this.products = i;

      // get unique makes and their count
      let uniq = new Set();
      this.products.map((i) => uniq.add(i["make"]));
      let makesArray = [...uniq];

      makesArray.map((i) => {
        let count = this.products.filter((j) => j.make === i).length;
        this.makes.push({ name: i, count: count });
      });

      // get min and max prices
      let prices = [];
      this.products.map((i) => prices.push(i["price"]));
      of(...prices)
        .pipe(max())
        .subscribe((i) => (this.priceMax = i));

      of(...prices)
        .pipe(min())
        .subscribe((i) => (this.priceMin = i));

      // specific for cpu
      if (this.categoryId == Category.Cpu) {
        // get unique cores and their count
        let uniqCores = new Set();
        this.products.map((i) => uniqCores.add(i["countOfCores"]));
        let coresArray = [...uniqCores];

        coresArray.map((i) => {
          let count = this.products.filter((j) => j.countOfCores === i).length;
          this.cores.push({ name: i, count: count });
        });

        // get unique threads and their count
        let uniqThreads = new Set();
        this.products.map((i) => uniqThreads.add(i["countOfThreads"]));
        let threadsArray = [...uniqThreads];

        threadsArray.map((i) => {
          let count = this.products.filter((j) => j.countOfThreads === i)
            .length;
          this.threads.push({ name: i, count: count });
        });

        // with integrated graphics or not and their count
        let count = this.products.filter((i) => i.graphics === "Нет").length;

        this.graphics.push({
          name: "Без интегрированной графики",
          count: count,
        });

        let countWithGraphics = this.products.length - count;

        this.graphics.push({
          name: "С интегрированной графикой",
          count: countWithGraphics,
        });

        // get unique techProcesses and their count
        let uniqTechs = new Set();
        this.products.map((i) => uniqTechs.add(i["techProcess"]));
        let techArray = [...uniqTechs];

        techArray.map((i) => {
          let count = this.products.filter((j) => j.techProcess === i).length;
          this.techs.push({ name: i, count: count });
        });
      }

      // specific fo ssd:
      if (this.categoryId == Category.Ssd) {
        // get unique capacities and their count
        let uniqCap = new Set();
        this.products.map((i) => uniqCap.add(i["capacity"]));
        let capArray = [...uniqCap];

        capArray.map((i) => {
          let count = this.products.filter((j) => j.capacity === i).length;
          this.capacities.push({ name: i, count: count });
        });

        // get unique readSpeed of disks and their count
        let uniqReads = new Set();
        this.products.map((i) => uniqReads.add(i["readSpeed"]));
        let readArray = [...uniqReads];

        readArray.map((i) => {
          let count = this.products.filter((j) => j.readSpeed === i).length;
          this.readSpeeds.push({ name: i, count: count });
        });
      }
    });
  }
}
