# docker build . -t dotnet-dev
# docker run -it -v "$(pwd):/app" dotnet-dev
FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY . .

CMD ["bash"]
© 2021 GitHub, Inc.