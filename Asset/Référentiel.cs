namespace PMU.Asset;

public class Référentiel
{
    public Référentiel(double x, double y, int direction){
        this.setDirection(direction);
        this.setX(x);
        this.setY(y);
    }
    public Référentiel(){}
    private int direction;
    private double x;
    private double y;
    public int getDirection(){ return this.direction; }
    public void setDirection(int direction){ this.direction = direction; }
    public void setX(double x) { this.x = x; }
    public void setY(double y) { this.y = y; }
    public double getX() { return this.x; }
    public double getY() { return this.y; }
}