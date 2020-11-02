import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { FormControl } from "@angular/forms";
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

  sortOptions = [];

  constructor(
    private router: Router,
    private service: GetDataService,
    private route: ActivatedRoute
  ) {
    this.sortOptions = [
      {
        name: "От дешевых к дорогим",
        value: "price=asc",
        selected: false,
      },
      {
        name: "От дорогих к дешевым",
        value: "price=desc",
        selected: false,
      },
      {
        name: "По порядку",
        value: "sort=asc",
        selected: true,
      },
    ];
  }

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
        this.view = "col-3";
        this.viewChanged.emit(this.view);
        this.service.setViewPref({ view: this.view });
        break;
      case "large":
        this.view = "col-4";
        this.viewChanged.emit(this.view);
        this.service.setViewPref({ view: this.view });
        break;
    }
    // this.router.navigate([this.componentName], {queryParams: {}});
    // console.log("clicked");
  }

  ChangeSelected(sortParam) {
    let index = this.sortOptions.findIndex((i) => i.value == sortParam);
    this.sortOptions.map((i) => (i.selected = false));
    this.sortOptions[index].selected = true;
  }

  ngOnInit() {
    // add active class to view toggle
    this.view = this.service.getViewPref().view;
    console.log(this.view);

    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    // set sort select option from url
    this.route.queryParams.subscribe((i) => {
      let sortParam;

      if (i.sort == "asc") {
        sortParam = "sort=asc";
        this.ChangeSelected(sortParam);
      } else if (i.price == "asc") {
        sortParam = "price=asc";
        this.ChangeSelected(sortParam);
      } else if (i.price == "desc") {
        sortParam = "price=desc";
        this.ChangeSelected(sortParam);
      }
    });
  }
}
