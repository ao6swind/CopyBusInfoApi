# 環境 #
- OS: Ubuntu 18.04 on hyper-V
- runtime: dotnet core 2.2
- database: MySQL
# 筆記 #
- dotnet cli 產出來的預設專案會把專案目標設在netstandard2.0，必須手動在*.csproj的TargetFramework標籤改成netcoreapp2.2，用visual studio產出來的就不會有這問題（因為可以選）