// START OMIT

package main

import (
	_ "expvar"
	"fmt"
	"net/http"
)

func main() {
	http.HandleFunc("/endpoint", func(w http.ResponseWriter, r *http.Request) {
		w.Write([]byte("Success"))
		r.Body.Close()
	})
	fmt.Println("Listening on :5002")
	http.ListenAndServe(":5002", nil)
}

// END OMIT
