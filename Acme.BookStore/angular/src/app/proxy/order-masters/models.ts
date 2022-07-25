import type { AuditedEntityDto, EntityDto } from '@abp/ng.core';

export interface CreateUpdateOrderMasterDto {
  orderDetailId: string;
  customerId: string;
  siparisTarihi: string;
  sevkAdres: string;
  onayBilgisi: boolean;
}

export interface CustomerLookupDto extends EntityDto<string> {
  musteriAd?: string;
}

export interface OrderDetailLookupDto extends EntityDto<string> {
  stokAdi?: string;
}

export interface OrderMasterDto extends AuditedEntityDto<string> {
  orderDetailId?: string;
  stockName?: string;
  customerId?: string;
  customerName?: string;
  siparisTarihi?: string;
  sevkAdres?: string;
  onayBilgisi: boolean;
}
