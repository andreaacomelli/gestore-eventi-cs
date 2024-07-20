namespace prova;

class Principale
{
  static void Main(string[] args)
  {
    try
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
        Console.WriteLine(evento.ToString());
      }
      else if (scelta == "disdire")
      {
        evento.Disdici();
        Console.WriteLine(evento.ToString());
      }
      else { Console.WriteLine("Inserisci un'opzione valida"); }

    }
    catch (ArgumentNullException e)
    {
      Console.WriteLine(e.Message);
    }
    catch (FormatException e)
    {
      Console.WriteLine("Formato non valido: " + e.Message);
    }
    catch (Exception e)
    {
      Console.WriteLine("Si è verificato un errore: " + e.Message);
    }

  }
}
