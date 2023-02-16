// OOP


// class child extend from class parent
 class Child : Parent{

 }

 // Overriding

 public class Square {
    public double x;
    public Square(double num){
        x = num;
    }

    public virtual double Area(){
        return x*x;
    }
 }

 class Cub{
    Square box = new Square(5);
 }


// 

public class Cube : Square{
    public Cube(double x) : base(x){
        
    }

    public override double Area()
    {
        return (6*(base.Area()));
    }
}
  


// abstract 

public abstract class Shape{
    public abstract int Areaa();
}

public class Square : Shape {
    int side;

    public override int Areaa()
    {
       return side * side;
    }
}

// Overload

