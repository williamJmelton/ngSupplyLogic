interface InvoiceLine {
  orderQty: number;
  lineTotal: number;
  itemName: string;
  itemCatOID: number;
  unitNetCost: number;
  unitPrice: number;
  itemProfit: number;
  unit: number;
  isGeneralGoods: boolean;
  unitName: string;
}

export default InvoiceLine
