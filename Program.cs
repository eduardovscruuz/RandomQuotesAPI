using RandomQuotesAPI.Services;
using RandomQuotesAPI.Models;
var builder = WebApplication.CreateBuilder(args);

// Injeção de dependência
builder.Services.AddSingleton<QuoteService>();

var app = builder.Build();

app.MapGet("/api/quotes/{language}/{id:int}", (string language, int id, QuoteService quoteService) =>
{
    var quote = quoteService.GetQuoteById(language, id);
    if (quote == null)
        return Results.NotFound("Quote not found");

    return Results.Ok(quote);
});

app.Run();
