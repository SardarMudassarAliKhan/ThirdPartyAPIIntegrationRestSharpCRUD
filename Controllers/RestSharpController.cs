using Microsoft.AspNetCore.Mvc;
using RestSharp;
using ThirdPartyAPIIntegrationRestSharpCRUD.Model;
using ThirdPartyAPIIntegrationRestSharpCRUD.RestSharpHealper;

namespace ThirdPartyAPIIntegrationRestSharpCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestSharpController : ControllerBase
    {
        [HttpPost(nameof(RestSharpPostRequest))]
        public void RestSharpPostRequest(Article article)
        {
            var client = new RestClientHelper("https://www.c-sharpcorner.com/articles/");

            var request = new RestRequest("/articles", Method.Post);
            request.AddJsonBody(article);

            client.Execute(request);
        }


        [HttpPut(nameof(RestSharpUpdateRequest))]
        public void RestSharpUpdateRequest(Article article)
        {
            var client = new RestClientHelper("https://www.c-sharpcorner.com/articles/");

            var request = new RestRequest($"/articles/{article.Id}", Method.Put);
            request.AddJsonBody(article);

            client.Execute(request);
        }


        [HttpDelete(nameof(RestSharpDeleteRequest))]
        public void RestSharpDeleteRequest(int articleId)
        {
            var client = new RestClientHelper("https://www.c-sharpcorner.com/articles/");

            var request = new RestRequest($"/articles/{articleId}", Method.Delete);

            client.Execute(request);
        }


        [HttpGet(nameof(RestSharpGetRequest))]
        public Article RestSharpGetRequest(int articleId)
        {
            var client = new RestClientHelper("https://www.c-sharpcorner.com/articles/");

            var request = new RestRequest($"/articles/{articleId}", Method.Get);

            return client.Execute<Article>(request);
        }


        [HttpPatch(nameof(RestSharpPatchRequest))]
        public void RestSharpPatchRequest(Article article)
        {
            var client = new RestClientHelper("https://www.c-sharpcorner.com/articles/");

            var request = new RestRequest($"/articles/{article.Id}", Method.Patch);
            request.AddJsonBody(new { article.Title, article.Content });

            client.Execute(request);
        }


    }
}
