using Microsoft.AspNetCore.Components;

namespace BlazingShop.Pages.LearnBlazor
{
    public class LearnBlazorBase: ComponentBase
    {
        protected string WelcomeText = "Time to learn Blazor!";
        protected string name = "Spark";

        protected void getName()
        {
            name = "Blazor Learner";
        }
    }
}