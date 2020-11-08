import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { HomeComponent } from "./home/home.component";
import { ProcessorsComponent } from "./processors/processors.component";
import { CheckoutComponent } from "./checkout/checkout.component";
import { SsdComponent } from "./ssd/ssd.component";
import { TopComponent } from "./fragment/top/top.component";
import { LeftComponent } from "./fragment/left/left.component";
import { RightComponent } from "./fragment/right/right.component";
import { DetailsComponent } from "./details/details.component";
import { CpuComponent } from "./cpu/cpu.component";
import { HddComponent } from "./hdd/hdd.component";
import { KeyboardComponent } from "./keyboard/keyboard.component";
import { MonitorComponent } from "./monitor/monitor.component";
import { MotherboardComponent } from "./motherboard/motherboard.component";
import { MouseComponent } from "./mouse/mouse.component";
import { RamComponent } from "./ram/ram.component";
import { VideocardComponent } from "./videocard/videocard.component";
import { FooterComponent } from "./footer/footer.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ProcessorsComponent,
    CheckoutComponent,
    SsdComponent,
    TopComponent,
    LeftComponent,
    RightComponent,
    DetailsComponent,
    CpuComponent,
    HddComponent,
    KeyboardComponent,
    MonitorComponent,
    MotherboardComponent,
    MouseComponent,
    RamComponent,
    VideocardComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(
      [
        { path: "", component: HomeComponent, pathMatch: "full" },
        { path: "home", redirectTo: "" },
        { path: "cpu", component: CpuComponent },
        { path: "details/:categoryId/:productId", component: DetailsComponent },
        { path: "ssd", component: SsdComponent },
        { path: "hdd", component: HddComponent },
        { path: "keyboard", component: KeyboardComponent },
        { path: "monitor", component: MonitorComponent },
        { path: "motherboard", component: MotherboardComponent },
        { path: "mouse", component: MouseComponent },
        { path: "ram", component: RamComponent },
        { path: "videocard", component: VideocardComponent },
        { path: "checkout", component: CheckoutComponent },
      ],
      { anchorScrolling: "enabled" }
    ),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
