import type { CreateUpdateOrderDetailDto, OrderDetailDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class OrderDetailService {
  apiName = 'Default';

  create = (input: CreateUpdateOrderDetailDto) =>
    this.restService.request<any, OrderDetailDto>({
      method: 'POST',
      url: '/api/app/order-detail',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/order-detail/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, OrderDetailDto>({
      method: 'GET',
      url: `/api/app/order-detail/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<OrderDetailDto>>({
      method: 'GET',
      url: '/api/app/order-detail',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateOrderDetailDto) =>
    this.restService.request<any, OrderDetailDto>({
      method: 'PUT',
      url: `/api/app/order-detail/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
