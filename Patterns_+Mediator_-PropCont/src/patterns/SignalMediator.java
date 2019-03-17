package patterns;

import java.util.ArrayList;
import java.util.List;
/**
 *
 * @author M. Kofman
 */

public class SignalMediator implements Mediator {

public static final double LightSpeed = 0.002; //AU per sec
    
    private List<Body> bodies;
    
    public SignalMediator(){
        this.bodies=new ArrayList<>();
    }

    @Override
    public void Calculate(Body body) {
        for(Body b : this.bodies){
			if(b != body){
System.out.println("!"+b.getName()+
" will be reached in "+Coord.distance(body.getCoord(), b.getCoord())/LightSpeed+
" seconds");
			}
		}
    }

    @Override
    public void addBody(Body body) {
        this.bodies.add(body);
    }
    
}