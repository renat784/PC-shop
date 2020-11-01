import { Component } from "@angular/core";
import { GetDataService } from "../get-data.service";

@Component({
  selector: "app-fetch-data",
  templateUrl: "./fetch-data.component.html",
})
export class FetchDataComponent {
  public proceccors;

  constructor(service: GetDataService) {}
}
