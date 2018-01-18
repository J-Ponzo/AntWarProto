using System;

public class ComponentFactory {

    public static CastComponent CreateComponent(int id)
    {
        CastComponent component = new CastComponent();
        return component;
    }
}
