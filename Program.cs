using PMU.Asset;
namespace PMU;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        List<Horses> chevals = new List<Horses>();
        Horses c1 = new Horses(300, 500, 102, 300, "32477.png");
        Horses c2 = new Horses(300, 500, 100, 300, "32477.png");
        Horses c3 = new Horses(300, 500, 104, 300, "32477.png");
        Horses c4 = new Horses(300, 500, 107, 300, "32477.png");
        chevals.Add(c1);
        chevals.Add(c2);
        chevals.Add(c3);
        chevals.Add(c4);
        
        Systeme sys = new Systeme(chevals);

        Terrain terrain = new Terrain();
        terrain.setObjets(sys);
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
      //  ApplicationConfiguration.Initialize();
        Application.Run(terrain);
    }    
}