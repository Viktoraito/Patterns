package patterns;

/**
 *
 * @author M. Kofman
 */
public class Star extends Body{
    protected double SrL;//Solar Luminosity
    
    /**
     * @param name Star name
     * @param mass Star mass (0.08M[Sun]<=mass<10M[Sun])
     * @param coord Space coordinates
     * @param radius Star radius
     * @param SrL Solar Luminosity
     * @throws patterns.Body.BodyMassException 
     */
    public Star(String name, double mass, Coord coord, 
                double radius, double SrL) throws BodyMassException {
        super(name, mass, coord, radius, SrL);
        if(mass >= 10*SM) throw new 
        BodyMassException("Mass should be lesser than 10*M[Sun]");
        if(mass <0.08*SM) throw new 
        BodyMassException("Mass should be greater than 0.08*M[Sun]");
        this.SrL=SrL;
    }

    @Override
    public void PrintProperties() {
        super.PrintProperties();
        System.out.print("Solar Luminosity: "+SrL+'\n');
    }
}
