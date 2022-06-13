using Microsoft.AspNetCore.Http;

namespace takes.core.Http
{
    public interface Back
    {
        public void Accept(HttpContext context);
    }
}
