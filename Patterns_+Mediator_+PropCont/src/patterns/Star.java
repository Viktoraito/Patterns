package patterns;

/**
 *
 * @author M. Kofman
 */
public class Star extends Body{
    
    /**
     * @param name Star name
     * @param mass Star mass (0.08M[Sun]<=mass<10M[Sun])
     * @param coord Space coordinates
     * @param radius Star radius
     * @throws patterns.Body.BodyMassException 
     */
    public Star(String name, double mass, Coord coord, 
                double radius) throws BodyMassException {
        super(name, mass, coord, radius);
        if(mass >= 10*SM) throw new 
        BodyMassException("Mass should be lesser than 10*M[Sun]");
        if(mass <0.08*SM) throw new 
        BodyMassException("Mass should be greater than 0.08*M[Sun]");
    }
}
