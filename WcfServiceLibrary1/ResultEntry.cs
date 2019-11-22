using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace WcfServiceLibrary1
{
    [DataContract]
    public class ResultEntry
    {
        [DataMember]
        public bool State { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Value { get; set; }

        public ResultEntry(bool state,string message,string value)
        {
            State = state;
            Message = message;
            Value = value;
        }

        public static ResultEntry CreateSuccessEntry(string thisIsTest)
        {
            return new ResultEntry(true,"OK",thisIsTest);
        }
    }
}
