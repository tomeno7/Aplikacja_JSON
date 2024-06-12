# Aplikacja_JSON

Aplikacja_JSON to przykładowa aplikacja ASP.NET Core MVC, która pozwala na dodawanie i wyświetlanie listy osób. Dane są przechowywane w formacie JSON w pliku `persons.json`.

## Wymagania

- .NET 6 SDK lub nowszy
- Visual Studio 2022 lub nowszy z zainstalowanymi narzędziami ASP.NET i web development

## Instalacja

1. Sklonuj repozytorium na swój lokalny komputer:

    ```bash
    git clone https://github.com/twoje-repozytorium/Aplikacja_JSON.git
    ```

2. Otwórz projekt w Visual Studio.

3. Upewnij się, że masz zainstalowany pakiet `Newtonsoft.Json`. Możesz go zainstalować za pomocą Menedżera pakietów NuGet:

    ```bash
    Install-Package Newtonsoft.Json
    ```

4. Utwórz folder `Data` w katalogu głównym projektu. Ten folder będzie przechowywał plik `persons.json`.

## Uruchomienie

1. Naciśnij `F5` w Visual Studio, aby uruchomić aplikację.

2. Aplikacja uruchomi się w przeglądarce internetowej. Powinnaś/powinieneś zobaczyć stronę, która pozwala na dodawanie nowych osób do listy oraz wyświetlanie listy osób.

## Struktura projektu

- `Controllers/HomeController.cs`: Kontroler odpowiedzialny za obsługę żądań HTTP.
- `Models/Person.cs`: Model danych reprezentujący osobę.
- `Views/Home/Index.cshtml`: Widok wyświetlający listę osób i formularz do dodawania nowych osób.
- `Startup.cs`: Plik konfiguracyjny aplikacji.
- `Program.cs`: Główny punkt wejścia do aplikacji.

## Opis działania

1. **Wyświetlanie listy osób:**
    - Gdy aplikacja jest uruchamiana, kontroler `HomeController` odczytuje dane z pliku `persons.json` (jeśli istnieje) i przekazuje je do widoku `Index`.

2. **Dodawanie nowej osoby:**
    - Formularz na stronie głównej pozwala na dodanie nowej osoby. Po przesłaniu formularza dane są zapisywane w pliku `persons.json`.

## Przykładowe dane

Jeśli chcesz przetestować aplikację z przykładowymi danymi, możesz ręcznie dodać dane do pliku `Data/persons.json` w formacie:

```json
[
    {
        "Name": "Jan Kowalski",
        "Age": 30,
        "City": "Warszawa"
    },
    {
        "Name": "Anna Nowak",
        "Age": 25,
        "City": "Kraków"
    }
]

