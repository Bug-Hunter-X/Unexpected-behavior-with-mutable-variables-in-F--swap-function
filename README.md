# F# Mutable Variable Swap Bug

This repository demonstrates a common issue encountered when working with mutable variables in F#.  The `swap` function, using mutable variables, produces unexpected results, showcasing the potential pitfalls of mutable state.  The solution showcases a safer approach using tuples and immutability.

## Bug
The original `swap` function attempts to swap the values of two mutable variables. However, due to the way mutable variables are handled, the output is not as expected.

## Solution
The solution demonstrates the use of tuples to elegantly swap values without relying on mutable variables, leading to more predictable and maintainable code. This approach leverages the immutability features of F# for better code clarity and safety.