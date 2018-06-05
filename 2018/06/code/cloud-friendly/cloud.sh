    # Windows x64 // HL
    env GOOS=windows GOARCH=amd64 go build main.go

    # Linux x64 // HL
    env GOOS=linux GOARCH=amd64 go build main.go

    # Plan9 386 ... ;) // HL
    env GOOS=plan9 GOARCH=386 go build main.go
