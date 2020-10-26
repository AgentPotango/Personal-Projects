/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package my.ibmsdrh;

import java.util.ArrayList;

/**
 *
 * @author mbax2sb3
 */
public class Duty {
    public ArrayList<Service> services;
    public Break dutyBreak;
    public Bus bus1, bus2;
    
    public Duty() {
        services = new ArrayList<>();
        dutyBreak = null;
        bus1 = null;
        bus2 = null;
    }
    
    public void addBus1(Bus bus){
        bus1 = bus;
    }
    
    public void addBus2(Bus bus){
        bus2 = bus;
    }
    
    public void addService(Service service){
        services.add(service);
    }
    
    public ArrayList<Service> getServices(){
        return services;
    }
    
    public void addBreak(Break dutyBreak){
        this.dutyBreak = dutyBreak;
    }
    
    public Break getBreak(){
        return dutyBreak;
    }
}
