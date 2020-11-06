import { HttpClient } from "@angular/common/http";
import { EventEmitter, Inject, Injectable } from "@angular/core";

// use instead of categoryId
export enum Category {
  Cpu = 1,
  Hdd = 2,
  Keyboard = 3,
  Monitor = 4,
  Motherboard = 5,
  Mouse = 6,
  Ram = 7,
  Ssd = 8,
  Videocard = 9,
}

export enum CategoryName {
  Cpu = "cpu",
  Hdd = "hdd",
  Keyboard = "keyboard",
  Monitor = "monitor",
  Motherboard = "motherboard",
  Mouse = "mouse",
  Ram = "ram",
  Ssd = "ssd",
  Videocard = "videocard",
}

export enum ImagePath {
  Cpu = "images/parts/cpu/",
  Hdd = "images/parts/hdd/",
  Keyboard = "images/parts/keyboard/",
  Monitor = "images/parts/monitor/",
  Motherboard = "images/parts/motherboard/",
  Mouse = "images/parts/mouse/",
  Ram = "images/parts/ram/",
  Ssd = "images/parts/ssd/",
  Videocard = "images/parts/videocard/",
}
export const productsEvent = new EventEmitter();

@Injectable({
  providedIn: "root",
})
export class GetDataService {
  Category = Category;

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  // methods to get data from backend:
  GetProductList(categoryId) {
    return this.http.get(this.baseUrl + `Products/GetList/${categoryId}`);
  }

  GetProduct(categoryId, itemId) {
    return this.http.get(
      this.baseUrl + `Products/GetProduct/${categoryId}/${itemId}`
    );
  }

  // methods to get images to display:
  GetImage(product): string {
    let image = product.images.split(";")[0].trim();
    image = this.CheckCategory(product.categoryId) + image;
    return image;
  }

  GetImages(product): string[] {
    let images = product.images.split(";");
    for (let index = 0; index < images.length; index++) {
      const element = images[index];
      images[index] = this.CheckCategory(product.categoryId) + element.trim();
    }
    return images;
  }

  // get categoryId from component name
  GetCategoryId(componentName) {
    let categoryId;

    switch (componentName) {
      case CategoryName.Cpu:
        categoryId = Category.Cpu;
        break;
      case CategoryName.Hdd:
        categoryId = Category.Hdd;
        break;
      case CategoryName.Keyboard:
        categoryId = Category.Keyboard;
        break;
      case CategoryName.Monitor:
        categoryId = Category.Monitor;
        break;
      case CategoryName.Motherboard:
        categoryId = Category.Motherboard;
        break;
      case CategoryName.Mouse:
        categoryId = Category.Mouse;
        break;
      case CategoryName.Ram:
        categoryId = Category.Ram;
        break;
      case CategoryName.Ssd:
        categoryId = Category.Ssd;
        break;
      case CategoryName.Videocard:
        categoryId = Category.Videocard;
        break;
    }
    return categoryId;
  }

  // returns image path from categoryId
  CheckCategory(categoryId): string {
    switch (categoryId) {
      case Category.Cpu:
        return ImagePath.Cpu;
      case Category.Hdd:
        return ImagePath.Hdd;
      case Category.Keyboard:
        return ImagePath.Keyboard;
      case Category.Monitor:
        return ImagePath.Monitor;
      case Category.Motherboard:
        return ImagePath.Motherboard;
      case Category.Mouse:
        return ImagePath.Mouse;
      case Category.Ram:
        return ImagePath.Ram;
      case Category.Ssd:
        return ImagePath.Ssd;
      case Category.Videocard:
        return ImagePath.Videocard;
    }
  }

  // methods to add/remove products to/from local storage:
  AddItemToCart(item) {
    let cart;
    cart = JSON.parse(localStorage.getItem("products"));
    // cart exists
    if (cart) {
      if (
        cart.find(
          (i) =>
            i.product.id == item.id && i.product.categoryId == item.categoryId
        )
      )
        console.log("item already added to cart");
      else {
        cart.push({ product: item, count: 1 });
        localStorage.setItem("products", JSON.stringify(cart));
      }
      //  cart doesn't exist
    } else {
      cart = [];
      cart.push({ product: item, count: 1 });
      localStorage.setItem("products", JSON.stringify(cart));
    }
  }

  ChangeProductCount(product) {
    let products = JSON.parse(localStorage.getItem("products"));
    let indexOfProduct = products.findIndex(
      (i) =>
        i.product.id == product.product.id &&
        i.product.categoryId == product.product.categoryId
    );

    products[indexOfProduct].count = product.count;

    localStorage.setItem("products", JSON.stringify(products));
  }

  GetItemsCount() {
    let products = JSON.parse(localStorage.getItem("products"));
    if (products) return products.length;
    else return 0;
  }

  GetItemsFromCart() {
    let products = JSON.parse(localStorage.getItem("products"));
    return products;
  }

  PriceTotal() {
    let items = JSON.parse(localStorage.getItem("products"));
    let count = 0;
    if (items.length === 0) return count;
    else {
      items.map((i) => (count += i.product.price * i.count));
    }
    return count;
  }

  RemoveItemFromCart(product) {
    let cart = JSON.parse(localStorage.getItem("products"));
    let indexOfElementToDelete = cart.findIndex(
      (i) =>
        i.product.id == product.id && i.product.categoryId == product.categoryId
    );
    cart.splice(indexOfElementToDelete, 1);

    localStorage.setItem("products", JSON.stringify(cart));
  }

  RemoveItemsFromCart() {
    let cart = [];
    localStorage.setItem("products", JSON.stringify(cart));
    console.log("cart is cleared");
  }

  // set view of products
  setViewPref(pref) {
    localStorage.setItem("pref", JSON.stringify(pref));
  }

  //    { view: 'col-3' }
  getViewPref() {
    let pref = localStorage.getItem("pref");
    if (pref) return JSON.parse(pref);
    else return { view: "col-3" };
  }

  // returns name of category by category id
  getNameById(categoryId) {
    let id = parseInt(categoryId);
    switch (id) {
      case 1:
        return "Процессор";
        break;
      case 2:
        return "Жесткий диск";
        break;
      case 3:
        return "Клавиатура";
        break;
      case 4:
        return "Монитор";
        break;
      case 5:
        return "Материнская плата";
        break;
      case 6:
        return "Мышка";
        break;
      case 7:
        return "Оперативная память";
        break;
      case 8:
        return "SSD диск";
        break;
      case 9:
        return "Видеокарта";
        break;
    }
  }
}
