package patterns;

/**
 *
 * @author M. Kofman
 */
public class BlackHole extends Body{
    
    public BlackHole(String name, double mass, Coord coord, 
                double radius, double ElC) throws BodyMassException {
        super(name, mass, coord, radius);
        if(mass <10*SM) throw new 
        BodyMassException("Mass should be greater than 10*M[Sun]");
    }
}
