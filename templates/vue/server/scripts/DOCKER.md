# DOCKER

```bash
# build (for app.dll)
docker build -t test .

# build (hello-dotnet-vue.dll)
export ENTRYPOINT_DLL='hello-dotnet-vue.dll'
docker build --build-arg ENTRYPOINT_DLL -t test .

# run
docker run -it test
```
