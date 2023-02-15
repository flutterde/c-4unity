// private
// protected
// public

/*
*  EXAMPLE
*/

class AA{
    private int x =5;
    public int getX(){
        return x;
    }
}

class BB{

    AA a = new AA();
    private void Start() {
        a.getX();
    }
}