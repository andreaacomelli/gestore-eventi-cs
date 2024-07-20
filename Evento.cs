class Evento
{

  private string titolo;
  private string data;
  private int postiTot, postiPrenotati = 0;

  public string Data { get => data; set => data = value; }
  public string Titolo { get => titolo; set => titolo = value; }
  public int PostiTot { get => postiTot; set => postiTot = value; }
  public int PostiPrenotati { get => postiPrenotati; set => postiPrenotati = value; }

  public Evento(string titolo, string data, int postiPrenotati, int postiTot)
  {
    this.titolo = titolo;
    this.data = data;
    this.postiPrenotati = postiPrenotati;
    this.postiTot = postiTot;
  }
}