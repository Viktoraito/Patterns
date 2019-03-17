package patterns;

/**
 *
 * @author M. Kofman
 */
public class DwarfPlanet extends Body{
    
    protected double PsD; //Planetesimals Density
        
    /**
     * @param name Planet name
     * @param mass Planet mass (mass<0.1M[Earth])
     * @param coord Space coordinates
     * @param radius Planet radius
     * @param PsD Planetesimals Density
     * @throws patterns.Body.BodyMassException 
     */
    
    public DwarfPlanet(String name, double mass, Coord coord, 
                       double radius, double PsD) throws BodyMassException {
        super(name, mass, coord, radius, PsD);
        if(mass>=0.1*EM) throw new 
        BodyMassException("Mass should be lesser than 0.1*M[Earth]");
        this.PsD=PsD;
    }
    
    @Override
    public void PrintProperties() {
	super.PrintProperties();
        System.out.print("Planetesimals density: "+PsD+'\n');
    }
}
