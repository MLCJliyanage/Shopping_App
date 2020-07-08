import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryComponent } from './category/category.component';
import { Routes, RouterModule } from '@angular/router';
import { CategoryRoutingModule } from './category-routing.module';
import { ProductByCategoryComponent } from './product-by-category/product-by-category.component';
import { routes } from './category-routing.module'

@NgModule({
  declarations: [CategoryComponent, ProductByCategoryComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    CategoryRoutingModule
  ]
})
export class CategoryModule { }
