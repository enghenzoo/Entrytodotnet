namespace WebApplication1.Middlewares
{
    public class CalcMiddleware
    {
        private RequestDelegate _next;
        private ILogger<CalcMiddleware> _logger;
        private static List<string> _requestPaths = new List<string>();
        public CalcMiddleware(RequestDelegate next, ILogger<CalcMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            string path = context.Request.Path;
            _requestPaths.Add(path);
            await _next(context);
        }
        public static IReadOnlyList<string> GetRequestPaths() => _requestPaths.AsReadOnly();
    }
}
