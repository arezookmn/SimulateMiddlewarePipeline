using Dumpify;
using MicroWebFramework.Pipeline;
using MiddlewarePipeline;


namespace MicroWebFramework.Pipes;

public class AuthenticationPipe : BasePipe
{
    public AuthenticationPipe(Action<HttpContext> next) : base(next) { }
    public override void Invoke(HttpContext context)
    {
        "Start authenticate user".Dump();

        if (Next is not null) Next(context);

        "End of authenticate user".Dump();
    }
}

