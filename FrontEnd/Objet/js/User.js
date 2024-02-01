export default class User{
    constructor(name,YearOfBirth ,salary){
        this.name = name;
        this.YearOfBirth = YearOfBirth ;
        this.salary =salary;
    }
}
       export function age(YearOfBirth){
         let Age = 2024 - YearOfBirth ;
         return Age;
    }

