# 環境 #
- OS: Ubuntu 18.04 on hyper-V
- runtime: dotnet core 2.2
- database: MySQL
# 筆記 #
- dotnet cli 產出來的類別庫專案會把專案目標設在netstandard2.0，必須手動在*.csproj的TargetFramework標籤改成netcoreapp2.2，用visual studio產出來的就不會有這問題（因為可以選）
- C#沒有多重繼承，所以讓CoreOperator實作界面和實例化DbOperator和ApiOperator，再去讓其他的Service繼承（不曉得這樣是不是正確... ... 歡迎跟我分享一下）