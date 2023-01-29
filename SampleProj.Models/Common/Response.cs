using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.Models.Common
{
    public class Response
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
    }

    public class ListResponse<T> : Response
    {
        public List<T> Data { get; set; }
        public ListResponse(List<T> data)
        {
            Data = data;
        }
    }

    public class SingleResponse<T> : Response
    {
        public T Data { get; set; }
        public SingleResponse(T data)
        {
            Data = data;
        }
    }
}
