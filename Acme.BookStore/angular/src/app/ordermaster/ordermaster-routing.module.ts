import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrdermasterComponent } from './ordermaster.component';

const routes: Routes = [{ path: '', component: OrdermasterComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrdermasterRoutingModule { }
