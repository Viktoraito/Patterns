package patterns;
import java.math.*;

/**
 *
 * @author M. Kofman
 */
class Coord {
    private double x;
    private double y;
    
    public Coord(double x, double y) {
        this.x=x;
        this.y=y;
    }
    
    public static double distance(Coord a, Coord b) {
        return Math.sqrt((b.x-a.x)*(b.x-a.x)+(b.y-a.y)*(b.y-a.y));
    }

    /**
     * @return the x
     */
    public double getX() {
        return x;
    }

    /**
     * @param x the x to set
     */
    public void setX(int x) {
        this.x = x;
    }

    /**
     * @return the y
     */
    public double getY() {
        return y;
    }

    /**
     * @param y the y to set
     */
    public void setY(int y) {
        this.y = y;
    }
    
    
}
