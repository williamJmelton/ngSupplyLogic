interface ArTransaction {
  objID: number;
  customerOID: number;
  transNum: number;
  type: number;
  entryDate: number;
  transDate: number;
  Status: number;
  transactionAmount: number;
  salesOrderOID: number;
  paymentType: number;
  customerName: string;
  customerNumber: number;
}

export default ArTransaction
