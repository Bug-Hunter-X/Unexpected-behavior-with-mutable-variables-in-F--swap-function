let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20, not 20 10 as expected because of mutable variables

//To fix this problem we need to use tuples
let swapTuple (x,y) = (y,x)

let x1 = 10
let y1 = 20
let (x2, y2) = swapTuple (x1,y1)
printf "%d %d" x2 y2 //This will print 20 10 as expected