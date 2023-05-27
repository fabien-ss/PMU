namespace PMU.Asset;

public class Horses{
    private Image image = null;
    //FIELDS
    private string nom = "cheval 1";
    private double speed = 2;
    private double endurance;
    private double x;
    private double y;
    int direction = 1;
    double angle = 90;

    int centreX = 300;
    int centreY = 300;
    public Horses(double x, double y, double speed, double endurance, string image){
        this.setSpeed(speed);
        this.setEndurance(endurance);
        this.setX(x);
        this.setY(y);
        this.setImage(image);
    }   
    public void setName(string name){
        this.nom = name;
    }
    public void setImage(string name){
        if(name == "" || name == null){ throw new Exception(this.nom + " no image"); };
        this.image = Image.FromFile("./Image/"+name);
    }
    public Image getImage(){ return this.image; }
    public string getNom(){ return this.nom; }
    //SETTERS & GETTERS
    public void setSpeed(double speed){ this.speed = speed; }
    public void setEndurance(double endurance){ this.endurance = endurance; }
    public void setX(double x){ this.x = x; }
    public void setY(double y){ this.y = y; }
    public double getX(){ return this.x; }
    public double getY(){ return this.y; }
    public double getSpeed(){ return this.speed;}
    public double getEndurance(){ return this.endurance; }
    //CONSTRUCTOR
    public void Déplacement(List<Référentiel> référentiels){
        foreach(Référentiel r in référentiels){
            this.setDirection(r);
        }
    }
    public void setDirection(Référentiel r){
        double x1 = this.x - r.getX();
        double y1 = this.y - r.getY();
        double distance = Math.Sqrt(x1 * x1 + y1 * y1);
     //   MessageBox.Show("d: "+distance);
        if(distance <= 5){
            this.direction = r.getDirection();
        } 
    }
    public void Direction(){
        double dt = 100.0 / 1000.0;;
        double distance = this.speed * dt;
        double rayon = 200;
            
        if(this.direction == 1){
         //   this.angle = -50;
            //this.centreX += -300;
            this.x += distance;
        }
        if(this.direction == 2){
         //   this.angle = -50;
            //this.centreX += -300;
            this.x += -distance;
           // this.centreX += 300;
           // this.angle = 90;
        }
        if(this.direction == -1 || this.direction == -2){
            double angularSpeed = this.speed / rayon;
            double mvtcirculaire = angularSpeed * dt * rayon;
            this.angle += angularSpeed * dt;
            if(this.direction == -1){
                this.x = 300 + (200) * Math.Cos(this.angle); 
                this.y = 300 + (200) * Math.Sin(this.angle);
            }
            if(this.direction == -2){
                this.x = 900 + (200) * Math.Cos(this.angle);
                this.y = 300 + (200) * Math.Sin(this.angle);
            }
        }
    }
//METHODS   
}