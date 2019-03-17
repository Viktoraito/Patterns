package patterns;

/**
 *
 * @author M. Kofman
 */
public class TerrestialPlanet extends Body{
    
    
    /**
     * @param name Planet name
     * @param mass Planet mass (0.1[Earth]<=mass<7M[Earth])
     * @param coord Space coordinates
     * @param radius Planet radius
     * @throws patterns.Body.BodyMassException 
     */
    public TerrestialPlanet(String name, double mass, Coord coord, 
                       double radius) throws BodyMassException {
        super(name, mass, coord, radius);
        if(mass >= 7*EM) throw new 
        BodyMassException("Mass should be lesser than 5*M[Earth]");
        if(mass <0.1*EM) throw new 
        BodyMassException("Mass should be greater than 0.1*M[Earth]");
    }
}
