/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.TrustedComms
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Initiates a Branded Call.
    /// </summary>
    public class CreatePhoneCallOptions : IOptions<PhoneCallResource>
    {
        /// <summary>
        /// Twilio number from which to originate the call
        /// </summary>
        public string From { get; }
        /// <summary>
        /// The terminating Phone Number
        /// </summary>
        public string To { get; }
        /// <summary>
        /// The business reason for this phone call
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string ApplicationSid { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string CallerId { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string MachineDetection { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public int? MachineDetectionSilenceTimeout { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public int? MachineDetectionSpeechEndThreshold { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public int? MachineDetectionSpeechThreshold { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public int? MachineDetectionTimeout { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string RecordingStatusCallback { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public List<string> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string SendDigits { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public string Trim { get; set; }
        /// <summary>
        /// Refers to the Voice API Initiate Call parameter
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Construct a new CreatePhoneCallOptions
        /// </summary>
        /// <param name="from"> Twilio number from which to originate the call </param>
        /// <param name="to"> The terminating Phone Number </param>
        public CreatePhoneCallOptions(string from, string to)
        {
            From = from;
            To = to;
            RecordingStatusCallbackEvent = new List<string>();
            StatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            if (Reason != null)
            {
                p.Add(new KeyValuePair<string, string>("Reason", Reason));
            }

            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid.ToString()));
            }

            if (CallerId != null)
            {
                p.Add(new KeyValuePair<string, string>("CallerId", CallerId));
            }

            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }

            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }

            if (MachineDetection != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetection", MachineDetection));
            }

            if (MachineDetectionSilenceTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSilenceTimeout", MachineDetectionSilenceTimeout.ToString()));
            }

            if (MachineDetectionSpeechEndThreshold != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSpeechEndThreshold", MachineDetectionSpeechEndThreshold.ToString()));
            }

            if (MachineDetectionSpeechThreshold != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSpeechThreshold", MachineDetectionSpeechThreshold.ToString()));
            }

            if (MachineDetectionTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionTimeout", MachineDetectionTimeout.ToString()));
            }

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", RecordingStatusCallback));
            }

            if (RecordingStatusCallbackEvent != null)
            {
                p.AddRange(RecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("RecordingStatusCallbackEvent", prop)));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }

            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim));
            }

            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Serializers.Url(Url)));
            }

            return p;
        }
    }

}