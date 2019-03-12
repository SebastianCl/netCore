namespace WebApplication1
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class SundayFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (DateTime.Now.DayOfWeek != DayOfWeek.Tuesday)
                context.Result = new ContentResult()
                {
                    Content = "Sorry only on sundays!"
                };
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do something after the action executes
        }
    }
}
