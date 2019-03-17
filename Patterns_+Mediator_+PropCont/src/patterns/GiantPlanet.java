package patterns;

/**
 *
 * @author M. Kofman
 */
public class GiantPlanet extends Body{
    
    /**
     * @param name Planet name
     * @param mass Planet mass (7M[Earth]<=mass<12M[Jupiter])
     * @param coord Space coordinates
     * @param radius Planet radius
     * @throws patterns.Body.BodyMassException 
     */
    public GiantPlanet(String name, double mass, Coord coord, 
                       double radius) throws BodyMassException {
        super(name, mass, coord, radius);
        if(mass >= 13*JM) throw new 
        BodyMassException("Mass should be lesser than 13*M[Jupiter]");
        if(mass <7*EM) throw new 
        BodyMassException("Mass should be greater than 7*M[Earth]");
    }
}
