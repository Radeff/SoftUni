function solve(args) {
    let student = {};
    args.forEach(arg => {
        let data = arg.split(" -> ");
        let key = data[0];
        let value = data[1];
        if (key === "age" || key === "grade") {
            value = Number(value);
        }

        student[key] = value;
    });
    console.log(JSON.stringify(student));
}