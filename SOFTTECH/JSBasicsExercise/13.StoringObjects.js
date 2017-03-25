function solve(args) {
    let students = [];
    for (let arg of args) {
        let stats = arg.split(" -> ");
        let student = {
            name: stats[0],
            age: Number(stats[1]),
            grade: Number(stats[2])
        };

        students.push(student);
    }

    students.forEach(student => {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade.toFixed(2)}`);
        });
}