function solve(args) {
    let num1 = Number(args[0]);
    let num2 = Number(args[1]);
    let num3 = Number(args[2]);
    if (num1 === 0 || num2 === 0 || num3 === 0) {
        console.log("Positive");
    }
    else {
        args = args.filter(function(num){return num < 0});
        if (args.length === 1 || args.length === 3) {
            console.log("Negative");
        }
        else {
            console.log("Positive");
        }
    }
}