import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,Router  } from '@angular/router';
import { CategoryService } from '../../shared/services/category/category.service';
import { EncryptDecryptService } from '../../shared/services/encrypt-decrypt/encrypt-decrypt.service';

@Component({
  selector: 'app-product-by-category',
  templateUrl: './product-by-category.component.html',
  styleUrls: ['./product-by-category.component.scss']
})
export class ProductByCategoryComponent implements OnInit {

  catid: number
  productsbycategory = []
  constructor(private route: ActivatedRoute, private getcategory: CategoryService,private encryNdecry: EncryptDecryptService) { }

  ngOnInit(): void {
    this.catid = Number(this.route.snapshot.paramMap.get("id"))
    console.log(this.catid)
    this.getProductsByCategories(this.catid);
  }

  getProductsByCategories(id:any){
    this.getcategory.getProductsByCategories(id).subscribe(
      data => {
        console.log(data)
        let dec_data = this.encryNdecry.decrypt(data);
        this.productsbycategory = JSON.parse(dec_data);
        // this.productsbycategory = data
        console.log(this.productsbycategory);
      }, error => {
        console.log(error);
      }
    );
  }

}
