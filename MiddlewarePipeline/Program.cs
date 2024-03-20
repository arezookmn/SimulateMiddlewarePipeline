using MicroWebFramework.Pipeline;
using MicroWebFramework.Pipes;
using MiddlewarePipeline;
using System.Net;

var pipeline = new PipelineBuilder()
    .UsePipe(typeof(ExceptionHandlingPipe))
    .UsePipe(typeof(AuthenticationPipe))
    .UsePipe(typeof(EndPointPipe))
    .Build();


using (var listener = new HttpListener())
{
    listener.Prefixes.Add("http://localhost:8080/");
    listener.Start();

    Console.WriteLine("Listening for requests...");


    while (true)
    {
        HttpListenerContext context = listener.GetContext();

        pipeline.Invoke(new  HttpContext() { Request = context.Request, Response = context.Response });
    }
}

