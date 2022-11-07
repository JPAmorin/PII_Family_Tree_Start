namespace Library;

class Person
{
    public string name {get; private set;}
    
    public int edad {get; private set;}
    public Person(string name, int edad)
    {
        this.name = name;
        this.edad = edad;

    }
}