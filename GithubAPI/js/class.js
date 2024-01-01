class user{
    constructor(name,spliciztion){
        this.name = name;
        this.spliciztion =spliciztion;
    }
    getinfo(){
        console.log(`welcome ${this.name} ${this.spliciztion}`);
    }
}
let User1 = new user("azza","IT");
User1.getinfo();

class Employee extends user {
    constructor(name,salary){
        super(name);
        this.salary = salary;
    }
    print(){
        console.log(`${this.name} salary ${this.salary}`)
    }
}
let emp = new Employee();
emp.name="Moh";
emp.salary=55;
emp.print();