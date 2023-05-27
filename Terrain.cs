using PMU.Asset;
namespace PMU;

public partial class Terrain : Form
{
    Systeme objets; 
    private System.Windows.Forms.Timer timer; 
    public Terrain()
    {
        InitializeComponent();
        this.timer = new System.Windows.Forms.Timer();
        this.DoubleBuffered = true;
        this.timer = new System.Windows.Forms.Timer();
        this.timer.Interval = 100;
        this.timer.Tick += Timer_Tick;
        this.timer.Start();
    }
    public void Area_paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        drawHorses(g);
        drawRéférentiel(g);
    }
    public void drawHorses(Graphics g){
        foreach(Horses h in objets.getChevaux()){
            g.DrawImage(h.getImage(), (int) h.getX(), (int) h.getY(), 40, 30);
        }
    }
    public void drawRéférentiel(Graphics g){
        g.FillEllipse(Brushes.White, 300, 300, 50, 50);
        g.FillEllipse(Brushes.White, 900, 300, 50, 50);
        foreach(Référentiel r in this.objets.getRéf()){    
            //g.FillEllipse(Brushes.White, (int) r.getX(), (int) r.getY(), 50, 50);
           g.DrawString(r.getDirection() + "", new Font("Arial", 12), Brushes.Black, (int) r.getX(), (int) r.getY());
        }
    }
    public void setObjets(Systeme objets){
        if(objets == null){ throw new Exception("Système non trouvé"); }
        this.objets = objets;
    }
    protected void Timer_Tick(object sender, EventArgs e) {
        foreach(Horses h in this.objets.getChevaux()){
            h.Déplacement(this.objets.getRéf());
            h.Direction();
        }
        Refresh();
    }
    public Systeme getObjets(){ return this.objets; }
}

