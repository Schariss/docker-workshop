# Docker-workshop
## Pré-requis

Avoir 
- `docker` et `docker-compose` sur sa machine. 
  - Windows : https://docs.docker.com/docker-for-windows/install/
  - Linux : https://docs.docker.com/engine/install/ubuntu/
  - Mac : https://docs.docker.com/docker-for-mac/install/
- (optionnel) Avoir n'importe qu'elle version de dotnet core, ou la version aspnet core 5 pour utiliser l'exemple.
  - https://dotnet.microsoft.com/download/dotnet-core (win, linux, mac)
- (optionnel) Avoir git

Vérifier vos installations avec :
```
docker -v
docker-compose -v
dotnet --list-sdks
dotnet --list-runtimes
```
## Comment faire ce workshop ?
Vous devez suivre les étapes incluses dans le fichier steps.txt.
Vous pouvez faire la commande 
```
git checkout <no de l'étape>
```
Pour aller directement à une étape ou alors si vous êtes bloqué.

## Démmarrer
```bash
git clone https://github.com/Distil62/docker-workshop.git
cd docker-workshop
git checkout 1
```
