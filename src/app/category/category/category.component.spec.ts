import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoryComponent } from './category.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CategoryService } from '../../shared/services/category/category.service';
import { RouterTestingModule } from '@angular/router/testing';
import { RouterModule } from '@angular/router';
import { Location } from '@angular/common';
import { Component } from '@angular/core';
import { LOADIPHLPAPI } from 'dns';
import { By } from '@angular/platform-browser';

describe('CategoryComponent', () => {
  let component: CategoryComponent;
  let fixture: ComponentFixture<CategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule,
        RouterTestingModule.withRoutes(
          [
            {path:'category', component:DummyComponent}
          ]
        )
      ],
      declarations: [ 
        CategoryComponent,
        DummyComponent
       ],
      providers: [
        CategoryService
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should navigate to / before click view products', () => {
      const location = TestBed.get(Location);
      expect(location.path()).toBe('')
  });

  it('should contain h2 tag', () => {
    // const location = TestBed.get(Location);
    const h2Elem = fixture.debugElement.query(By.css('h2'));
    const h2HTMLElement: HTMLHeadElement = h2Elem.nativeElement;
    expect(h2HTMLElement.textContent).toBe('Categories')
    // const nativeButton: HTMLButtonElement = linkDes[0].nativeElement;
    // nativeButton.click();
    // fixture.detectChanges();
    // fixture.whenStable().then( () => {
    //   expect(location.path()).toBe('/category');
    // })
  });

});


@Component({template:''})
class DummyComponent{}