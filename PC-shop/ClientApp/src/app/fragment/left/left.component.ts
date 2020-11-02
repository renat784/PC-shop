import { Component, OnInit } from "@angular/core";
import { Category, GetDataService } from "src/app/get-data.service";
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
  // ssd and hdd props:
  capacities = [];
  readSpeeds = [];
  // keyBoard props:
  keyboardConnectionTypes = [];
  keyboardTypes = [];
  keyboardInterfaces = [];
  // monitor props:
  monitorSizes = [];
  monitorFreqs = [];
  monitorResolutions = [];
  monitorMatrixes = [];
  monitorAspectRatios = [];
  // motheboard props:
  motherBoardSockets = [];
  motherBoardFormFactors = [];
  motherBoardMemories = [];
  motherBoardVideos = [];
  // mouse props:
  mouseConnectionTypes = [];
  mouseSizes = [];
  mouseInterfaces = [];
  mousePurposes = [];
  // ram props:
  ramCapacities = [];
  ramMemoryTypes = [];
  ramFrequncies = [];
  ramPurposes = [];
  // videocards props:
  videoCardMemorySizes = [];
  videoCardMemoryTypes = [];
  videoCardPurposes = [];

  constructor(public service: GetDataService, private route: ActivatedRoute) {}

  // when user presses backspace to correct input value
  MakesFilterBackspace(e: string) {
    if (this.makes.length == 0) {
      this.makes = this.GetUniques("make");
    }
    e = e.trim();
    let length = e.length;
    let result = e.slice(0, length - 1);
    this.MakesFilter(result);
  }

  // displaying only options by user input
  MakesFilter(value) {
    value = value.trim();
    if (value == "") {
      this.makes = this.GetUniques("make");
    }

    let data = [];
    this.makes.forEach((i) => {
      let name = i.name;
      let match = (name as string).toLowerCase().match(value);
      if (match) {
        data.push(i);
      }
    });
    this.makes = data;
    console.log(data);
  }

  GetUniques(propertyName) {
    let uniqs = new Set();
    this.products.map((i) => uniqs.add(i[propertyName]));
    let array = [...uniqs];

    let result = [];
    array.map((i) => {
      let count = this.products.filter((j) => j[propertyName] === i).length;
      result.push({ name: i, count: count });
    });

    return result;
  }

  ngOnInit() {
    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    this.categoryId = this.service.GetCategoryId(this.componentName);

    this.service.GetProductList(this.categoryId).subscribe((i) => {
      this.products = i;

      // get unique makes and their count
      this.makes = this.GetUniques("make");

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
        this.cores = this.GetUniques("countOfCores");

        // get unique threads and their count
        this.threads = this.GetUniques("countOfThreads");

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
        this.techs = this.GetUniques("techProcess");
      }

      // specific fo ssd and hdd:
      if (this.categoryId == Category.Ssd || this.categoryId == Category.Hdd) {
        // get unique capacities and their count
        this.capacities = this.GetUniques("capacity");

        // get unique readSpeed of disks and their count
        this.readSpeeds = this.GetUniques("readSpeed");
      }

      // specific for keyboard
      if (this.categoryId == Category.Keyboard) {
        // get unique connection types and their count
        this.keyboardConnectionTypes = this.GetUniques("connectionType");

        // get unique interfaces and their count
        this.keyboardInterfaces = this.GetUniques("interface");

        // get unique keyboard types and their count
        this.keyboardTypes = this.GetUniques("type");
      }

      // specific for monitor
      if (this.categoryId == Category.Monitor) {
        // get unique monitor sizes and their count
        this.monitorSizes = this.GetUniques("size");

        // get unique Frequencies of monitors and their count
        this.monitorFreqs = this.GetUniques("frequency");

        // get unique resolutions and their count
        this.monitorResolutions = this.GetUniques("resolution");

        // get unique Matrix types and their count
        this.monitorMatrixes = this.GetUniques("matrixType");

        // get unique AspectRatio types and their count
        this.monitorAspectRatios = this.GetUniques("aspectRatio");
      }

      // specific for motherboard
      if (this.categoryId == Category.Motherboard) {
        // get unique sockets and their count
        this.motherBoardSockets = this.GetUniques("socket");

        // get unique FormFactor and their count
        this.motherBoardFormFactors = this.GetUniques("formFactor");

        // get unique MemorySupports and their count
        this.motherBoardMemories = this.GetUniques("memorySupport");

        // get unique VideoExits and their count
        this.motherBoardVideos = this.GetUniques("videoExit");
      }

      // specific for mouse
      if (this.categoryId == Category.Mouse) {
        // get unique connection types and their count
        this.mouseConnectionTypes = this.GetUniques("connectionType");
        // get unique interfaces and their count
        this.mouseInterfaces = this.GetUniques("interface");

        // get unique sizes and their count
        this.mouseSizes = this.GetUniques("size");

        // get unique purposes and their count
        this.mousePurposes = this.GetUniques("purpose");
      }

      // specific for ram
      if (this.categoryId == Category.Ram) {
        // get unique capacities and their count
        this.ramCapacities = this.GetUniques("capacity");

        // get unique memory types and their count
        this.ramMemoryTypes = this.GetUniques("memoryType");

        // get unique Frequencies and their count
        this.ramFrequncies = this.GetUniques("frequency");

        // get unique purposes and their count
        this.ramPurposes = this.GetUniques("purpose");
      }

      // specific for video card
      if (this.categoryId == Category.Videocard) {
        // get unique MemorySizes and their count
        this.videoCardMemorySizes = this.GetUniques("memorySize");

        // get unique memory types and their count
        this.videoCardMemoryTypes = this.GetUniques("memoryType");

        // get unique purposes and their count
        this.videoCardPurposes = this.GetUniques("purpose");
      }
    });
  }
}
