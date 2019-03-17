package patterns;

/**
 *
 * @author m.kofman
 */
public interface PropertyContainer {
    void addPropertyBy(String token, Object value);
    void removeProperty(String token);
    Object getPropertyBy(String token);
    String[] getPropertyKeys();
}
