namespace PMU.Asset;
/// <summary>
/// Summary description for Systeme
/// </summary>
public class Systeme
{
	List<Horses> chevaux ;
 	List<Référentiel> listeréf;
	
	public Systeme(List<Horses> horses)
	{
		List<Référentiel> réfs = new List<Référentiel>();
		Référentiel référentiel1 = new Référentiel(300, 500, -1);
		Référentiel référentiel2 = new Référentiel(300, 100, 1);
		Référentiel référentiel3 = new Référentiel(900, 100, -2);
		Référentiel référentiel4 = new Référentiel(900, 500, 2);
		réfs.Add(référentiel1);
		réfs.Add(référentiel2);
		réfs.Add(référentiel3);
		réfs.Add(référentiel4);
		this.setRéf(réfs);
		this.setChevaux(horses);
	}
	
	public Systeme(){}
	public void setChevaux(List<Horses> chevaux){ this.chevaux = chevaux; }
	public List<Horses> getChevaux(){ return this.chevaux; }
	public void setRéf(List<Référentiel> refs){ this.listeréf = refs; }
	public List<Référentiel> getRéf(){ return this.listeréf; }
}
