import { Component, OnInit } from "@angular/core";
import { ViewportScroller } from "@angular/common";
import {
  Category,
  GetDataService,
  productsEvent,
} from "src/app/get-data.service";

import { ActivatedRoute, Router } from "@angular/router";
import { of } from "rxjs";
import { max, min } from "rxjs/operators";

@Component({
  selector: "app-left",
  templateUrl: "./left.component.html",
  styleUrls: ["./left.component.css"],
})
export class LeftComponent implements OnInit {
  // common props:
  products;
  productsCopy;
  componentName;
  priceMin;
  priceMax;
  makes = [];
  categoryId;
  queryParams;
  // extra cpu props:
  cpu_cores = [];
  cpu_threads = [];
  cpu_graphics = [];
  cpu_techs = [];
  // extra ssd and hdd props:
  disk_capacities = [];
  disk_readSpeeds = [];
  // extra keyBoard props:
  keyboard_ConnectionTypes = [];
  keyboard_Types = [];
  keyboard_Interfaces = [];
  // extra monitor props:
  monitor_Sizes = [];
  monitor_Freqs = [];
  monitor_Resolutions = [];
  monitor_Matrixes = [];
  monitor_AspectRatios = [];
  // extra motheboard props:
  motherBoard_Sockets = [];
  motherBoard_FormFactors = [];
  motherBoard_Memories = [];
  motherBoard_Videos = [];
  // extra mouse props:
  mouse_ConnectionTypes = [];
  mouse_Sizes = [];
  mouse_Interfaces = [];
  mouse_Purposes = [];
  // extra ram props:
  ram_Capacities = [];
  ram_MemoryTypes = [];
  ram_Frequncies = [];
  ram_Purposes = [];
  // extra videocards props:
  videoCard_MemorySizes = [];
  videoCard_MemoryTypes = [];
  videoCard_Purposes = [];

  CheckboxChanged(e, propertyName) {
    let name = e.target.id;
    // cleaning id from 'core_10' to '10'
    name = name.split("_")[1];
    // when we check checkbox - we add data to query string in url
    if (e.target.checked) {
      if (this.queryParams[propertyName]) {
        // adds only unique values
        let queryVal = [];
        let q = this.queryParams[propertyName] as string;
        // 1 value in string
        if (q.indexOf(",") == -1) {
          queryVal.push(q);
          // many values in string
        } else {
          queryVal = q.split(",");
        }
        if (queryVal.indexOf(name) == -1) {
          this.queryParams[propertyName] += "," + name;
        }
      } else {
        // this.queryParams = { ...this.queryParams, propertyName: name };
        this.queryParams = { ...this.queryParams };
        this.queryParams[propertyName] = name;
      }
      // when we uncheck checkbox - we remove data from query string in url
    } else {
      let newPropertyName = "";
      newPropertyName = this.queryParams[propertyName];
      let array = newPropertyName.split(",");
      array = array.filter((i) => i !== name);
      if (array.length == 0) {
        // if we don't have values - delete property
        // just to avoid this in url: make=""
        delete this.queryParams[propertyName];
      } else {
        this.queryParams[propertyName] = array.toString();
      }
    }

    let query = { queryParams: this.queryParams };

    this.router.navigate(["/" + this.componentName], query);
  }

  PriceRangeChanged() {
    let query = { queryParams: this.queryParams };

    // if (this.queryParams["price"]) {
    //   let prices = this.queryParams["price"].split("-");
    //   this.queryParams.price = prices[0] + "-" + prices[1];
    // } else {
    //   this.queryParams.price = this.priceMin + "-" + this.priceMax;
    // }
    this.queryParams.price = this.priceMin + "-" + this.priceMax;
    console.log(this.queryParams);

    this.router.navigate(["/" + this.componentName], query);
  }

  // sets checked checkboxes from url
  SetCheckboxes(array, propertyName) {
    let value = this.queryParams[propertyName] as string;

    // no value
    if (!value) return;

    // 1 value
    if (value.indexOf(",") == -1) {
      array.map((i) => {
        let name = i.name;
        let index;
        if (value == name) {
          index = array.findIndex((j) => j.name == name);
          array[index].checked = true;
        }
      });
    }

    // many values
    if (value.indexOf(",") != -1) {
      console.log("many values");
      let queryVal = value.split(",");

      array.map((i) => {
        let name = i.name;
        let index;
        if (queryVal.findIndex((i) => i == name) != -1) {
          index = array.findIndex((j) => j.name == name);
          array[index].checked = true;
        }
      });
    }
  }

  constructor(
    public service: GetDataService,
    private route: ActivatedRoute,
    private router: Router,
    private viewportScroller: ViewportScroller
  ) {}

  public onClick(elementId: string): void {
    this.viewportScroller.scrollToAnchor(elementId);
  }

  ReBuildControls() {
    // get unique makes and their count
    this.makes = this.GetUniques("make");

    // set 'make' checked checkboxes from url
    this.SetCheckboxes(this.makes, "make");

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
      this.cpu_cores = this.GetUniques("countOfCores");

      // get unique threads and their count
      this.cpu_threads = this.GetUniques("countOfThreads");

      // with integrated graphics or not and their count
      this.cpu_graphics = this.GetUniques("graphics");

      // get unique techProcesses and their count
      this.cpu_techs = this.GetUniques("techProcess");

      // set 'cores' checked checkboxes from url
      this.SetCheckboxes(this.cpu_cores, "countOfCores");

      // set 'threads' checked checkboxes from url
      this.SetCheckboxes(this.cpu_threads, "countOfThreads");

      // set 'integrated video' checked checkboxes from url
      this.SetCheckboxes(this.cpu_graphics, "graphics");

      // set 'techs' checked checkboxes from url
      this.SetCheckboxes(this.cpu_techs, "techProcess");
    }

    // specific fo ssd and hdd:
    if (this.categoryId == Category.Ssd || this.categoryId == Category.Hdd) {
      // get unique capacities and their count
      this.disk_capacities = this.GetUniques("capacity");

      // get unique readSpeed of disks and their count
      this.disk_readSpeeds = this.GetUniques("readSpeed");

      // set 'capacities' checked checkboxes from url
      this.SetCheckboxes(this.disk_capacities, "capacity");

      // set 'read speeds' checked checkboxes from url
      this.SetCheckboxes(this.disk_readSpeeds, "readSpeed");
    }

    // specific for keyboard
    if (this.categoryId == Category.Keyboard) {
      // get unique connection types and their count
      this.keyboard_ConnectionTypes = this.GetUniques("connectionType");

      // get unique interfaces and their count
      this.keyboard_Interfaces = this.GetUniques("interface");

      // get unique keyboard types and their count
      this.keyboard_Types = this.GetUniques("type");

      // set 'connection types' checked checkboxes from url
      this.SetCheckboxes(this.keyboard_ConnectionTypes, "connectionType");

      // set 'interfaces' checked checkboxes from url
      this.SetCheckboxes(this.keyboard_Interfaces, "interface");

      // set 'types' checked checkboxes from url
      this.SetCheckboxes(this.keyboard_Types, "type");
    }

    // specific for monitor
    if (this.categoryId == Category.Monitor) {
      // get unique monitor sizes and their count
      this.monitor_Sizes = this.GetUniques("size");

      // get unique Frequencies of monitors and their count
      this.monitor_Freqs = this.GetUniques("frequency");

      // get unique resolutions and their count
      this.monitor_Resolutions = this.GetUniques("resolution");

      // get unique Matrix types and their count
      this.monitor_Matrixes = this.GetUniques("matrixType");

      // get unique AspectRatio types and their count
      this.monitor_AspectRatios = this.GetUniques("aspectRatio");

      // set 'monitor size' checked checkboxes from url
      this.SetCheckboxes(this.monitor_Sizes, "size");

      // set 'frequencies' checked checkboxes from url
      this.SetCheckboxes(this.monitor_Freqs, "frequency");

      // set 'resolutions' checked checkboxes from url
      this.SetCheckboxes(this.monitor_Resolutions, "resolution");

      // set 'matrix' checked checkboxes from url
      this.SetCheckboxes(this.monitor_Matrixes, "matrixType");

      // set 'aspect ratio' checked checkboxes from url
      this.SetCheckboxes(this.monitor_AspectRatios, "aspectRatio");
    }

    // specific for motherboard
    if (this.categoryId == Category.Motherboard) {
      // get unique sockets and their count
      this.motherBoard_Sockets = this.GetUniques("socket");

      // get unique FormFactor and their count
      this.motherBoard_FormFactors = this.GetUniques("formFactor");

      // get unique MemorySupports and their count
      this.motherBoard_Memories = this.GetUniques("memorySupport");

      // get unique VideoExits and their count
      this.motherBoard_Videos = this.GetUniques("videoExit");

      // set 'sockets' checked checkboxes from url
      this.SetCheckboxes(this.motherBoard_Sockets, "socket");

      // set 'form factor' checked checkboxes from url
      this.SetCheckboxes(this.motherBoard_FormFactors, "formFactor");

      // set 'memories' checked checkboxes from url
      this.SetCheckboxes(this.motherBoard_Memories, "memorySupport");

      // set 'video' checked checkboxes from url
      this.SetCheckboxes(this.motherBoard_Videos, "videoExit");
    }

    // specific for mouse
    if (this.categoryId == Category.Mouse) {
      // get unique connection types and their count
      this.mouse_ConnectionTypes = this.GetUniques("connectionType");
      // get unique interfaces and their count
      this.mouse_Interfaces = this.GetUniques("interface");

      // get unique sizes and their count
      this.mouse_Sizes = this.GetUniques("size");

      // get unique purposes and their count
      this.mouse_Purposes = this.GetUniques("purpose");

      // set 'connection' checked checkboxes from url
      this.SetCheckboxes(this.mouse_ConnectionTypes, "connectionType");

      // set 'interface' checked checkboxes from url
      this.SetCheckboxes(this.mouse_Interfaces, "interface");

      // set 'size' checked checkboxes from url
      this.SetCheckboxes(this.mouse_Sizes, "size");

      // set 'purpose' checked checkboxes from url
      this.SetCheckboxes(this.mouse_Purposes, "purpose");
    }

    // specific for ram
    if (this.categoryId == Category.Ram) {
      // get unique capacities and their count
      this.ram_Capacities = this.GetUniques("capacity");

      // get unique memory types and their count
      this.ram_MemoryTypes = this.GetUniques("memoryType");

      // get unique Frequencies and their count
      this.ram_Frequncies = this.GetUniques("frequency");

      // get unique purposes and their count
      this.ram_Purposes = this.GetUniques("purpose");

      // set 'capacity' checked checkboxes from url
      this.SetCheckboxes(this.ram_Capacities, "capacity");

      // set 'memory' checked checkboxes from url
      this.SetCheckboxes(this.ram_MemoryTypes, "memoryType");

      // set 'frequencies' checked checkboxes from url
      this.SetCheckboxes(this.ram_Frequncies, "frequency");

      // set 'purpose' checked checkboxes from url
      this.SetCheckboxes(this.ram_Purposes, "purpose");
    }

    // specific for video card
    if (this.categoryId == Category.Videocard) {
      // get unique MemorySizes and their count
      this.videoCard_MemorySizes = this.GetUniques("memorySize");

      // get unique memory types and their count
      this.videoCard_MemoryTypes = this.GetUniques("memoryType");

      // get unique purposes and their count
      this.videoCard_Purposes = this.GetUniques("purpose");

      // set 'memory size' checked checkboxes from url
      this.SetCheckboxes(this.videoCard_MemorySizes, "memorySize");

      // set 'memory type' checked checkboxes from url
      this.SetCheckboxes(this.videoCard_MemoryTypes, "memoryType");

      // set 'purpose' checked checkboxes from url
      this.SetCheckboxes(this.videoCard_Purposes, "purpose");
    }
  }

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
      result.push({ name: i, count: count, checked: false });
    });

    return result;
  }

  ngOnInit() {
    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    // get category id
    this.categoryId = this.service.GetCategoryId(this.componentName);

    this.service.GetProductList(this.categoryId).subscribe((i) => {
      this.products = i;
      console.log(this.products);

      this.route.queryParams.subscribe((i) => {
        this.queryParams = { ...i };
        // when products list in right component changes - we'll change
        // product list here and rebuild all components
        productsEvent.subscribe((data) => {
          console.log(data);
          this.products = data;
          this.ReBuildControls();
        });
      });
    });
  }
}
