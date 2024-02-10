using System.Dynamic;
using System.Net;

namespace brasil_api.Dtos
{
    public class ResponseGeneric<T> where T: class
    {
        public HttpStatusCode StatusCodeHttp { get; set; }
        public T? ReturnData { get; set; }
        public ExpandoObject? ErrorReturn { get; set; }

    }
}
