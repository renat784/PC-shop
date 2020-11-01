import { Component, OnInit } from "@angular/core";
import { Category, GetDataService } from "../get-data.service";
import { Cpu } from "../Models/Cpu";
import { max, min, count } from "rxjs/operators";
import { of } from "rxjs";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-processors",
  templateUrl: "./processors.component.html",
  styleUrls: ["./processors.component.css"],
})
export class ProcessorsComponent implements OnInit {
  // cpuList: Cpu[];
  // makes = [];
  // cores = [];
  // threads = [];
  // graphics = [];
  // techs = [];
  // priceMin;
  // priceMax;
  // view;

  // ToggleView(e) {
  //   switch (e.target.id) {
  //     case "small":
  //       this.view = "col-3";
  //       this.service.setViewPref({ view: this.view });
  //       break;
  //     case "large":
  //       this.view = "col-4";
  //       this.service.setViewPref({ view: this.view });
  //       break;
  //   }
  // }

  // SortProducts(e) {
  //   let value = e.target.value;
  //   switch (value) {
  //     case "price=asc":
  //       this.router.navigate(["/processors"], {
  //         queryParams: { price: "asc" },
  //       });
  //       break;
  //     case "price=desc":
  //       this.router.navigate(["/processors"], {
  //         queryParams: { price: "desc" },
  //       });
  //       break;
  //     case "id=asc":
  //       this.router.navigate(["/processors"], {
  //         queryParams: { id: "asc" },
  //       });
  //       break;
  //   }
  // }

  // constructor(
  //   public service: GetDataService,
  //   private router: Router,
  //   private route: ActivatedRoute
  // ) {}

  // Sort(query) {
  //   console.log(query);
  //   switch (query.price) {
  //     case "asc":
  //       return this.cpuList.sort((a, b) => a.price - b.price);
  //     case "desc":
  //       return this.cpuList.sort((a, b) => b.price - a.price);
  //     default:
  //       return this.cpuList.sort((a, b) => a.id - b.id);
  //   }
  // }

  ngOnInit() {
    //  set product View 'small' or 'large'
    // let pref = this.service.getViewPref();
    // if (pref) this.view = pref.view;
    // else this.view = "col-3";
    //  get products from service
    // this.service.GetProductList(Category.Cpu).subscribe((i) => {
    //   this.cpuList = i as Cpu[];
    // sort products
    // this.route.queryParams.subscribe((i) => {
    //   if (Object.keys(i).length == 0) {
    //     console.log("no params");
    //   } else {
    //     this.cpuList = this.Sort(i);
    //   }
    // });
    // get unique makes and their count
    // let uniq = new Set();
    // this.cpuList.map((i) => uniq.add(i["make"]));
    // let makesArray = [...uniq];
    // makesArray.map((i) => {
    //   let count = this.cpuList.filter((j) => j.make === i).length;
    //   this.makes.push({ name: i, count: count });
    // });
    // get unique cores and their count
    // let uniqCores = new Set();
    // this.cpuList.map((i) => uniqCores.add(i["countOfCores"]));
    // let coresArray = [...uniqCores];
    // coresArray.map((i) => {
    //   let count = this.cpuList.filter((j) => j.countOfCores === i).length;
    //   this.cores.push({ name: i, count: count });
    // });
    // get unique threads and their count
    // let uniqThreads = new Set();
    // this.cpuList.map((i) => uniqThreads.add(i["countOfThreads"]));
    // let threadsArray = [...uniqThreads];
    // threadsArray.map((i) => {
    //   let count = this.cpuList.filter((j) => j.countOfThreads === i).length;
    //   this.threads.push({ name: i, count: count });
    // });
    // with integrated graphics or not and their count
    // let count = this.cpuList.filter((i) => i.graphics === "Нет").length;
    // this.graphics.push({ name: "Без интегрированной графики", count: count });
    // let countWithGraphics = this.cpuList.length - count;
    // this.graphics.push({
    //   name: "С интегрированной графикой",
    //   count: countWithGraphics,
    // });
    // get unique techProcesses and their count
    // let uniqTechs = new Set();
    // this.cpuList.map((i) => uniqTechs.add(i["techProcess"]));
    // let techArray = [...uniqTechs];
    // techArray.map((i) => {
    //   let count = this.cpuList.filter((j) => j.techProcess === i).length;
    //   this.techs.push({ name: i, count: count });
    // });
    // get min and max prices
    //   let prices = [];
    //   this.cpuList.map((i) => prices.push(i["price"]));
    //   of(...prices)
    //     .pipe(max())
    //     .subscribe((i) => (this.priceMax = i));
    //   of(...prices)
    //     .pipe(min())
    //     .subscribe((i) => (this.priceMin = i));
    // });
  }
}
