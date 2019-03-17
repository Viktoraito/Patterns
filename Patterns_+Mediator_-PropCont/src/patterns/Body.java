package patterns;

/**
 *
 * @author M. Kofman
 */
public abstract class Body {
    protected String name;
    protected double mass;
    protected Coord coord;
    protected double radius;
    public static final double EM = 6; //Earth Mass
    public static final double JM = 2000; //Jupiter Mass
    public static final double SM = 2000000; //Sun Mass
    
    /**
     * @param name Body name
     * @param mass Body mass
     * @param coord Space coordinates
     * @param radius Body radius
     * @param prop Property
     */
    public Body(String name, double mass, Coord coord, 
                       double radius, Object prop){
        this.name=name;
        this.mass=mass;
        this.coord=coord;
        this.radius=radius;
    }
    
    public void Calculate(Mediator mediator) {
        System.out.println(this.name+": calculating gravitation impact!");
        mediator.Calculate(this);
    }
    
    public double getMass() {
        return this.mass;
    }
    
    public Coord getCoord() {
        return this.coord;
    }
    
    public String getName() {
        return this.name;
    }
    
    public double getRadius() {
        return this.radius;
    }
    
    public void PrintProperties() {
        System.out.print("."+name+'\n'+
        "Type: "+this.getClass().getName().substring("patterns.".length())+'\n'+
        "Mass: "+mass+'\n'+
        "Coordinates: "+coord.getX()+"; "+coord.getY()+'\n');
    }
    
    protected class BodyMassException  extends Exception{
        public BodyMassException(String message) {
            super(message);
        }
    }
}