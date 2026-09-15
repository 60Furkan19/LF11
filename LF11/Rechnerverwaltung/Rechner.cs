namespace Rechnerverwaltung;

/// <summary>Modelliert einen im Netzwerk verwalteten Rechner.</summary>
public class Rechner
{
    // Für Meilenstein 1 bewusst public: Zugriffsmodifikator ist sichtbar.
    public string Name;
    public string IpAdresse;
    public string Betriebssystem;

    public Rechner(string name, string ipAdresse, string betriebssystem)
    {
        Name = name;
        IpAdresse = ipAdresse;
        Betriebssystem = betriebssystem;
    }

    public void AendereIpAdresse(string neueIpAdresse)
    {
        IpAdresse = neueIpAdresse;
    }

    public string LiefereInformationen()
    {
        return $"Name: {Name}\r\nIP-Adresse: {IpAdresse}\r\nBetriebssystem: {Betriebssystem}";
    }

    public override string ToString() => $"{Name} ({IpAdresse})";
}
