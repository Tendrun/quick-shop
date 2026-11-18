ApplicationUserEntity (Infrastruktura)
To jest klasa, którą "widzi" Entity Framework. Jej jedynym celem jest reprezentowanie fizycznej struktury tabeli w bazie danych SQL. Zawiera klucze obce, relacje bazy danych i właściwości specyficzne dla ASP.NET Identity (jak PasswordHash). Nie ma w niej żadnej logiki biznesowej. Służy tylko do zapisu i odczytu z dysku.

UserAccount (Domena)
To jest czysty obiekt biznesowy C# (POCO). Żyje wyłącznie w pamięci RAM podczas działania programu. To na nim wykonujesz operacje biznesowe, sprawdzasz uprawnienia i przetwarzasz dane. Ta klasa nie ma pojęcia, czy została pobrana z bazy SQL Server, PostgreSQL, czy z pliku tekstowego.

Używamy w projekcie HTTPOnly Cookie, ASP.net Identity


Okej jest problem próbuje zaimplemenotwać asp.net Identity
ALE: 
- NIE MOGĘ w domain
wniosek:
- Musi byc w infrastructure entity,
architecture.md mówi 
and Domain for entity mapping

ApplicationUserEntity - będz
Okej kolejny błąd architetkoniczny na poziomie Application jest IUserAccountRepository nie jestem w stanie odwołac się do ApplicationUserEntity.cs
- nie jestem w stanie odwołać się do infrastructure Entity
rozwiązanie dodanie relacji do infrastruktury
Okej nieważne muszę odwołać się do klasy UserAccount w domain bo to jest biznesowa logika