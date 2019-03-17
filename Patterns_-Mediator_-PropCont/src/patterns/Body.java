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
    
    public void CalculateGravity(Body b) {
        if(b != this){
            System.out.println("!"+b.getName()+
" G*"+this.getMass()*b.getMass()/Coord.distance(this.getCoord(), b.getCoord()));
			}
    }
    
    public void CalculateSignal(Body b) {
        double LightSpeed = 0.002; //AU per sec
	if(b != this){
            System.out.println("!"+b.getName()+
" will be reached in "+Coord.distance(this.getCoord(), b.getCoord())/LightSpeed+
" seconds");
		}
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