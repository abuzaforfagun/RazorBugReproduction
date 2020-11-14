using System;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace Domain
{
    public class RazorHelper : IRazorHelper
    {
        private readonly IRazorViewEngine _viewEngine;

        public RazorHelper(IRazorViewEngine viewEngine)
        {
            _viewEngine = viewEngine;
        }
        public void FindView()
        {
            try
            {
            }
            catch (CompilationFailedException e)
            {
                throw new Exception(e.Message);
            }
        }
    }

    public interface IRazorHelper
    {
        void FindView();
    }
}
