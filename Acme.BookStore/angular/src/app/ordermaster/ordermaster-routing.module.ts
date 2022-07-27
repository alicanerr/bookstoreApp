import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrdermasterComponent } from './ordermaster.component';
import { AuthGuard, PermissionGuard } from '@abp/ng.core';

const routes: Routes = [{ path: '', component: OrdermasterComponent, canActivate: [AuthGuard, PermissionGuard] },];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrdermasterRoutingModule { }
