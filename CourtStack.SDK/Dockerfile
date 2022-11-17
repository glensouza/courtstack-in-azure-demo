FROM microsoft/nanoserver AS base
EXPOSE 80
EXPOSE 443

COPY ["/CourtStack.SDK/Vcms Rest Api", "/CourtStack.SDK/Vcms Rest Api/"]
WORKDIR "/CourtStack.SDK/Vcms Rest Api"
ENTRYPOINT ["dotnet", "CourtStack.Vcms.Api.Rest.dll"]
