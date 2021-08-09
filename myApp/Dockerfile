# docker build . -t myapp
# docker tag myapp <username>/myapp
# docker push <username>/myapp
FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY . .

RUN dotnet restore && dotnet build

ENTRYPOINT ["tail"]
CMD ["-f","/dev/null"]
