import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { OrderDetailService, OrderDetailDto } from '@proxy/order-details';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-orderdetail',
  templateUrl: './orderdetail.component.html',
  styleUrls: ['./orderdetail.component.scss'],
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class OrderdetailComponent implements OnInit {
  orderDetail = { items: [], totalCount: 0 } as PagedResultDto<OrderDetailDto>;

  selectedorderDetail = {} as OrderDetailDto; // declare selectedBook

  form: FormGroup;

  isModalOpen = false;

  constructor(
    public readonly list: ListService, 
    private orderdetailService: OrderDetailService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService // inject the ConfirmationService
    ) {}
    ngOnInit() {
      const orderDetailStreamCreator = (query) => this.orderdetailService.getList(query);
  
      this.list.hookToQuery(orderDetailStreamCreator).subscribe((response) => {
        this.orderDetail = response;
      });
    }
    createorderDetail() {
      this.selectedorderDetail = {} as OrderDetailDto; // reset the selected book
      this.buildForm();
      this.isModalOpen = true;
    }
    editorderDetail(id: string) {
      this.orderdetailService.get(id).subscribe((orderDetail) => {
        this.selectedorderDetail = orderDetail;
        this.buildForm();
        this.isModalOpen = true;
      });
    }
    buildForm() {
      this.form = this.fb.group({
        stokAdi: [this.selectedorderDetail.stokAdi || '', Validators.required],
        miktar: [this.selectedorderDetail.miktar || null, Validators.required],
        
        tutar: [this.selectedorderDetail.tutar || null, Validators.required],
      });
    }
    save() {
      if (this.form.invalid) {
        return;
      }
  
      const request = this.selectedorderDetail.id
        ? this.orderdetailService.update(this.selectedorderDetail.id, this.form.value)
        : this.orderdetailService.create(this.form.value);
  
      request.subscribe(() => {
        this.isModalOpen = false;
        this.form.reset();
        this.list.get();
      });
    }
    delete(id: string) {
      this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
        if (status === Confirmation.Status.confirm) {
          this.orderdetailService.delete(id).subscribe(() => this.list.get());
        }
      });
    }
  }