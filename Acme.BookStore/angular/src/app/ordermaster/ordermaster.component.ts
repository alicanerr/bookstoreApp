import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { OrderMasterService, OrderMasterDto, CustomerLookupDto, OrderDetailLookupDto } from '@proxy/order-masters';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';



@Component({
  selector: 'app-ordermaster',
  templateUrl: './ordermaster.component.html',
  styleUrls: ['./ordermaster.component.scss'],
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class OrdermasterComponent implements OnInit {
  orderMaster = { items: [], totalCount: 0 } as PagedResultDto<OrderMasterDto>;
  selectedorderMaster = {} as OrderMasterDto; // declare selectedBook
  customer$: Observable<CustomerLookupDto[]>;
  orderDetail$: Observable<OrderDetailLookupDto[]>;


  form: FormGroup;

  isModalOpen = false;

  constructor(
    public readonly list: ListService,
    private ordermasterService: OrderMasterService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService) {
    this.customer$ = ordermasterService.getCustomerLookup().pipe(map((r) => r.items));
    this.orderDetail$ = ordermasterService.getOrderDetailLookup().pipe(map((r) => r.items));
  }

  ngOnInit() {
    const orderMasterStreamCreator = (query) => this.ordermasterService.getList(query);

    this.list.hookToQuery(orderMasterStreamCreator).subscribe((response) => {
      this.orderMaster = response;
    });
  }
  createorderMaster() {
    this.selectedorderMaster = {} as OrderMasterDto; // reset the selected book
    this.buildForm();
    this.isModalOpen = true;
  }
  editorderMaster(id: string) {
    this.ordermasterService.get(id).subscribe((orderMaster) => {
      this.selectedorderMaster = orderMaster;

      if(this.selectedorderMaster.onayBilgisi==true)
      {
        this.ordermasterService.customEdit(this.selectedorderMaster.id, this.selectedorderMaster).subscribe(() => this.list.get());
      }
      else
      {
        this.buildForm();
        this.isModalOpen = true;
      }
    });
  }
  buildForm() {
    this.form = this.fb.group({
      customerId: [this.selectedorderMaster.customerId || null, Validators.required],
      orderDetailId: [this.selectedorderMaster.orderDetailId || null, Validators.required],
      siparisTarihi: [this.selectedorderMaster.siparisTarihi || null, Validators.required],
      sevkAdres: [this.selectedorderMaster.sevkAdres || null, Validators.required],
      onayBilgisi: [this.selectedorderMaster.onayBilgisi || null, Validators.required],
    });
  }
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedorderMaster.id
      ? this.ordermasterService.update(this.selectedorderMaster.id, this.form.value)
      : this.ordermasterService.create(this.form.value);



    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
  delete(id: string) {
    this.ordermasterService.get(id).subscribe((orderMaster) => {
      this.selectedorderMaster = orderMaster;
    });
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.ordermasterService.customDelete(id, this.selectedorderMaster).subscribe(() => this.list.get());
      }
    });
  }
}
