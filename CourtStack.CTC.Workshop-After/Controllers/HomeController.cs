using CourtStack.CTC.Workshop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourtStack.CTC.Workshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly HttpClient client;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
            this.client = new HttpClient { BaseAddress = new Uri("https://localhost:5001/") };
            this.client.DefaultRequestHeaders.Add("Provider", "Redline");
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SearchCase(string caseId)
        {
            this.logger.LogInformation($"looking up case {caseId}");
            CaseSummary caseSummary;
            using (HttpResponseMessage response = await this.client.GetAsync($"api/cases/{caseId}"))
            {
                string responseString = await response.Content.ReadAsStringAsync();
                caseSummary = CaseSummary.FromJson(responseString);
            }

            return View("SearchCase", caseSummary);
        }

        public async Task<IActionResult> CaseDetail(string caseId)
        {
            this.logger.LogInformation($"looking up case detail {caseId}");
            CaseDetail caseDetail;
            using (HttpResponseMessage response = await this.client.GetAsync($"api/cases/{caseId}/detail"))
            {
                string responseString = await response.Content.ReadAsStringAsync();
                caseDetail = Models.CaseDetail.FromJson(responseString);
            }

            return View("CaseDetail", caseDetail);
        }

        public async Task<IActionResult> OpenDocument(long documentId)
        {
            this.logger.LogInformation($"opening up document {documentId}");
            Document document;
            using (HttpResponseMessage response = await this.client.GetAsync($"api/Documents/{documentId}"))
            {
                string responseString = await response.Content.ReadAsStringAsync();
                document = JsonConvert.DeserializeObject<Document>(responseString);
            }

            byte[] imageBytes = Convert.FromBase64String(document.Payload);
            return File(imageBytes, $"application/{document.Extension}", $"{document.Name}{document.Extension}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
