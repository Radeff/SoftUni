function solve(args) {
    let arr = [];
    for (let arg of args) {
        let split = arg.split(" ");
        let command = split[0];
        let index = split[1];
        switch (command) {
            case "add":
                arr.push(index);
                break;
            case "remove":
                if (index >=0 && index < arg.length) {
                    arr.splice(index, 1);
                    arr = arr.filter(function(x){return x != null});
                    break;
                }
        }
    }
    for (let element of arr) {
        console.log(element);
    }
}