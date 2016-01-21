using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.IssuedInvoice;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class IssuedInvoiceClient : BaseClient
    {
        internal const string ResourceUrl = "/IssuedInvoices";

        public IssuedInvoiceClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/IssuedInvoices/Default
        /// Method returns empty invoice with default values. Returned resource is suitable for new invoice creation.
        /// </summary>
        public IssuedInvoiceInsert Default()
        {
            return base.Get<IssuedInvoiceInsert>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets invoice as paid.
        /// </summary>
        public bool FullyPay(int invoiceId, DateTime paid)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(DateFormat));
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/FullyUnpay
        /// Method sets invoice as unpaid.
        /// </summary>
        public bool FullyUnpay(int invoiceId)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetCashVoucherPdf
        /// Returns Pdf file with Cash voucher report for the invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public string CashVoucherPdf(int invoiceId)
        {
            return base.Get<string>(ResourceUrl + "/" + invoiceId + "/GetCashVoucherPdf");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetCashVoucherPdfCompressed
        /// Returns zipped Pdf file with Cash voucher report for the invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public string CashVoucherPdfCompressed(int invoiceId)
        {
            return base.Get<string>(ResourceUrl + "/" + invoiceId + "/GetCashVoucherPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/Expand
        /// Returns Issued invoice list with related entities such as contact information etc.
        /// </summary>
        public RowsResultWrapper<IssuedInvoiceExpand> IssuedInvoicesExpand(IssuedInvoiceFilter filter = null)
        {
            return base.Get<RowsResultWrapper<IssuedInvoiceExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/Expand
        /// Returns Issued invoice with related entities by Id.
        /// </summary>
        public IssuedInvoiceExpand IssuedInvoiceExpand(int invoiceId)
        {
            return base.Get<IssuedInvoiceExpand>(ResourceUrl + "/" + invoiceId + "/Expand");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetPdf
        /// Returns Pdf file with Issued Invoic. File is Base64 encoded and is returned as string.
        /// </summary>
        public string IssuedInvoicePdf(int invoiceId)
        {
            return base.Get<string>(ResourceUrl + "/" + invoiceId + "/GetPdf");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetPdfCompressed
        /// Returns zipped Pdf file with Issued Invoice report. File is Base64 encoded and is returned as string.
        /// </summary>
        public string IssuedInvoicePdfCompressed(int invoiceId)
        {
            return base.Get<string>(ResourceUrl + "/" + invoiceId + "/GetPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{contactId}/IssuedInvoices
        /// Returns invoice list for specific contact.
        /// </summary>
        public RowsResultWrapper<IssuedInvoice> IssuedInvoicesByContact(int contactId, IssuedInvoiceFilter filter = null)
        {
            return base.Get<RowsResultWrapper<IssuedInvoice>>(ResourceUrl + "/" + contactId + "/IssuedInvoices", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/MyDocumentAddress
        /// Contact information of the supplier for invoice.
        /// </summary>
        public DocumentAddress MyDocumentAddress(int invoiceId)
        {
            return base.Get<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/PurchaserDocumentAddress
        /// Contact information of the purchaser for invoice.
        /// </summary>
        public DocumentAddress PurchaserDocumentAddress(int invoiceId)
        {
            return base.Get<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/PurchaserDocumentAddress");
        }

        /// <summary>
        /// POST api/IssuedInvoices/Recount
        /// Method recounts summaries of the invoice model for creation. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Recount(IssuedInvoiceInsert invoice)
        {
            return base.Post<IssuedInvoice, IssuedInvoiceInsert>(ResourceUrl + "/Recount", invoice);
        }

        /// <summary>
        /// POST api/IssuedInvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Recount(int invoiceId, IssuedInvoiceUpdate invoice)
        {
            return base.Post<IssuedInvoice, IssuedInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/MyDocumentAddress
        /// Method Updates contact informations of the supplier.
        /// </summary>
        public DocumentAddress UpdateMyDocumentAddress(int invoiceId, DocumentAddress address)
        {
            return base.Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress", address);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/PurchaserDocumentAddress
        /// Method Updates contact informations of the purchaser.
        /// </summary>
        public DocumentAddress UpdatePurchaserDocumentAddress(int invoiceId, DocumentAddress address)
        {
            return base.Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/PurchaserDocumentAddress", address);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/SendMailToPurchaser
        /// Method sends email with issued invoice to the purchaser.
        /// </summary>
        public bool SendMailToPurchaser(int invoiceId)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/SendMailToPurchaser");
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/Exported/{value}
        /// Method updates Exported property of the invoice.
        /// </summary>
        public bool SendMailToPurchaser(int invoiceId, ExportedStateEnum state)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// DELETE api/IssuedInvoices/{id}
        /// Deletes issued invoice by Id.
        /// </summary>
        public bool Delete(int invoiceId)
        {
            return base.Delete(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// GET api/IssuedInvoices
        /// Returns list of issued invoices. Filters are optional.
        /// </summary>
        public RowsResultWrapper<IssuedInvoice> IssuedInvoices(IssuedInvoiceFilter filter = null)
        {
            return base.Get<RowsResultWrapper<IssuedInvoice>>(ResourceUrl + "/IssuedInvoices", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}
        /// Returns information about issued invoice including summaries.
        /// </summary>
        public IssuedInvoice IssuedInvoice(int invoiceId)
        {
            return base.Get<IssuedInvoice>(ResourceUrl + "/IssuedInvoices");
        }

        /// <summary>
        /// POST api/IssuedInvoices
        /// Create new issued invoice. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Create(IssuedInvoiceInsert invoice)
        {
            return base.Post<IssuedInvoice, IssuedInvoiceInsert>(ResourceUrl + "/IssuedInvoices", invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}
        /// Method updates issued invoice by Id. Also possible to update single preperties of invoice. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Update(int invoiceId, IssuedInvoiceUpdate invoice)
        {
            return base.Put<IssuedInvoice, IssuedInvoiceUpdate>(ResourceUrl + "/IssuedInvoices" + "/" + invoiceId, invoice);
        }
    }
}