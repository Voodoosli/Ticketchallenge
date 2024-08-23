using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Model.Models.GetJourneys
{
 
    public class JourneysResponse
    {
        public string status { get; set; }
        public List<JourneysData> data { get; set; }
        public string message { get; set; }

        [JsonProperty("user-message")]
        public string usermessage { get; set; }

        [JsonProperty("api-request-id")]
        public string apirequestid { get; set; }
        public string controller { get; set; }

        [JsonProperty("client-request-id")]
        public string clientrequestid { get; set; }

        [JsonProperty("web-correlation-id")]
        public string webcorrelationid { get; set; }

        [JsonProperty("correlation-id")]
        public string correlationid { get; set; }
        public string parameters { get; set; }
    }

    public class JourneysData
    {
        public string id { get; set; }

        [JsonProperty("partner-id")]
        public string partnerid { get; set; }

        [JsonProperty("partner-name")]
        public string partnername { get; set; }

        [JsonProperty("route-id")]
        public string routeid { get; set; }

        [JsonProperty("bus-type")]
        public string bustype { get; set; }

        [JsonProperty("bus-type-name")]
        public string bustypename { get; set; }

        [JsonProperty("total-seats")]
        public string totalseats { get; set; }

        [JsonProperty("available-seats")]
        public string availableseats { get; set; }
        public Journey journey { get; set; }
        public List<Feature> features { get; set; }

        [JsonProperty("origin-location")]
        public string originlocation { get; set; }

        [JsonProperty("destination-location")]
        public string destinationlocation { get; set; }

        [JsonProperty("is-active")]
        public bool isactive { get; set; }

        [JsonProperty("origin-location-id")]
        public string originlocationid { get; set; }

        [JsonProperty("destination-location-id")]
        public string destinationlocationid { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("cancellation-offset")]
        public string cancellationoffset { get; set; }

        [JsonProperty("has-bus-shuttle")]
        public bool hasbusshuttle { get; set; }

        [JsonProperty("disable-sales-without-gov-id")]
        public bool disablesaleswithoutgovid { get; set; }

        [JsonProperty("display-offset")]
        public string displayoffset { get; set; }

        [JsonProperty("partner-rating")]
        public string partnerrating { get; set; }

        [JsonProperty("has-dynamic-pricing")]
        public bool hasdynamicpricing { get; set; }

        [JsonProperty("disable-sales-without-hes-code")]
        public bool disablesaleswithouthescode { get; set; }

        [JsonProperty("disable-single-seat-selection")]
        public bool disablesingleseatselection { get; set; }

        [JsonProperty("change-offset")]
        public string changeoffset { get; set; }
        public string rank { get; set; }

        [JsonProperty("display-coupon-code-input")]
        public bool displaycouponcodeinput { get; set; }

        [JsonProperty("disable-sales-without-date-of-birth")]
        public bool disablesaleswithoutdateofbirth { get; set; }

        [JsonProperty("open-offset")]
        public string openoffset { get; set; }

        [JsonProperty("display-buffer")]
        public string displaybuffer { get; set; }

        [JsonProperty("allow-sales-foreign-passenger")]
        public bool allowsalesforeignpassenger { get; set; }

        [JsonProperty("has-seat-selection")]
        public bool hasseatselection { get; set; }

        [JsonProperty("branded-fares")]
        public List<string> brandedfares { get; set; }

        [JsonProperty("has-gender-selection")]
        public bool hasgenderselection { get; set; }

        [JsonProperty("has-dynamic-cancellation")]
        public bool hasdynamiccancellation { get; set; }

        [JsonProperty("partner-terms-and-conditions")]
        public string partnertermsandconditions { get; set; }

        [JsonProperty("partner-available-alphabets")]
        public string partneravailablealphabets { get; set; }

        [JsonProperty("provider-id")]
        public string providerid { get; set; }

        [JsonProperty("partner-code")]
        public string partnercode { get; set; }

        [JsonProperty("enable-full-journey-display")]
        public bool enablefulljourneydisplay { get; set; }

        [JsonProperty("provider-name")]
        public string providername { get; set; }

        [JsonProperty("enable-all-stops-display")]
        public bool enableallstopsdisplay { get; set; }

        [JsonProperty("is-destination-domestic")]
        public bool isdestinationdomestic { get; set; }

        [JsonProperty("min-len-gov-id")]
        public string minlengovid { get; set; }

        [JsonProperty("max-len-gov-id")]
        public string maxlengovid { get; set; }

        [JsonProperty("require-foreign-gov-id")]
        public bool requireforeigngovid { get; set; }

        [JsonProperty("is-cancellation-info-text")]
        public bool iscancellationinfotext { get; set; }

        [JsonProperty("cancellation-offset-info-text")]
        public string cancellationoffsetinfotext { get; set; }

        [JsonProperty("is-time-zone-not-equal")]
        public bool istimezonenotequal { get; set; }

        [JsonProperty("markup-rate")]
        public string markuprate { get; set; }

        [JsonProperty("is-print-ticket-before-journey")]
        public bool isprintticketbeforejourney { get; set; }

        [JsonProperty("is-extended-journey-detail")]
        public bool isextendedjourneydetail { get; set; }

        [JsonProperty("is-payment-select-gender")]
        public bool ispaymentselectgender { get; set; }

        [JsonProperty("should-turkey-on-the-nationality-list")]
        public bool shouldturkeyonthenationalitylist { get; set; }

        [JsonProperty("markup-fee")]
        public string markupfee { get; set; }

        [JsonProperty("partner-nationality")]
        public string partnernationality { get; set; }

        [JsonProperty("generate-barcode")]
        public bool generatebarcode { get; set; }

        [JsonProperty("is-print-ticket-before-journey-badge")]
        public bool isprintticketbeforejourneybadge { get; set; }

        [JsonProperty("is-print-ticket-before-journey-mail")]
        public bool isprintticketbeforejourneymail { get; set; }

        [JsonProperty("is-show-fare-rules")]
        public bool isshowfarerules { get; set; }

        [JsonProperty("is-different-seat-price")]
        public bool isdifferentseatprice { get; set; }

        [JsonProperty("redirect-to-checkout")]
        public bool redirecttocheckout { get; set; }

        [JsonProperty("is-show-rating-avarage")]
        public bool isshowratingavarage { get; set; }

        [JsonProperty("partner-route-rating")]
        public string partnerrouterating { get; set; }

        [JsonProperty("partner-route-rating-vote-count")]
        public string partnerrouteratingvotecount { get; set; }

        [JsonProperty("partner-rating-vote-count")]
        public string partnerratingvotecount { get; set; }

        [JsonProperty("included-station-fee")]
        public bool includedstationfee { get; set; }

        [JsonProperty("is-domestic-route")]
        public bool isdomesticroute { get; set; }
    }

    public class Feature
    {
        public string id { get; set; }
        public string priority { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("back-color")]
        public string backcolor { get; set; }

        [JsonProperty("fore-color")]
        public string forecolor { get; set; }

        [JsonProperty("partner-notes")]
        public string partnernotes { get; set; }
    }

    public class Journey
    {
        public string kind { get; set; }
        public string code { get; set; }
        public List<Stop> stops { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public string currency { get; set; }
        public string duration { get; set; }

        [JsonProperty("original-price")]
        public string originalprice { get; set; }

        [JsonProperty("internet-price")]
        public string internetprice { get; set; }

        [JsonProperty("provider-internet-price")]
        public string providerinternetprice { get; set; }
        public string booking { get; set; }

        [JsonProperty("bus-name")]
        public string busname { get; set; }
       
        public List<string> features { get; set; }

        [JsonProperty("features-description")]
        public string featuresdescription { get; set; }
        public string description { get; set; }
        public string available { get; set; }

        [JsonProperty("partner-provider-code")]
        public string partnerprovidercode { get; set; }

        [JsonProperty("peron-no")]
        public string peronno { get; set; }

        [JsonProperty("partner-provider-id")]
        public string partnerproviderid { get; set; }

        [JsonProperty("is-segmented")]
        public bool issegmented { get; set; }

        [JsonProperty("partner-name")]
        public string partnername { get; set; }

        [JsonProperty("provider-code")]
        public string providercode { get; set; }

        [JsonProperty("sorting-price")]
        public string sortingprice { get; set; }
    }

 

   

    public class Stop
    {
        public string id { get; set; }
        public string  kolayCarLocationId { get; set; }
        public string name { get; set; }
        public string station { get; set; }
        public string time { get; set; }

        [JsonProperty("is-origin")]
        public bool isorigin { get; set; }

        [JsonProperty("is-destination")]
        public bool isdestination { get; set; }

        [JsonProperty("is-segment-stop")]
        public bool issegmentstop { get; set; }
        public string index { get; set; }

        [JsonProperty("obilet-station-id")]
        public string obiletstationid { get; set; }

        [JsonProperty("map-url")]
        public string mapurl { get; set; }

        [JsonProperty("station-phone")]
        public string stationphone { get; set; }

        [JsonProperty("station-address")]
        public string stationaddress { get; set; }
    }





}
