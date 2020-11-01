import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { GetDataService } from "src/app/get-data.service";

@Component({
  selector: "app-top",
  templateUrl: "./top.component.html",
  styleUrls: ["./top.component.css"],
})
export class TopComponent implements OnInit {
  @Input() title;
  @Output() viewChanged = new EventEmitter<string>();
  view;
  componentName;

  constructor(
    private router: Router,
    private service: GetDataService,
    private route: ActivatedRoute
  ) {}

  SortProducts(e) {
    let value = e.target.value;
    switch (value) {
      case "price=asc":
        this.router.navigate(["/" + this.componentName], {
          queryParams: { price: "asc" },
        });
        break;
      case "price=desc":
        this.router.navigate(["/" + this.componentName], {
          queryParams: { price: "desc" },
        });
        break;
      case "sort=asc":
        this.router.navigate(["/" + this.componentName], {
          queryParams: { sort: "asc" },
        });
        break;
    }
  }

  ToggleView(e) {
    switch (e.target.id) {
      case "small":
        this.viewChanged.emit("col-3");
        this.service.setViewPref({ view: "col-3" });
        break;
      case "large":
        this.viewChanged.emit("col-4");
        this.service.setViewPref({ view: "col-4" });
        break;
    }
  }

  ngOnInit() {
    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);
  }
}
