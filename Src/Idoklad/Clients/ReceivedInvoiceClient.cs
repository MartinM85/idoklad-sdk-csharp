using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReceivedInvoice;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class ReceivedInvoiceClient : BaseClient
    {
        internal const string ResourceUrl = "/ReceivedInvoices";

        public ReceivedInvoiceClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Receivedinvoices/Default
        /// Method returns empty invoice with default values. Returned resource is suitable for new invoice creation.
        /// </summary>
        public ReceivedInvoice Default()
        {
            return base.Get<ReceivedInvoice>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets invoice as paid.
        /// </summary>
        public bool FullyPay(int invoiceId, DateTime paid)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(DateFormat));
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/FullyUnpay
        /// Method sets invoice as unpaid.
        /// </summary>
        public bool FullyUnpay(int invoiceId)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/GetAttachment
        /// Returns attachment for invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public string Attachment(int invoiceId)
        {
            return base.Get<string>(ResourceUrl + "/" + invoiceId + "/GetAttachment");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/GetAttachmentCompressed
        /// Returns compressed attachment for invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public string AttachmentCompressed(int invoiceId)
        {
            return base.Get<string>(ResourceUrl + "/" + invoiceId + "/GetAttachmentCompressed");
        }

        /// <summary>
        /// GET api/Receivedinvoices/Expand
        /// Returns Receivied invoice list with related entities such as contact information etc.
        /// </summary>
        public RowsResultWrapper<ReceivedInvoiceExpand> ReceivedInvoicesExpand(ReceivedInvoiceFilter filter = null)
        {
            return base.Get<RowsResultWrapper<ReceivedInvoiceExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/Expand
        /// Returns Received invoice with related entities by Id.
        /// </summary>
        public ReceivedInvoiceExpand ReceivedInvoiceExpand(int invoiceId)
        {
            return base.Get<ReceivedInvoiceExpand>(ResourceUrl + "/" + invoiceId + "/Expand");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/MyDocumentAddress
        /// Contact information of the purchaser for invoice.
        /// </summary>
        public DocumentAddress MyDocumentAddress(int invoiceId)
        {
            return base.Get<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{supplierId}/ReceivedInvoices
        /// Returns received invoice list for specific contact.
        /// </summary>
        public RowsResultWrapper<ReceivedInvoice> ReceivedInvoicesBySupplier(int supplierId, ReceivedInvoiceFilter filter = null)
        {
            return base.Get<RowsResultWrapper<ReceivedInvoice>>(ResourceUrl + "/" + supplierId + "/ReceivedInvoices");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/SupplierDocumentAddress
        /// Contact information of the supplier for invoice.
        /// </summary>
        public DocumentAddress SupplierDocumentAddress(int invoiceId)
        {
            return base.Get<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/SupplierDocumentAddress");
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/MyDocumentAddress
        /// Method Updates contact informations of the purchaser.
        /// </summary>
        public DocumentAddress UpdateMyDocumentAddress(int invoiceId, DocumentAddress documentAddress)
        {
            return base.Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress", documentAddress);
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/SupplierPurchaserDocumentAddress
        /// Method Updates contact informations of the supplier.
        /// </summary>
        public DocumentAddress UpdateSupplierPurchaserDocumentAddress(int invoiceId, DocumentAddress documentAddress)
        {
            return base.Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/SupplierPurchaserDocumentAddress", documentAddress);
        }

        /// <summary>
        /// POST api/Receivedinvoices/Recount
        /// Method recounts summaries of the invoice model for creation.
        /// </summary>
        public ReceivedInvoice Recount(ReceivedInvoiceCreate invoice)
        {
            return base.Post<ReceivedInvoice, ReceivedInvoiceCreate>(ResourceUrl + "/Recount", invoice);
        }

        /// <summary>
        /// POST api/Receivedinvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update.
        /// </summary>
        public ReceivedInvoice Recount(int invoiceId, ReceivedInvoiceUpdate invoice)
        {
            return base.Post<ReceivedInvoice, ReceivedInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", invoice);
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/Exported/{value}
        /// Method updates Exported proterty of the invoice.
        /// </summary>
        public bool UpdateExported(int invoiceId, ExportedStateEnum state)
        {
            return base.Put<bool>(ResourceUrl + "/" + invoiceId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// DELETE api/ReceivedInvoices/{id}
        /// Deletes received invoice by Id.
        /// </summary>
        public bool Delete(int invoiceId)
        {
            return base.Delete(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// GET api/ReceivedInvoices
        /// Returns list of received invoices. Filters are optional.
        /// </summary>
        public RowsResultWrapper<ReceivedInvoice> ReceivedInvoices(ReceivedInvoiceFilter filter = null)
        {
            return base.Get<RowsResultWrapper<ReceivedInvoice>>(ResourceUrl, filter);
        }

        /// <summary>
        /// api/ReceivedInvoices/{id}
        /// Returns information about received invoice including summaries.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public ReceivedInvoice ReceivedInvoice(int invoiceId)
        {
            return base.Get<ReceivedInvoice>(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// POST api/ReceivedInvoices
        /// Create new Received Invoice.
        /// </summary>
        public ReceivedInvoice Create(ReceivedInvoiceCreate invoice)
        {
            return base.Post<ReceivedInvoice, ReceivedInvoiceCreate>(ResourceUrl, invoice);
        }

        /// <summary>
        /// PUT api/ReceivedInvoices/{id}
        /// Method updates received invoice by Id. Also possible to update single properties of invoice.
        /// </summary>
        public ReceivedInvoice Update(int invoiceId, ReceivedInvoiceUpdate invoice)
        {
            return base.Post<ReceivedInvoice, ReceivedInvoiceUpdate>(ResourceUrl + "/" + invoiceId, invoice);
        }
    }
}