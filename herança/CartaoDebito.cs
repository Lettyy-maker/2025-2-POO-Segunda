public class CartaoDebito
{
    public CartaoDebito()
    {
        bandeira = BandeiraCartao.Visa;
    }



    public string Numero { get; set; }
    //public string Bandeira { get; set; } //visa, Visa, VISA
    public BandeiraCartao bandeira{ get; set; }   
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }
    

}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo,
}