using System.Net;

namespace MiddlewarePipeline;

public class HttpContext
{
    public HttpListenerRequest Request { get; set; }

    public HttpListenerResponse Response { get; set; }

}
