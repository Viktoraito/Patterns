package patterns;

/**
 *
 * @author M. Kofman
 */
public class Patterns {

    public static void main(String[] args) throws Body.BodyMassException {
       Star Sun = 
            new Star("Sun",Body.SM,new Coord(0,0),696342,3.75);
       GiantPlanet Jupiter =
            new GiantPlanet("Jupiter",Body.JM,new Coord(9.5,0),69911,1.65);
       TerrestialPlanet Earth =
            new TerrestialPlanet("Earth",Body.EM,new Coord(1,0),6371,5.15);
       DwarfPlanet Pluto = 
            new DwarfPlanet("Pluto",0.0022*Body.EM,new Coord(39.5,0),1186,0.3);
       DwarfStar M1207 =
            new DwarfStar("2M1207",0.025*Body.SM,new Coord(0,173*63241),24322,0.015);
       Sun.PrintProperties();
       Jupiter.PrintProperties();
       Earth.PrintProperties();
       Pluto.PrintProperties();
       Earth.CalculateGravity(Sun);
       Earth.CalculateGravity(Jupiter);
       Earth.CalculateGravity(Pluto);
       Sun.CalculateGravity(Jupiter);
       Sun.CalculateGravity(Earth);
       Sun.CalculateGravity(Pluto);
       Sun.CalculateSignal(Earth);
       Sun.CalculateSignal(Jupiter);
       Sun.CalculateSignal(M1207);
    }
    
}
