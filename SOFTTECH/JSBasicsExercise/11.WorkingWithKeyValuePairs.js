function solve(args) {
    arr = [];
    for (let arg of args) {
        let keyValue = arg.split(" ");
        let key = keyValue[0];
        let value = keyValue[1];

        if (value == undefined) {
            if (arr[key] == null) {
                console.log("None");
                break;
            }

            console.log(arr[key]);
            break;
        }

        arr[key] = value;
    }
}

solve([
    "3 test",
    "3 test1",
    "4 test2",
    "4 test3",
    "4 test5",
    "4"

]);