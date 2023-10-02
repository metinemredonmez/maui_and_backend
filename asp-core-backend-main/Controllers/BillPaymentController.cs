using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyNamespace;
using RestSharp;
using System.Threading.Channels;
using Microsoft.AspNetCore.Http;
using static WebApplication1.Models.BillPaymentModel;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillPaymentController : ControllerBase
    {

        private readonly ILogger<BillPaymentController> _logger;
        private readonly IBillPayment billPayment;

        public BillPaymentController(ILogger<BillPaymentController> logger, IBillPayment billPayment)
        {
            _logger = logger;
            this.billPayment = billPayment;
        }

        [HttpPost(Name = "Billmayment1")]
        public async Task<string> LoginAsync()
        {

           var response = billPayment.LoginAsync(new Models.BillPaymentModel.LOGIN_element_core { LANGUAGE = "tr", CLIENT_SESSION_ID = "19471947" }).Result;
           CookieOptions options = new CookieOptions();
           options.Expires = DateTime.Now.AddHours(1);

           HttpContext.Response.Cookies.Append("Cookie",response.SESSION_ID,options);
           return null;
        }

        [HttpPost("getSektorList")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTResponse_element_tns> BillpaymentGetSectorListAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];

            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LISTInput()
            {
                WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LIST = new WEBEXT_ADCBI_BILLPAYMENT_GET_SECTOR_LIST_element_tns()
                {
                    CLIENT_SESSION_ID = "19471947",
                    CLIENT_TRX_ID_RESERVED = "e101f864-1b5b-419d-b165-4b611ffdf593"
                },
                Header = new Models.BillPaymentModel.Header()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentGetSectorListAsync(models).Result;
            return response;
        }

        // COPRATE LIST
        [HttpPost("getCoprateList")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTResponse_element_tns> BillpaymentGetCorporateListAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LISTInput()
            {
                WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LIST = new WEBEXT_ADCBI_BILLPAYMENT_GET_CORPORATE_LIST_element_tns()
                {
                    CLIENT_SESSION_ID = "19471947",
                    CLIENT_TRX_ID_RESERVED = "e101f864-1b5b-419d-b165-4b611ffdf593",
                    SECTOR_CODE = "S-18",
                    STANDING_ORDER = "abc"
                },
                Header = new BillPaymentModel.Header2()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentGetCorporateListAsync(models).Result;
            return response;
        }

        // GET PAYMENT LIST
        [HttpPost("getPaymentList")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSResponse_element_tns> BillpaymentGetPaymentInputsAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTSInput()
            {
                WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTS = new WEBEXT_ADCBI_BILLPAYMENT_GET_PAYMENT_INPUTS_element_tns()
                {
                    CLIENT_SESSION_ID = "19471947",
                    CLIENT_TRX_ID_RESERVED = "e101f864-1b5b-419d-b165-4b611ffdf593",
                    INSTITUTION_OID="8ada8f5679ea23b70179ead7ed930273|~|KFT_CORPORATE_OID",
                    STANDING_ORDER = "abc"
                },
                Header = new BillPaymentModel.Header3()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentGetPaymentInputsAsync(models).Result;
            return response;
        }


        // GET Bill LIST
        [HttpPost("getBillList")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTResponse_element_tns> BillpaymentGetBillListAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LISTInput()

            {
                WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST = new WEBEXT_ADCBI_BILLPAYMENT_GET_BILL_LIST_element_tns()
                {
                    CLIENT_SESSION_ID = "19471947",
                    CLIENT_TRX_ID_RESERVED = "e101f864-1b5b-419d-b165-4b611ffdf593",
                    INSTITUTION_OID = "8ada8f5679ea23b70179ead7ed930273|~|KFT_CORPORATE_OID",
                    SUBSCRIBER_NO = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string>
                        {
                            { "KEY", "SUBSCRIBER_NO1" },
                            { "VALUE", "5420013927" }
                        }
                    },
                    CUSTOMER_NO = "1000205"
                },
                Header = new BillPaymentModel.Header4()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentGetBillListAsync(models).Result;
            return response;
        }

        //************************************************************


        // GET PAYMENT PAY
        [HttpPost("getPaymentPay")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_PAYResponse_element_tns> BillpaymentPayAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_PAYInput()
            {
                WEBEXT_ADCBI_BILLPAYMENT_PAY = new WEBEXT_ADCBI_BILLPAYMENT_PAY_element_tns()
                {
                    CLIENT_SESSION_ID=  "19471947",
                    CLIENT_TRX_ID_RESERVED = "1630820750065664",
                    CUSTOMER_NO= "1000205",
                    ACCOUNT_NO = "6972802",
                    CARD_NO = "",
                    CREATE_STDORD = "0",
                    OBJECT = "TERM_MONTH~03||INVOICE_AMOUNT~4.0||PARAMETER20~null||INVOICE_MAIN_OID~0||SUBSCRIBER_HASH~1569194053||COLLECTION_TYPE_NAME~null||PARAMETER8~null||PARAMETER7~null||PARAMETER6~null||PARAMETER5~null||INSTALLMENT_NO~0||PARAMETER4~null||INVOICE_NO~SC20160300000001||PARAMETER3~4.0:MSISDN:INN13927:2022-03-11:BPPS TEST SERTIFIKA:SC20160300000001:5420013927:0000013927:0:2016-03:MID_DEBIT:2943:11432943||PARAMETER2~0||PARAMETER1~0000013927||PARAMETER13~null||PARAMETER12~null||PARAMETER11~null||PARAMETER10~null||PARAMETER17~null||PARAMETER16~null||PARAMETER15~null||INVOICE_DATE~null||PARAMETER14~null||SUBSCRIBER_NAME~BPPS TEST SERTIFIKA||PARAMETER18~null||INVOICE_DUE_DATE~20220311||PARAMETER19~null||TERM_YEAR~2016||PARAMETER9~null",
                    AMOUNT = "7.0",
                    INSTITUTION_OID = "8ada8f5679ea23b70179ead7ed930273|~|KFT_CORPORATE_OID",
                    SECTOR_CODE = "S-18",
                    NOTIFY_BY_SMS = "false",
                    NOTIFY_BY_EMAIL = "false",
                    PAYMENT_SOURCE = "A",
                    SUBSCRIBER_NO = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string>
                        {
                            { "KEY", "SUBSCRIBER_NO1" },
                            { "VALUE", "5420013927" }
                        }
                    }
                },
                Header = new BillPaymentModel.Header5()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentPayAsync(models).Result;
            return response;
        }


        //**************

        // GET CREATE STANDING ORDER
        [HttpPost("getBillPaymentCreateStandingOrder")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERResponse_element_tns> BillpaymentCreateStandingOrderAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDERInput()

            {
                WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER = new WEBEXT_ADCBI_BILLPAYMENT_CREATE_STANDING_ORDER_element_tns()
                {
                    CLIENT_SESSION_ID = "19471947",
                    CLIENT_TRX_ID_RESERVED = "1292597033172992",
                    CUSTOMER_NO =  "1000205",
                    ACCOUNT_NO = "6972802",
                    CARD_NO =  "",
                    INSTITUTION_OID =  "8ada8bea4468b0ad01446947929a02f5|~|KFT_CORPORATE_OID",
                    SECTOR_CODE =  "S-18",
                    NOTIFY_BY_SMS = "false",
                    NOTIFY_BY_EMAIL = "false",
                    PAYMENT_SOURCE = "A",
                    SUBSCRIBER_NO = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string>
                        {
                            { "KEY", "SUBSCRIBER_NO1" },
                            { "VALUE", "5420013927" }
                        }
                    },
                    CUSTOMER_CELLPHONE =  "",
                    EMAIL =  ""

                },
                Header = new BillPaymentModel.Header6()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentCreateStandingOrderAsync(models).Result;
            return response;
        }


        // *****************************************


        // GET GET UPDATE STANDING ORDER
        [HttpPost("getBillPaymentUpdateStandingOrder")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERResponse_element_tns> BillpaymentUpdateStandingOrderAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDERInput()

            {
                WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDER = new WEBEXT_ADCBI_BILLPAYMENT_UPDATE_STANDING_ORDER_element_tns()
                {
                    CLIENT_SESSION_ID = "19471947",
                    CLIENT_TRX_ID_RESERVED = "1794489219809280",
                    CUSTOMER_NO =  "1000205",
                    ACCOUNT_NO = "6972802",
                    ID="8ada8f5682fcbc6f0182fd59b88e0403",
                    ORDER_STATUS_CODE= "1",
                    NOTIFY_BY_SMS = "true",
                    NOTIFY_BY_EMAIL = "true",

                },
                Header = new BillPaymentModel.Header7()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentUpdateStandingOrderAsync(models).Result;
            return response;
        }

        // *********************************

        // GET GET STANDING ORDER LIST
           [HttpPost("getBillPaymentStandingOrderList")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTResponse_element_tns> BillpaymentGetStandingOrderListAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LISTInput()
            {
                WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LIST = new WEBEXT_ADCBI_BILLPAYMENT_GET_STANDING_ORDER_LIST_element_tns()
                {
                    CLIENT_SESSION_ID=  "19471947",
                    CLIENT_TRX_ID_RESERVED = "2021913046024192",
                    CUSTOMER_NO= "1000205",

                },
                Header = new BillPaymentModel.Header8()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentGetStandingOrderListAsync(models).Result;
            return response;
        }

        // ********************
        // GET BILL PAYMENT GET HISTORY

        [HttpPost("getBillPaymentGetHistory")]
        public async Task<WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYResponse_element_tns> BillpaymentGetHistoryAsync()
        {
            var cookie = HttpContext.Request.Cookies["Cookie"];
            var models = new Models.BillPaymentModel.WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORYInput()
            {
                WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORY = new WEBEXT_ADCBI_BILLPAYMENT_GET_HISTORY_element_tns()
                {
                    CLIENT_SESSION_ID=  "19471947",
                    CLIENT_TRX_ID_RESERVED = "2491922155307008",
                    CUSTOMER_NO= "6972802",

                },
                Header = new BillPaymentModel.Header9()
                {
                    HEADER = new Models.BillPaymentModel.HEADER_element_tns()
                    {
                        SESSION_ID = cookie,
                        CLIENT_INFO_RESERVED = "12345"
                    }
                }
            };
            var response = billPayment.BillpaymentGetHistoryAsync(models).Result;
            return response;
        }


    }
}
