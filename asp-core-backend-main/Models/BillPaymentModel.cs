using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class BillPaymentModel
    {
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class CommonFault
        {
            [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Error { get; set; }

            [Newtonsoft.Json.JsonProperty("Fault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Fault Fault { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LIST", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LIST_element_tns WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LIST { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header2 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LIST", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LIST_element_tns WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LIST { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header3 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTS_element_tns WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTS { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header4 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST_element_tns WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_PAYInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header5 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_PAY", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_PAY_element_tns WEBEXT_ADCBI_BILLPAYMENT_PAY { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header6 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER_element_tns WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header7 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDER_element_tns WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header8 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LIST", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LIST_element_tns WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LIST { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYInput
        {
            [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Header9 Header { get; set; }

            [Newtonsoft.Json.JsonProperty("WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORY", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORY_element_tns WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORY { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class LOGIN_element_core
        {
           // [Newtonsoft.Json.JsonProperty("USERNAME", Required = Newtonsoft.Json.Required.Always)]
            //[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
            public string USERNAME { get; set; }

            //[Newtonsoft.Json.JsonProperty("PASSWORD", Required = Newtonsoft.Json.Required.Always)]
            //[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
            public string PASSWORD { get; set; }

            [Newtonsoft.Json.JsonProperty("LANGUAGE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string LANGUAGE { get; set; }

            //[Newtonsoft.Json.JsonProperty("CHANNEL", Required = Newtonsoft.Json.Required.Always)]
            //[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
            public string CHANNEL { get; set; }

            //[Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            //[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            //[Newtonsoft.Json.JsonProperty("SUB_CHANNEL_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            //[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
            public string SUB_CHANNEL_RESERVED { get; set; }

            //[Newtonsoft.Json.JsonProperty("CLIENT_APP_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            //[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
            public string CLIENT_APP_ID_RESERVED { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class LOGINResponse_element_core
        {
            [Newtonsoft.Json.JsonProperty("SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SESSION_ID { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LIST_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTResponse__TABLE_type_tns> TABLE { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LIST_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("SECTOR_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SECTOR_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("STANDING_ORDER", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string STANDING_ORDER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTResponse__TABLE_type_tns> TABLE { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTS_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_OID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_OID { get; set; }

            [Newtonsoft.Json.JsonProperty("STANDING_ORDER", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string STANDING_ORDER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSResponse__TABLE_type_tns> TABLE { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_OID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_OID { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ICollection<Dictionary<string, string>> SUBSCRIBER_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_NO { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTResponse__TABLE_type_tns> TABLE { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_PAY_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("ACCOUNT_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ACCOUNT_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("CARD_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CARD_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("CREATE_STDORD", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CREATE_STDORD { get; set; }

            [Newtonsoft.Json.JsonProperty("OBJECT", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string OBJECT { get; set; }

            [Newtonsoft.Json.JsonProperty("AMOUNT", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string AMOUNT { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_OID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_OID { get; set; }

            [Newtonsoft.Json.JsonProperty("SECTOR_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SECTOR_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_SMS", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_SMS { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_EMAIL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_EMAIL { get; set; }

            [Newtonsoft.Json.JsonProperty("PAYMENT_SOURCE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string PAYMENT_SOURCE { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ICollection<Dictionary<string, string>> SUBSCRIBER_NO { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_PAYResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TRX_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string TRX_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("ACCOUNT_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ACCOUNT_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("CARD_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CARD_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_OID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_OID { get; set; }

            [Newtonsoft.Json.JsonProperty("SECTOR_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SECTOR_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_SMS", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_SMS { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_EMAIL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_EMAIL { get; set; }

            [Newtonsoft.Json.JsonProperty("PAYMENT_SOURCE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string PAYMENT_SOURCE { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ICollection<Dictionary<string, string>> SUBSCRIBER_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_CELLPHONE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_CELLPHONE { get; set; }

            [Newtonsoft.Json.JsonProperty("EMAIL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string EMAIL { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDER_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("ACCOUNT_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ACCOUNT_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ID { get; set; }

            [Newtonsoft.Json.JsonProperty("ORDER_STATUS_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ORDER_STATUS_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_SMS", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_SMS { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_EMAIL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_EMAIL { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LIST_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_NO { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTResponse__TABLE_type_tns> TABLE { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORY_element_tns
        {
            [Newtonsoft.Json.JsonProperty("CLIENT_SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("CUSTOMER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CUSTOMER_NO { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse_element_tns
        {
            [Newtonsoft.Json.JsonProperty("TABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse__TABLE_type_tns> TABLE { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_LIST", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse__INSTITUTION_LIST_type_tns> INSTITUTION_LIST { get; set; }

            [Newtonsoft.Json.JsonProperty("CORE_TRX_ID_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CORE_TRX_ID_RESERVED { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("RETURN_DESC", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string RETURN_DESC { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class HEADER_element_tns
        {
            [Newtonsoft.Json.JsonProperty("SESSION_ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SESSION_ID { get; set; }

            [Newtonsoft.Json.JsonProperty("CLIENT_INFO_RESERVED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CLIENT_INFO_RESERVED { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTResponse__TABLE_type_tns
        {
            [Newtonsoft.Json.JsonProperty("CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("VALUE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string VALUE { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTResponse__TABLE_type_tns
        {
            [Newtonsoft.Json.JsonProperty("CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("VALUE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string VALUE { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSResponse__TABLE_type_tns
        {
            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO_LABEL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NO_LABEL { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO_EXAMPLE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NO_EXAMPLE { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO_LENGTH", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NO_LENGTH { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO_INPUT_KEY", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NO_INPUT_KEY { get; set; }

            [Newtonsoft.Json.JsonProperty("PATTERN", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string PATTERN { get; set; }

            [Newtonsoft.Json.JsonProperty("MASK", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string MASK { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST__SUBSCRIBER_NO_type_tns
        {
            [Newtonsoft.Json.JsonProperty("KEY", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string KEY { get; set; }

            [Newtonsoft.Json.JsonProperty("VALUE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string VALUE { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTResponse__TABLE_type_tns
        {
            [Newtonsoft.Json.JsonProperty("OBJECT", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string OBJECT { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_NAME", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_NAME { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NAME", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NAME { get; set; }

            [Newtonsoft.Json.JsonProperty("BILL_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string BILL_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("BILL_TERM", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string BILL_TERM { get; set; }

            [Newtonsoft.Json.JsonProperty("BILL_AMOUNT", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string BILL_AMOUNT { get; set; }

            [Newtonsoft.Json.JsonProperty("LAST_PAYMENT_DATE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string LAST_PAYMENT_DATE { get; set; }

            [Newtonsoft.Json.JsonProperty("PARTIAL_PAYMENT_ALLOWED", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string PARTIAL_PAYMENT_ALLOWED { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO1", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NO1 { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_PAY__SUBSCRIBER_NO_type_tns
        {
            [Newtonsoft.Json.JsonProperty("KEY", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string KEY { get; set; }

            [Newtonsoft.Json.JsonProperty("VALUE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string VALUE { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER__SUBSCRIBER_NO_type_tns
        {
            [Newtonsoft.Json.JsonProperty("KEY", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string KEY { get; set; }

            [Newtonsoft.Json.JsonProperty("VALUE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string VALUE { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTResponse__TABLE_type_tns
        {
            [Newtonsoft.Json.JsonProperty("INSTITUTION_NAME", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_NAME { get; set; }

            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("ACCOUNT_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ACCOUNT_NO { get; set; }

            [Newtonsoft.Json.JsonProperty("IBAN", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string IBAN { get; set; }

            [Newtonsoft.Json.JsonProperty("DATE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string DATE { get; set; }

            [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ID { get; set; }

            [Newtonsoft.Json.JsonProperty("ORDER_STATUS_CODE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ORDER_STATUS_CODE { get; set; }

            [Newtonsoft.Json.JsonProperty("ORDER_STATUS", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string ORDER_STATUS { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_SMS", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_SMS { get; set; }

            [Newtonsoft.Json.JsonProperty("NOTIFY_BY_EMAIL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string NOTIFY_BY_EMAIL { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse__TABLE_type_tns
        {
            [Newtonsoft.Json.JsonProperty("SUBSCRIBER_INFO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string SUBSCRIBER_INFO { get; set; }

            [Newtonsoft.Json.JsonProperty("REJECT_DATE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string REJECT_DATE { get; set; }

            [Newtonsoft.Json.JsonProperty("DETAIL", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string DETAIL { get; set; }

            [Newtonsoft.Json.JsonProperty("LAST_PAYMENT_DATE", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string LAST_PAYMENT_DATE { get; set; }

            [Newtonsoft.Json.JsonProperty("AMOUNT", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string AMOUNT { get; set; }

            [Newtonsoft.Json.JsonProperty("INSTITUTION_NAME", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_NAME { get; set; }

            [Newtonsoft.Json.JsonProperty("STATUS", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string STATUS { get; set; }

            [Newtonsoft.Json.JsonProperty("DESCRIPTION", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string DESCRIPTION { get; set; }

            [Newtonsoft.Json.JsonProperty("TRX_NO", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string TRX_NO { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse__INSTITUTION_LIST_type_tns
        {
            [Newtonsoft.Json.JsonProperty("INSTITUTION_NAME", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string INSTITUTION_NAME { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Fault
        {
            [Newtonsoft.Json.JsonProperty("faultcode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Faultcode { get; set; }

            [Newtonsoft.Json.JsonProperty("faultstring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Faultstring { get; set; }

            [Newtonsoft.Json.JsonProperty("faultactor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Faultactor { get; set; }

            [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public object Detail { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header2
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header3
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header4
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header5
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header6
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header7
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header8
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class Header9
        {
            [Newtonsoft.Json.JsonProperty("HEADER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public HEADER_element_tns HEADER { get; set; }

        }
    }
}
