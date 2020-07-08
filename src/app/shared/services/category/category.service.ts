import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  uri=environment.apiEndPoint;
  constructor(private _http: HttpClient) { }
  headers = new HttpHeaders({
    'Content-Type':'application/x-www-form-urlencoded',
    // 'Content-Type':  'application/json'
  });
  getCategory() {
    console.log(2)
    // this.headers.append('Content-Type','application/x-www-form-urlencoded');
    // this.headers.append('Content-Type','application/json');
    return this._http.get<any>(this.uri + 'Category/get',{ headers: this.headers });
  }

  getProductsByCategories(id:any){
    return this._http.get<any>(this.uri + 'Product/get/'+ id, {headers: this.headers});
  }
}
