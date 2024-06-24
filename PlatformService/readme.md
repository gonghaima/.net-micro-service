Progress: 2:35:46
- Initialise

  ```dotnet new webapi -n PlatformService```
- Add required packages
  
```dotnet new webapi -n PlatformService
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

- Docker
  - install docker
  - add docker file, from microsoft website
  - docker build -t platformservice .
  - docker run -p 8080:8080 platformservice



