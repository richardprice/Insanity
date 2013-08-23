namespace Insanity
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["~/views/alt-index.cshtml"];
            };  
        }
    }
}