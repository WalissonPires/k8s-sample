## Build docker image

```sh
cd webapp
docker build -t k8s-webapp .

docker run -p 8080:3000 --name webapp -d k8s-webapp
docker rm webapp -f
docker ps
docker logs webapp
docker exec -it webapp sh

docker tag k8s-webapp wprmdev/k8s-webapp
docker push wprmdev/k8s-webapp
```

## K8s deploy

```sh
kubectl apply -f ./k8s/namespace.yaml
kubectl apply -f ./k8s/deployment.yaml
kubectl delete -f ./k8s/namespace.yaml
watch 'kubectl get pods'
```