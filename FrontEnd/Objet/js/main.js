import User , {age}from "./User.js"
import TotalSalary from "./Salary.js";

let user1 = new User("FirstUser",1990, 1500);

//user1.TotalSalary(user1.salary);
console.log(` your age is ${age(user1.YearOfBirth)}, your salary is ${ TotalSalary(user1.salary)}`);