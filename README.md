# Duży Lotek

Aplikacja Windows Forms w języku C# symulująca losowanie liczb w grze Duży Lotek z wykorzystaniem wielowątkowości.

## Funkcjonalności

- Losowanie głównego zestawu 6 liczb z zakresu 1–49 na starcie programu
- Dwie niezależne maszyny losujące działające na osobnych wątkach (`Thread`)
- Wyświetlanie wyników losowania dla każdej maszyny
- Sprawdzanie liczby trafień względem głównego zestawu liczb
- Zliczanie wystąpień trafień:
  - 3 liczby
  - 4 liczby
  - 5 liczb
- Automatyczne zatrzymanie działania po trafieniu wszystkich 6 liczb
- Możliwość ręcznego zatrzymania symulacji przyciskiem **Stop**

## Technologie

- C#
- .NET
- Windows Forms
- Wielowątkowość (`System.Threading`)
- Git / GitHub

## Uruchomienie projektu

1. Sklonuj repozytorium:

```bash
git clone https://github.com/PatrycjaL/duzy_lotek.git
```

2. Otwórz projekt w Visual Studio

3. Uruchom aplikację
