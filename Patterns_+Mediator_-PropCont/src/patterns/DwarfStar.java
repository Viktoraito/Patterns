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
     * @param IrL Infrared Luminosity
     * @throws patterns.Body.BodyMassException 
     */
    public DwarfStar(String name, double mass, Coord coord, 
                       double radius, double IrL) throws BodyMassException {
        super(name, mass, coord, radius, IrL);
        if(mass >= 0.08*SM) throw new 
        BodyMassException("Mass should be lesser than 0.08*M[Sun]");
        if(mass <3*JM) throw new 
        BodyMassException("Mass should be greater than 13*M[Jupiter]");
        this.IrL=IrL;
    }

    @Override
    public void PrintProperties() {
        super.PrintProperties();
        System.out.print("Infrared Luminosity: "+IrL+'\n');
    }
}
