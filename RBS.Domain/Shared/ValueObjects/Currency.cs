
namespace RBS.Domain.Shared.ValueObjects;

public record Currency
{
    //Define valid currency
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EURO");

    //Add To List
    public static readonly IReadOnlyCollection<Currency> All = [Usd,Eur,None];
    
    private Currency(string code)=> Code = code;
    
    public string Code {get; init;}
    
    public static Currency FromCode(string code) 
        => All.FirstOrDefault(x => x.Code == code) 
           ?? throw new ApplicationException("The Currency Code not found");
}