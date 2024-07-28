![Kubernetes Architecture](./kubernetesArchitecture.png)


DELETE all

kubectl delete deployment --all
kubectl delete service --all
kubectl delete pod --all
kubectl delete configmap --all
kubectl delete secret --all
kubectl delete ingress --all
kubectl delete pvc --all
kubectl delete pv --all
kubectl delete namespace --all


Reapply

kubectl apply -f platforms-depl.yaml
kubectl apply -f platforms-np-srv.yaml


Check

kubectl get pods 
kubectl get services 
