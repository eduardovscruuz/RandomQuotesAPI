using RandomQuotesAPI.Models;
using System.Text.Json;

namespace RandomQuotesAPI.Services
{
    public class QuoteService
    {
        private readonly string _quotesEnPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "quotes-en.json");
        private readonly string _quotesPtPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "quotes-pt.json");

        public List<Quote> GetQuotes(string language)
        {
            string path = language.ToLower() == "pt" ? _quotesPtPath : _quotesEnPath;
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Quote>>(json);
        }

        public Quote GetQuoteById(string language, int id)
        {
            var quotes = GetQuotes(language);
            return quotes.FirstOrDefault(q => q.Id == id);
        }
        public Quote GetQuoteById(string language, int id)
        {
            var quotes = GetQuotes(language);
            return quotes.FirstOrDefault(q => q.Id == id);
        }
    }
}