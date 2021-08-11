# Conteneurisation de l'application C# Et ajout de notre application dans le docker-compose

Fichier à modifier :
- docker-compose.yml
- myApp\Dockerfile

## But :
Mettre notre application dans un container Docker afin de l'éxécuter sans avoir .NET Core installé.

## Attention !
L'application devrait échouer car dans un container elle ne peut pas se connecter à la base de données mongo locale.

## Liens utiles
- https://hub.docker.com/_/microsoft-dotnet-sdk
- https://docs.docker.com/engine/reference/builder/#from