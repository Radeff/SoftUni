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

            for (let elem of arr[key]) {
                console.log(elem);
            }

            break;
        }
        if (arr[key]) {
            arr[key].push(value);
        } else {
            arr[key] = [value];
        }
    }
}