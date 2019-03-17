package patterns;

/**
 *
 * @author M. Kofman
 */
public class DwarfPlanet extends Body{
            
    /**
     * @param name Planet name
     * @param mass Planet mass (mass<0.1M[Earth])
     * @param coord Space coordinates
     * @param radius Planet radius
     * @throws patterns.Body.BodyMassException 
     */
    
    public DwarfPlanet(String name, double mass, Coord coord, 
                       double radius) throws BodyMassException {
        super(name, mass, coord, radius);
        if(mass>=0.1*EM) throw new 
        BodyMassException("Mass should be lesser than 0.1*M[Earth]");
    }
}
