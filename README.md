# Conteneurisation de l'application C#

## But :
Mettre notre application dans un container Docker afin de l'éxécuter sans avoir .NET Core installé.

## Attention !
L'application devrait échouer car dans un container elle ne peut pas se connecter à la base de données mongo locale.

## Liens utiles
https://hub.docker.com/_/microsoft-dotnet-sdk
https://docs.docker.com/engine/reference/builder/#from