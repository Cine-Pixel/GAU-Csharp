using System;

// Task 6.4.3

namespace oopBasics {
    public class Auto {
        public int TravelDistance(int tankCapacity, int distance) => (1 / tankCapacity) * distance;
        public float TravelDistance(float topSpeed, float timeTraveled) => topSpeed * timeTraveled;
    }
}
