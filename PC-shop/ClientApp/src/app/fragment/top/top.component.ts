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
  @Input() count;
  @Output() viewChanged = new EventEmitter<string>();
  view;
  componentName;
  showReset;
  sortOptions = [];

  constructor(
    private router: Router,
    private service: GetDataService,
    private route: ActivatedRoute
  ) {
    this.sortOptions = [
      {
        name: "От дешевых к дорогим",
        value: "price_asc",
        selected: false,
      },
      {
        name: "От дорогих к дешевым",
        value: "price_desc",
        selected: false,
      },
      {
        name: "По порядку",
        value: "asc",
        selected: true,
      },
    ];
  }

  SortProducts(e) {
    let value = e.target.value;
    let query;
    this.route.queryParams.subscribe((i) => {
      query = { ...i };

      console.log(query);
      if (query.sort) {
        switch (value) {
          case "price_asc":
            query.sort = "price_asc";
            this.router.navigate(["/" + this.componentName], {
              queryParams: query,
            });
            break;
          case "price_desc":
            query.sort = "price_desc";
            this.router.navigate(["/" + this.componentName], {
              queryParams: query,
            });
            break;
          case "asc":
            query.sort = "asc";
            this.router.navigate(["/" + this.componentName], {
              queryParams: query,
            });
            break;
        }
      } else {
        switch (value) {
          case "price_asc":
            this.router.navigate(["/" + this.componentName], {
              queryParams: { ...query, sort: "price_asc" },
            });
            break;
          case "price_desc":
            this.router.navigate(["/" + this.componentName], {
              queryParams: { ...query, sort: "price_desc" },
            });
            break;
          case "asc":
            this.router.navigate(["/" + this.componentName], {
              queryParams: { ...query, sort: "asc" },
            });
            break;
        }
      }
    });
  }

  ToggleView(e) {
    switch (e.target.id) {
      case "small":
        this.view = "col-lg-3";
        this.viewChanged.emit(this.view);
        this.service.setViewPref({ view: this.view });
        break;
      case "large":
        this.view = "col-lg-4";
        this.viewChanged.emit(this.view);
        this.service.setViewPref({ view: this.view });
        break;
    }
  }

  ChangeSelected(sortParam) {
    let index = this.sortOptions.findIndex((i) => i.value == sortParam);
    this.sortOptions.map((i) => (i.selected = false));
    this.sortOptions[index].selected = true;
  }

  ngOnInit() {
    // show or hide reset filter button
    this.route.queryParams.subscribe((i) => {
      if (
        Object.keys(i).length == 0 ||
        (Object.keys(i).length == 1 && i.sort)
      ) {
        this.showReset = false;
      } else {
        this.showReset = true;
      }
    });

    // add active class to view toggle
    this.view = this.service.getViewPref().view;

    //  get component short name
    let fullName = this.route.routeConfig.component.name.toLowerCase();
    let endIndex = fullName.indexOf("component");
    this.componentName = fullName.slice(0, endIndex);

    // set sort select option from url
    this.route.queryParams.subscribe((i) => {
      let sortParam;

      switch (i.sort) {
        case "asc":
          sortParam = "asc";
          this.ChangeSelected(sortParam);
          break;
        case "price_asc":
          sortParam = "price_asc";
          this.ChangeSelected(sortParam);
          break;
        case "price_desc":
          sortParam = "price_desc";
          this.ChangeSelected(sortParam);
          break;
      }
    });
  }
}
