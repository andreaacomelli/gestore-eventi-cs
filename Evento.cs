class Evento
{
  private string titolo;
  private DateTime data;
  private int postiTot, postiPrenotati = 0;

  public DateTime Data { get => data; set => data = value; }
  public string Titolo { get => titolo; set => titolo = value; }
  public int PostiTot { get => postiTot; }
  public int PostiPrenotati { get => postiPrenotati; set => postiPrenotati = value; }

  public Evento(string titolo, DateTime data, int postiPrenotati, int postiTot)
  {
    this.titolo = titolo;
    this.data = data;
    this.postiPrenotati = postiPrenotati;
    this.postiTot = postiTot;
  }

  public void Prenota(int postiDaPrenotare)
  {
    int dataComparata = Data.CompareTo(DateTime.Now); //compareTo restituisce valore intero che se > 0 significa che data è futuro ad oggi

    if (postiTot > postiPrenotati && dataComparata > 0 && postiDaPrenotare < PostiTot)
    {
      postiPrenotati += postiDaPrenotare;
    }
    else { Console.WriteLine("Non è possibile registrare la prenotazione, controlla la validità dei dati inseriti"); }
  }

  public void Disdici(int postiDaDisdire)
  {
    int dataComparata = Data.CompareTo(DateTime.Now); //compareTo restituisce valore intero che se > 0 significa che data è futuro ad oggi

    if (PostiPrenotati == 0 && dataComparata > 0 && postiDaDisdire < PostiPrenotati && postiDaDisdire < PostiTot)
    {
      PostiPrenotati -= postiDaDisdire;
    }
    else { Console.WriteLine("Non è possibile disdire la prenotazione, controlla la validità dei dati inseriti"); }
  }

  public override string ToString()
  {
    return $"Titolo: {Titolo}, Data: {Data.ToString("MMMM dd, yyyy")}, Posti Totali: {PostiTot}, Posti Prenotati: {PostiPrenotati}.";
  }
}