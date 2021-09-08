interface UnPostedInvoice {
    name: string;
    num: number;
    invoicedDate: Date | string;
    totalPrice: number;
    invoiceObjID: number;
    totalCost: number;
    totalProfit: number;
    repFirstName: string;
    repLastName: string;
    repMiddleName: string;
    marlQty: number;
}

export default UnPostedInvoice;
