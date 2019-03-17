package patterns;

/**
 *
 * @author M. Kofman
 */
public class GiantPlanet extends Body{
    protected double PAM;//Primary atmosphere mass
    
    /**
     * @param name Planet name
     * @param mass Planet mass (7M[Earth]<=mass<12M[Jupiter])
     * @param coord Space coordinates
     * @param radius Planet radius
     * @param PAM Primary atmosphere mass
     * @throws patterns.Body.BodyMassException 
     */
    public GiantPlanet(String name, double mass, Coord coord, 
                       double radius, double PAM) throws BodyMassException {
        super(name, mass, coord, radius, PAM);
        if(mass >= 13*JM) throw new 
        BodyMassException("Mass should be lesser than 13*M[Jupiter]");
        if(mass <7*EM) throw new 
        BodyMassException("Mass should be greater than 7*M[Earth]");
        this.PAM=PAM;
    }

    @Override
    public void PrintProperties() {
        super.PrintProperties();
        System.out.print("Primary atmosphere mass: "+PAM+'\n');
    }
}
