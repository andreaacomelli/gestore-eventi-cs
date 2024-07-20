namespace prova;

class Principale
{
  static void Main(string[] args)
  {
    Console.WriteLine("Inserisci il titolo dell'evento: ");
    string titolo = Console.ReadLine();

    Console.WriteLine("Inserisci la data dell'evento (formato yyyy-MM-dd): ");
    string dataString = Console.ReadLine();
    DateTime data = DateTime.Parse(dataString);

    Console.WriteLine("Inserisci il numero di posti prenotati: ");
    int postiPrenotati = int.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci il numero totale di posti: ");
    int postiTot = int.Parse(Console.ReadLine());

    Evento evento = new(titolo, data, postiPrenotati, postiTot);

    Console.WriteLine("Cosa desideri fare: prenotare o disdire un posto?");
    string scelta = Console.ReadLine().ToLower();

    if (scelta == "prenotare")
    {
      evento.Prenota();
      evento.ToString();
    }
    else if (scelta == "disdire")
    {
      evento.Disdici();
      evento.ToString();
    }
    else { Console.WriteLine("Inserisci un'opzione valida"); }
  }
}
