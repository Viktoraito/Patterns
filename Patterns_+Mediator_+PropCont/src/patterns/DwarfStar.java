package patterns;

/**
 *
 * @author M. Kofman
 */
public class DwarfStar extends Body{
    protected double IrL;//Infrared Luminosity
    
    /**
     * Dwarf Star constructor
     * 
     * @param name Star name
     * @param mass Star mass (3M[Jupiter]<=mass<0.08M[Sun])
     * @param coord Space coordinates
     * @param radius Star radius
     * @throws patterns.Body.BodyMassException 
     */
    public DwarfStar(String name, double mass, Coord coord, 
                       double radius) throws BodyMassException {
        super(name, mass, coord, radius);
        if(mass >= 0.08*SM) throw new 
        BodyMassException("Mass should be lesser than 0.08*M[Sun]");
        if(mass <3*JM) throw new 
        BodyMassException("Mass should be greater than 13*M[Jupiter]");
    }
}
