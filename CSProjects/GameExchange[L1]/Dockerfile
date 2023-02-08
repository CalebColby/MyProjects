# Build Stage
	FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
	WORKDIR /source
	COPY . .
	RUN dotnet restore ".\GameExchange[L1]\GameExchange[L1].csproj" --disable-paralell
	RUN dotnet publish ".\GameExchange[L1]\GameExchange[L1].csproj" -c release -o /app ---no-restore
# Serve Stage
	FROM mcr.microsoft.com/dotnet/sdk:6.0-focal
	WORKDIR /app
	COPY --from=build /app ./

	EXPOSE 5000

	ENTRYPOINT ["dotnet", "GameExchange[L1].dll"]
