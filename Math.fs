module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec steps s n =
    if n = 1UL then s
    elif n%2UL = 0UL then steps (s+1) (n/2UL)
    else steps (s+1) (3UL*n+1UL)
  steps 0 (uint64 n)
