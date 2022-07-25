import type { CreateUpdateOrderMasterDto, CustomerLookupDto, OrderDetailLookupDto, OrderMasterDto } from './models';
import { RestService } from '@abp/ng.core';
import type { ListResultDto, PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class OrderMasterService {
  apiName = 'Default';

  create = (input: CreateUpdateOrderMasterDto) =>
    this.restService.request<any, OrderMasterDto>({
      method: 'POST',
      url: '/api/app/order-master',
      body: input,
    },
    { apiName: this.apiName });

  customDelete = (id: string, input: OrderMasterDto) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: `/api/app/order-master/${id}/custom-delete`,
      body: input,
    },
    { apiName: this.apiName });

  customEdit = (id: string, input: OrderMasterDto) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: `/api/app/order-master/${id}/custom-edit`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/order-master/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, OrderMasterDto>({
      method: 'GET',
      url: `/api/app/order-master/${id}`,
    },
    { apiName: this.apiName });

  getCustomerLookup = () =>
    this.restService.request<any, ListResultDto<CustomerLookupDto>>({
      method: 'GET',
      url: '/api/app/order-master/customer-lookup',
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<OrderMasterDto>>({
      method: 'GET',
      url: '/api/app/order-master',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getOrderDetailLookup = () =>
    this.restService.request<any, ListResultDto<OrderDetailLookupDto>>({
      method: 'GET',
      url: '/api/app/order-master/order-detail-lookup',
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateOrderMasterDto) =>
    this.restService.request<any, OrderMasterDto>({
      method: 'PUT',
      url: `/api/app/order-master/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
