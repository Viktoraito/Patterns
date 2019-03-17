package patterns;

import java.util.Enumeration;
import java.util.Hashtable;

/**
 *
 * @author M. Kofman
 */
public class Body implements PropertyContainer {
    protected Hashtable Properties = new Hashtable(2);
    
    @Override    
    public void addPropertyBy(String token, Object value) {
        if(value==null || token==null) return;
        if(Properties.containsKey(token))
            Properties.remove(token);
        Properties.put(token, value);
    }
    
    @Override
    public void removeProperty(String token) {
        if(token==null) return;
        Properties.remove(token);
    }
    
    @Override
    public Object getPropertyBy(String token) {
        if(token==null) return null;
        return Properties.get(token);
    }
    
    @Override
    public String[] getPropertyKeys() {
        String keys[] = null;
        synchronized(Properties) {
            int s = Properties.size();
            keys = new String[s];
            Enumeration e = Properties.keys();
            int i = 0;
            while(e.hasMoreElements()) {
                keys[i] = (String)e.nextElement();
                i++;
            }
        }
        return keys;
    }
    
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
     */    
    public Body(String name, double mass, Coord coord, 
                       double radius){
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
        for(String s : this.getPropertyKeys()) {
            System.out.println(s+": "+this.getPropertyBy(s));
        }
    }
    
    protected class BodyMassException  extends Exception{
        public BodyMassException(String message) {
            super(message);
        }
    }
}