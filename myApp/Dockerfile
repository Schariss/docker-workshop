# docker build . -t <VOTRE_ADRESSE_DE_CONTAINER_REGISTRY>/myapp
# Publier maintenant votre image sur un registre de conteneurs
# Voici une liste de registre de conteneur que vous pouvez utiliser
# - Docker : https://hub.docker.com/
# - GCP : https://cloud.google.com/container-registry/
# - Azure : https://azure.microsoft.com/fr-fr/services/container-registry/
# - AWS : https://aws.amazon.com/fr/ecr/
# - IBM Watson : https://www.ibm.com/fr-fr/cloud/container-registry/features

# Lien utile :
# - https://docs.docker.com/engine/reference/commandline/push/
FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY . .

RUN dotnet restore && dotnet build

ENTRYPOINT ["tail"]
CMD ["-f","/dev/null"]
