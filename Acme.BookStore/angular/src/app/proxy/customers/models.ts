import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateCustomerDto {
  musteriAd: string;
  riskLimit: number;
  faturaAdres: string;
}

export interface CustomerDto extends AuditedEntityDto<string> {
  musteriAd?: string;
  riskLimit: number;
  faturaAdres?: string;
}
