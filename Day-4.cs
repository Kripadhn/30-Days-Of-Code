class Person {
    public int age;  
    //public Person(int initialAge);
    public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
        this.age=initialAge;
     }
    
    public void amIOld() {
        // Do some computations in here and print out the correct statement to the               console 
        if (age < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            this.age=0;
            amIOld();
        }
        else if(age< 13 && age >= 0)
        Console.WriteLine("You are young.");
        else if(age >= 13 && age <18)
        Console.WriteLine("You are a teenager.");
        else if(age >= 18)
        Console.WriteLine("You are old.");
     }

    public void yearPasses() {
         age=age+1;
        // Increment the age of the person in here

     }