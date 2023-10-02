

namespace MyNamespace
{
    using static WebApplication1.Models.BillPaymentModel;
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("Generate", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IBillPayment
    {
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LOGINResponse_element_core> LoginAsync(LOGIN_element_core request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LOGINResponse_element_core> LoginAsync(LOGIN_element_core request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTResponse_element_tns> BillpaymentGetSectorListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTResponse_element_tns> BillpaymentGetSectorListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTResponse_element_tns> BillpaymentGetCorporateListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTResponse_element_tns> BillpaymentGetCorporateListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSResponse_element_tns> BillpaymentGetPaymentInputsAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSResponse_element_tns> BillpaymentGetPaymentInputsAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTResponse_element_tns> BillpaymentGetBillListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTResponse_element_tns> BillpaymentGetBillListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_PAYResponse_element_tns> BillpaymentPayAsync(WEBEXT_ADCBI_BILLPAYMENT_PAYInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_PAYResponse_element_tns> BillpaymentPayAsync(WEBEXT_ADCBI_BILLPAYMENT_PAYInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERResponse_element_tns> BillpaymentCreateStandingOrderAsync(WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERResponse_element_tns> BillpaymentCreateStandingOrderAsync(WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERResponse_element_tns> BillpaymentUpdateStandingOrderAsync(WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERResponse_element_tns> BillpaymentUpdateStandingOrderAsync(WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTResponse_element_tns> BillpaymentGetStandingOrderListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTResponse_element_tns> BillpaymentGetStandingOrderListAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTInput request, System.Threading.CancellationToken cancellationToken);

        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse_element_tns> BillpaymentGetHistoryAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYInput request);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>200 OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse_element_tns> BillpaymentGetHistoryAsync(WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYInput request, System.Threading.CancellationToken cancellationToken);

    }


   



    [System.CodeDom.Compiler.GeneratedCode("Generate", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("Generate", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

