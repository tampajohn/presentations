CGO_ENABLED=0 GOOS=darwin go build -a -ldflags '-extldflags "-static"' -o go-performance
./go-performance