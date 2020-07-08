import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ProductByCategoryComponent } from './product-by-category.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CategoryService } from '../../shared/services/category/category.service';
import { RouterTestingModule } from '@angular/router/testing';


describe('ProductByCategoryComponent', () => {
  let component: ProductByCategoryComponent;
  let fixture: ComponentFixture<ProductByCategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule,
        RouterTestingModule
      ],
      declarations: [ ProductByCategoryComponent ],
      providers: [
        CategoryService
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductByCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
