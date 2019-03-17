package patterns;

import java.util.ArrayList;
import java.util.List;
/**
 *
 * @author M. Kofman
 */
public class GravityMediator implements Mediator {
    
    private List<Body> bodies;
    
    public GravityMediator(){
        this.bodies=new ArrayList<>();
    }

    @Override
    public void Calculate(Body body) {
        for(Body b : this.bodies){
			if(b != body){
System.out.println("!"+b.getName()+
" G*"+body.getMass()*b.getMass()/Coord.distance(body.getCoord(), b.getCoord()));
			}
		}
    }

    @Override
    public void addBody(Body body) {
        this.bodies.add(body);
    }
    
}