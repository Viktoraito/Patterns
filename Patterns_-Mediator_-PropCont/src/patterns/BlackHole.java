package patterns;

/**
 *
 * @author M. Kofman
 */
public class BlackHole extends Body{
    protected double ElC; //Electric Charge
    
    public BlackHole(String name, double mass, Coord coord, 
                double radius, double ElC) throws BodyMassException {
        super(name, mass, coord, radius, ElC);
        if(mass <10*SM) throw new 
        BodyMassException("Mass should be greater than 10*M[Sun]");
        this.ElC=ElC;
    }
    
    @Override
    public void PrintProperties() {
        super.PrintProperties();
        System.out.print("Electric Charge: "+ElC+'\n');
    }
}
