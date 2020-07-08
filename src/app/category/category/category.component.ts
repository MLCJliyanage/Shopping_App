import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../../shared/services/category/category.service';
import { EncryptDecryptService } from '../../shared/services/encrypt-decrypt/encrypt-decrypt.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {

  categoryDetails = []
  productsbycategory = []
  categ = true
  constructor(private getcategory: CategoryService, private encryNdecry: EncryptDecryptService) { 
    
  }
  ngOnInit(): void {
    console.log('1')
    this.getAllCategories();
  }

  getAllCategories(){
    this.getcategory.getCategory().subscribe(
      data => {
        console.log("ppppppppppppppppppppppppppp");
        console.log(data);
        let dec_data = this.encryNdecry.decrypt(data);
        this.categoryDetails = JSON.parse(dec_data);
        console.log(this.categoryDetails);
      }, error => {
        console.log(error);
      }
    );
  }

  getProductsByCategories(id:any){
    this.categ = false;
    this.getcategory.getProductsByCategories(id).subscribe(
      data => {
        console.log(data)
        this.productsbycategory = data
        console.log(this.productsbycategory);
      }, error => {
        console.log(error);
      }
    );
  }

}
