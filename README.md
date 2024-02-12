# Kata TDD - Validador de contrasenyes

Exercici per introduir-se al TDD amb C#.

## Objectiu
Implementar un programa que comprovi la validesa de contrasenyes aplicant TDD.
La contrasenya l'introduirà l'usuari, i la funció ens ha de retornar si s'ajusta als criteris o no (true o false).

Una contrasenya vàlida ha de complir els següents requisits:

	 - Tenir 8 caràcters o mes.
	 - Tenir una lletra majúscula.
	 - Tenir una lletra minúscula.
	 - Tenir un número.
	 - Tenir un guió baix '_'.

## Requeriments:

	- Volem un mètode que ens digui si una contrasenya és vàlida o no.
	- No ens interessa saber el motiu en cas que una contrasenya no sigui vàlida (el valor retornat és un booleà).

## Setup

Instal·lar .NET 8:
https://dotnet.microsoft.com/en-us/download/dotnet/8.0 

Clonar el repositori.
`git clone <repo_url>`

Crear una branca a partir del commit inicial:
`git checkout -b <nom_nova_branca> <hash_del_commit_inicial>`

## Compilació

Dins del directori de la solució:
`dotnet build`

## Execució

Dins del directori de la solució:
`dotnet run --project TDDKata.PasswordValidator/TDDKata.PasswordValidator.csproj`

## Tests

Dins del directori de la solució:
`dotnet test`

## Comprovacions de cadenes amb C#

- Té un número: `<cadena>.Any(char.IsDigit)`.
- Té una lletra minúscula: `<cadena>.Any(char.IsLower)`.
- Té una lletra majúscula: `<cadena>.Any(char.IsUpper)`.
- Té un guió baix: `<cadena>.Contains('_')`.

## Refactorització amb expressions regulars

Sense modificar els requisits, canviar el programa per que utilitzi expressions regulars per fer les validacions.

- Té un número: `(?=.*?[0-9])`.
- Té una lletra minúscula: `(?=.*?[a-z])`.
- Té una lletra majúscula: `(?=.*?[A-Z])`.
- Té un guió baix: `(?=.*?[_])`.
- Té al menys 8 caràcters: `.{8,}` .

Totes les validacions en una expressió: 
```c#
Regex validatePasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[_]).{8,}$");
bool validPassword = validatePasswordRegex.IsMatch(password); 
```
