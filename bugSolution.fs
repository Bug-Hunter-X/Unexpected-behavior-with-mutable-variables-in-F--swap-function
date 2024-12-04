let swapTuple (x,y) = (y,x)

let x1 = 10
let y1 = 20
let (x2, y2) = swapTuple (x1,y1)
printf "%d %d" x2 y2 //This will print 20 10 as expected