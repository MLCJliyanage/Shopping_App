import { Component } from '@angular/core';
import {CategoryService} from './shared/services/category/category.service'
import {EncryptDecryptService} from './shared/services/encrypt-decrypt/encrypt-decrypt.service'
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ShoppingAppFrontEnd';
  categoryDetails = []
  mySubscription;
  // constructor(private getcategory: CategoryService, private encryNdecry: EncryptDecryptService) { }
  
  constructor(private router: Router,private getcategory: CategoryService, private encryNdecry: EncryptDecryptService){
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
    this.mySubscription = this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
         // Trick the Router into believing it's last link wasn't previously loaded
         this.router.navigated = false;
      }
    }); 
 }


  ngOnInit(): void {
    this.getAllCategories();
  }

  getAllCategories(){
    this.getcategory.getCategory().subscribe(
      data => {
        let dec_data = this.encryNdecry.decrypt(data);
        this.categoryDetails = JSON.parse(dec_data);
      }, error => {
        console.log(error);
      }
    );
  }
}
