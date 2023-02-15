class Car{
    public string model;
    public Car(){
        model = "2020";
    }
}

class BB{
    Car ford = new Car();

}

// EXAMPLE 2

class MyCar{
    private string model;
    private int num;
    public MyCar(string Name, int Number){
        model = Name;
        num = Number;
    }
}

class C{
    MyCar mC = new MyCar("Car name", 2022);
}