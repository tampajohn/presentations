// START OMIT
package main

import "time"
import "fmt"

func main() {
	// Create a Ticker that emits a 'tick' every 1/2 second
	ticker := time.NewTicker(500 * time.Millisecond)

	// This chunk is executed async // HL
	go func() {
		// Go only has a for loop :) // HL
		for t := range ticker.C {
			fmt.Println("Tick at", t)
		}
	}()
	time.Sleep(1600 * time.Millisecond) // sleep the main thread for 1.6 seconds
	ticker.Stop()                       // Stop the ticker... no more 'ticks'
	fmt.Println("Ticker stopped")
}

// END OMIT
