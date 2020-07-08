import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CategoryComponent } from './category/category.component';
import { ProductByCategoryComponent } from './product-by-category/product-by-category.component'

export const routes: Routes = [
  {
    path: '',
    // component: CategoryComponent,
    children: [
      {
        path:'',
        component: CategoryComponent
      },
      {
        path: 'productsbycategory',
        children: [
          {
            path:':id',
            component: ProductByCategoryComponent
          }
        ]
      }
    ]
  }
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoryRoutingModule { }