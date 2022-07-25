import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateOrderDetailDto {
  stokAdi: string;
  miktar: number;
  tutar: number;
}

export interface OrderDetailDto extends AuditedEntityDto<string> {
  stokAdi?: string;
  miktar: number;
  tutar: number;
}
