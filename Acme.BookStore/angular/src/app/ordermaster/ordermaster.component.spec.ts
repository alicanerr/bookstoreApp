import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdermasterComponent } from './ordermaster.component';

describe('OrdermasterComponent', () => {
  let component: OrdermasterComponent;
  let fixture: ComponentFixture<OrdermasterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrdermasterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OrdermasterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
