﻿using System.Runtime.Serialization;
using System.Net;

namespace Torbali.Core.Common.Contracts
{
   [DataContract]
    public class ApiResponse<T>
    {
        public ApiResponse(HttpStatusCode statusCode, T result, string errorMessage = null)
        {
            StatusCode = (int)statusCode;
            Result = result;
            ErrorMessage = errorMessage;
        }

        public ApiResponse()
        {

        }
        [DataMember]
        public string Version {  get {return "1.0"; } }
        [DataMember]
        public int StatusCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public T Result { get; set; }

    }
}
