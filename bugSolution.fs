let x = 10
let y = 20

let add x y = 
    let sum = x + y
    (sum, x + sum, y + sum)

let (sum, newX, newY) = add x y
printf "%d %d %d" newX newY sum