using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Response
{

    public class ResponseObject
    {
        public ResponseObject() : this(null, null) { }
        public ResponseObject(Exception error, string message)
        {
            IsSuccess = IsValidInput = error == null;
            Message = message;
            Error = error;
        }
        public ResponseObject(Exception error) : this(error, error.Message)
        {
        }

        [JsonIgnore]
        public Exception Error { get; set; } // hasValue 500
        public string Message { get; set; }
        public bool IsSuccess { get; set; } //true 200
        public bool IsValidInput { get; set; } // true 400

        public bool ShouldSerializeError()
        {
            return false;
        }
        public string ResponseCode { get; set; }
    }
    public class ResponseObject<T> : ResponseObject
    {
        public ResponseObject(T data)
        {
            Data = data;
            IsSuccess = true;
            IsValidInput = true;
        }
        public ResponseObject(Exception error) : base(error, error.Message)
        {
        }

        public ResponseObject(T data, string message)
        {
            Data = data;
            IsSuccess = true;
            IsValidInput = true;
            Message = message;
        }

        public ResponseObject(T data, string message, bool success)
        {
            Data = data;
            IsSuccess = success;
            Message = message;
        }
        public ResponseObject(T data, bool success)
        {
            Data = data;
            IsSuccess = success;
        }
        public T Data { get; set; }
    }

}
