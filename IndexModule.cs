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
                return View["Articles/" + paramters.name];
            };
        }
    }
}