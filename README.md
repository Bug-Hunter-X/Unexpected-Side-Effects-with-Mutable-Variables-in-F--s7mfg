# Unexpected Side Effects with Mutable Variables in F# 

This example showcases a common error in F#: unexpected side effects due to mutable variables within a function. The `add` function modifies its input parameters, leading to behavior that is difficult to reason about.  The solution demonstrates how to avoid this using immutability and function composition.