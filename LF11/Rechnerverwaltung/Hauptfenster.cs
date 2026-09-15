using System.Net;

namespace Rechnerverwaltung;

public class Hauptfenster : Form
{
    private readonly List<Rechner> rechnerListe = new();
    private readonly TextBox txtName = new();
    private readonly TextBox txtIpAdresse = new();     private readonly TextBox txtBetriebssystem = new();
    private readonly ComboBox cboRechner = new();
    private readonly Label lblInformationen = new();

    public Hauptfenster()
    {
        Text = "Netzwerk-Rechnerverwaltung";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(520, 390);
        Font = new Font("Segoe UI", 10);

        var gruppeHinzufuegen = new GroupBox { Text = "Neuen Rechner hinzufügen", Left = 15, Top = 15, Width = 490, Height = 175 };
        gruppeHinzufuegen.Controls.AddRange(new Control[]
        {
            ErstelleBeschriftung("Name:", 20, 35),
            ErstelleBeschriftung("IP-Adresse:", 20, 70),
            ErstelleBeschriftung("Betriebssystem:", 20, 105)
        });

        KonfiguriereTextfeld(txtName, 150, 32);
        KonfiguriereTextfeld(txtIpAdresse, 150, 67);
        KonfiguriereTextfeld(txtBetriebssystem, 150, 102);
        var btnHinzufuegen = new Button { Text = "Hinzufügen", Left = 330, Top = 132, Width = 130 };
        btnHinzufuegen.Click += RechnerHinzufuegen;
        gruppeHinzufuegen.Controls.AddRange(new Control[] { txtName, txtIpAdresse, txtBetriebssystem, btnHinzufuegen });

        var gruppeVerwalten = new GroupBox { Text = "Vorhandenen Rechner verwalten", Left = 15, Top = 205, Width = 490, Height = 170 };
        gruppeVerwalten.Controls.Add(ErstelleBeschriftung("Rechner auswählen:", 20, 35));
        cboRechner.Left = 150; cboRechner.Top = 32; cboRechner.Width = 310;
        cboRechner.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRechner.SelectedIndexChanged += RechnerAuswahlGeaendert;

        lblInformationen.Left = 20; lblInformationen.Top = 70; lblInformationen.Width = 290; lblInformationen.Height = 75;
        lblInformationen.BorderStyle = BorderStyle.FixedSingle;
        var btnIpAendern = new Button { Text = "IP ändern", Left = 330, Top = 93, Width = 130 };
        btnIpAendern.Click += IpAdresseAendern;
        gruppeVerwalten.Controls.AddRange(new Control[] { cboRechner, lblInformationen, btnIpAendern });

        Controls.AddRange(new Control[] { gruppeHinzufuegen, gruppeVerwalten });
    }

    private static Label ErstelleBeschriftung(string text, int left, int top) => new() { Text = text, Left = left, Top = top, AutoSize = true };

    private static void KonfiguriereTextfeld(TextBox textBox, int left, int top)
    {
        textBox.Left = left;
        textBox.Top = top;
        textBox.Width = 310;
    }

    private void RechnerHinzufuegen(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtIpAdresse.Text) || string.IsNullOrWhiteSpace(txtBetriebssystem.Text))
        {
            MessageBox.Show("Bitte alle Eingabefelder ausfüllen.", "Eingabe fehlt");
            return;
        }

        if (!IPAddress.TryParse(txtIpAdresse.Text, out _))
        {
            MessageBox.Show("Bitte eine gültige IP-Adresse eingeben.", "Ungültige IP-Adresse");
            return;
        }

        var rechner = new Rechner(txtName.Text.Trim(), txtIpAdresse.Text.Trim(), txtBetriebssystem.Text.Trim());
        rechnerListe.Add(rechner);
        cboRechner.Items.Add(rechner);
        cboRechner.SelectedItem = rechner;
        txtName.Clear();
        txtIpAdresse.Clear();
        txtBetriebssystem.Clear();
    }

    private void RechnerAuswahlGeaendert(object? sender, EventArgs e)
    {
        if (cboRechner.SelectedItem is Rechner rechner)
            lblInformationen.Text = rechner.LiefereInformationen();
    }

    private void IpAdresseAendern(object? sender, EventArgs e)
    {
        if (cboRechner.SelectedItem is not Rechner rechner)
        {
            MessageBox.Show("Bitte zuerst einen Rechner auswählen.", "Keine Auswahl");
            return;
        }

        string? neueIp = Microsoft.VisualBasic.Interaction.InputBox(
            "Neue IP-Adresse eingeben:", "IP-Adresse ändern", rechner.IpAdresse);
        if (string.IsNullOrWhiteSpace(neueIp)) return;
        if (!IPAddress.TryParse(neueIp, out _))
        {
            MessageBox.Show("Bitte eine gültige IP-Adresse eingeben.", "Ungültige IP-Adresse");
            return;
        }

        rechner.AendereIpAdresse(neueIp.Trim());
        int index = cboRechner.SelectedIndex;
        cboRechner.Items[index] = rechner; // Anzeige in der ComboBox aktualisieren
        cboRechner.SelectedIndex = index;
        lblInformationen.Text = rechner.LiefereInformationen();
    }
}
