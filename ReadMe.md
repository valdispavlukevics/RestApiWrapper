### Simple REST API endpoints wrapper 

Sample GET execution

```csharp
var responseMessage = await RestApiWrapper.Get<IMetaWeatherApi>(s => s.QueryByLocation("862592"));
```