## Lab 3

**Vardas Pavardė:** Henrikas Otas
**Grupė:** PS-5
**Paskaitos data:** 2026-02-11
**Random užduotis:** 2

### Paleidimas

dotnet run --project Lab1.App

### Ką įgyvendinta

Sukurtas IAverageStrategy interface vidurkio skaičiavimui

Įgyvendintos dvi strategijos:
SimpleAverageStrategy – grąžina paprastą vidurkį
WeightedAverageStrategy – pritaiko svorinį skaičiavimą

Sukurtas StudentService, kuris naudoja strategiją per konstruktorinį perdavimą

Polymorphism – pakeitus vidurkio skaičiavimo strategiją (Simple → Weighted), programos logika nesikeičia, keičiasi tik rezultatas

Vidurkio skaičiavimo logika atskirta nuo pagrindinės programos logikos (laikomasi lankstumo ir išplečiamumo principų)

### Architektūros paaiškinimas

Vidurkio skaičiavimas nėra užkoduotas tiesiogiai Student ar Program klasėse – vietoj to naudojamas IAverageStrategy interface, kuris leidžia turėti kelias skirtingas skaičiavimo implementacijas.

StudentService klasė nepriklauso nuo konkrečios vidurkio skaičiavimo strategijos – ji dirba su abstrakcija (IAverageStrategy). Strategija perduodama per konstruktorių.

