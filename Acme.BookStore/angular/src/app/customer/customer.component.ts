import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CustomerService, CustomerDto } from '@proxy/customers';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss'],
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class CustomerComponent implements OnInit {
  customer = { items: [], totalCount: 0 } as PagedResultDto<CustomerDto>;

  selectedCustomer = {} as CustomerDto; // declare selectedBook

  form: FormGroup;

  isModalOpen = false;

  constructor(
    public readonly list: ListService, 
    private customerService: CustomerService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService // inject the ConfirmationService
    ) {}

  ngOnInit() {
    const customerStreamCreator = (query) => this.customerService.getList(query);

    this.list.hookToQuery(customerStreamCreator).subscribe((response) => {
      this.customer = response;
    });
  }
  createCustomer() {
    this.selectedCustomer = {} as CustomerDto; // reset the selected book
    this.buildForm();
    this.isModalOpen = true;
  }
  editCustomer(id: string) {
    this.customerService.get(id).subscribe((customer) => {
      this.selectedCustomer = customer;
      this.buildForm();
      this.isModalOpen = true;
    });
  }
  buildForm() {
    this.form = this.fb.group({
      musteriAd: [this.selectedCustomer.musteriAd || '', Validators.required],
      riskLimit: [this.selectedCustomer.riskLimit || null, Validators.required],
      
      faturaAdres: [this.selectedCustomer.faturaAdres || null, Validators.required],
    });
  }
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedCustomer.id
      ? this.customerService.update(this.selectedCustomer.id, this.form.value)
      : this.customerService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.customerService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
}