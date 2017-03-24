function solve(args) {
    let len = args[0];
    args.shift();
    let arr = [];

    for (let i = 0; i < len; i++) {
        arr[i] = 0;
    }

    for (let arg of args) {
        let indexValuePair = arg.split(" ");
        let index = indexValuePair[0];
        let value = indexValuePair[2];
        arr[index] = value;
    }

    for (let item of arr) {
        console.log(item);
    }
}