let mutable x = 10
let mutable y = 20

let swap (x:byref<int>) (y:byref<int>) =
    let temp = x
    x <- !y
    y <- temp

swap &x &y
printfn "%d %d" x y

//Alternative solution using a tuple
let swapTuple x y = (y,x)
let x2, y2 = swapTuple x y
printfn "%d %d" x2 y2