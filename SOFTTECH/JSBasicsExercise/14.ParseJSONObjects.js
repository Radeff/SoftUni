function solve(args) {
    let students = [];
    args.forEach(arg => {
        let student = JSON.parse(arg);
        students.push(student);
    });

    students.forEach(student => {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Date: ${student.date}`);
    });
}