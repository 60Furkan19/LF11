# UML-Klassendiagramm – Rechner

```text
┌──────────────────────────────────────────┐
│                 Rechner                  │
├──────────────────────────────────────────┤
│ + Name: string                            │
│ + IpAdresse: string                       │
│ + Betriebssystem: string                  │
├──────────────────────────────────────────┤
│ + Rechner(name: string, ipAdresse: string,│
│            betriebssystem: string)        │
│ + AendereIpAdresse(neueIpAdresse: string):│
│   void                                    │
│ + LiefereInformationen(): string         │
└──────────────────────────────────────────┘
```

`+` bedeutet **public**. Die Anwendung speichert beliebig viele Objekte in
`List<Rechner> rechnerListe`.
