import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { OrderdetailRoutingModule } from './orderdetail-routing.module';
import { OrderdetailComponent } from './orderdetail.component';


@NgModule({
  declarations: [OrderdetailComponent],
  imports: [
    OrderdetailRoutingModule,
    SharedModule,
  ]
})
export class OrderdetailModule { }
