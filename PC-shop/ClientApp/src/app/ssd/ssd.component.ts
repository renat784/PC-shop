import { Component, OnInit } from "@angular/core";
import { of } from "rxjs";
import { max, min } from "rxjs/operators";
import { Category, GetDataService } from "../get-data.service";
import { Ssd } from "../Models/Ssd";

@Component({
  selector: "app-ssd",
  templateUrl: "./ssd.component.html",
  styleUrls: ["./ssd.component.css"],
})
export class SsdComponent implements OnInit {
  // ssdList: Ssd[];
  // makes = [];
  // capacities = [];
  // readSpeeds = [];
  // priceMin;
  // priceMax;

  // GetImage(ssd) {
  //   return "images/parts/ssd/" + ssd.images.split(";")[0];
  // }

  constructor() {}

  ngOnInit() {
    // this.service.GetProductList(Category.Ssd).subscribe((i) => {
    //   this.ssdList = i as Ssd[];
    //   // get unique makes and their count
    //   let uniq = new Set();
    //   this.ssdList.map((i) => uniq.add(i["make"]));
    //   let makesArray = [...uniq];
    //   makesArray.map((i) => {
    //     let count = this.ssdList.filter((j) => j.make === i).length;
    //     this.makes.push({ name: i, count: count });
    //   });
    // get min and max prices
    // let prices = [];
    // this.ssdList.map((i) => prices.push(i["price"]));
    // of(...prices)
    //   .pipe(max())
    //   .subscribe((i) => (this.priceMax = i));
    // of(...prices)
    //   .pipe(min())
    //   .subscribe((i) => (this.priceMin = i));
    // get unique capacities and their count
    // let uniqCap = new Set();
    // this.ssdList.map((i) => uniqCap.add(i["capacity"]));
    // let capArray = [...uniqCap];
    // capArray.map((i) => {
    //   let count = this.ssdList.filter((j) => j.capacity === i).length;
    //   this.capacities.push({ name: i, count: count });
    // });
    // get unique readSpeed of disks and their count
    //   let uniqReads = new Set();
    //   this.ssdList.map((i) => uniqReads.add(i["readSpeed"]));
    //   let readArray = [...uniqReads];
    //   readArray.map((i) => {
    //     let count = this.ssdList.filter((j) => j.readSpeed === i).length;
    //     this.readSpeeds.push({ name: i, count: count });
    //   });
    // });
  }
}
