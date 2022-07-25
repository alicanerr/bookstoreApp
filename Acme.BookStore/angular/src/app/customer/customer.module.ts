import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CustomerRoutingModule } from './customer-routing.module';
import { CustomerComponent } from './customer.component';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap'; // add this line

@NgModule({
  declarations: [CustomerComponent],
  imports: [
    CustomerRoutingModule,
    SharedModule,
    NgbDatepickerModule, // add this line
  ]
})
export class CustomerModule { }