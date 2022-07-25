import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { OrdermasterRoutingModule } from './ordermaster-routing.module';
import { OrdermasterComponent } from './ordermaster.component';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap'; // add this line


@NgModule({
  declarations: [
    OrdermasterComponent
  ],
  imports: [
    SharedModule,
    OrdermasterRoutingModule,
    NgbDatepickerModule,
  ]
})
export class OrdermasterModule { }
