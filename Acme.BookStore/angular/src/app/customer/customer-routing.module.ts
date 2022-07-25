import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard, PermissionGuard } from '@abp/ng.core';
import { CustomerComponent } from './customer.component';

const routes: Routes = [{ path: '', component: CustomerComponent, canActivate: [AuthGuard, PermissionGuard] },];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CustomerRoutingModule {}
