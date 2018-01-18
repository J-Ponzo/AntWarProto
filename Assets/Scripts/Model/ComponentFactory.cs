using System;

public class ComponentFactory {

    public static AgentComponent CreateComponent(int id)
    {
        AgentComponent component = new AgentComponent();
        return component;
    }
}
