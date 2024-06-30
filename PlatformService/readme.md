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
```

- Docker
  - install docker
  - add docker file, from microsoft website
  - docker build -t platformservice .
  - docker run -p 8080:8080 platformservice


- K8S
  - kubectl apply -f platforms-depl.yaml
    - if the following error happening
      ```terminal
      error: error validating "platforms-depl.yaml": error validating data: failed to download openapi: Get "https://127.0.0.1:62895/openapi/v2?timeout=32s": dial tcp 127.0.0.1:62895: connectex: No connection could be made because the target machine actively refused it.; if you choose to ignore these errors, turn validation off with --validate=false
      ```
      - ```minikube start```
      - Check Kubeconfig is Misconfigured
        ```terminal
          kubectl config get-contexts
          kubectl config current-context
          kubectl config view
        ```
      - ...
    - ..
  - kubectl get deployments
  - kubectl get pods
  - kubectl logs <pod-name>
    kubectl logs platforms-depl-68cdc76944-q49hr

- Initialise CommandsService
  - ```dotnet new webapi -n CommandsService```