namespace Insanity
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Get["/{name}"] = paramters =>
            {
                ViewBag.GoHome = true;
                return View["Articles/" + paramters.name];
            };
        }
    }
}