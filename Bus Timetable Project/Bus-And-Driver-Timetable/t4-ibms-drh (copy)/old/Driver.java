/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package my.ibmsdrh;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Collections;
import java.util.Date;

/**
 *
 * @author mbax2sb3
 */
public class Driver implements Comparable<Driver>{ 
    public int id;
    public String number;
    public String name;
    public HashMap<Date, Duty> duties;
    public Break lastBreak;
    
    public Driver(int id) {
        this.id = id;
        this.number = DriverInfo.getNumber(id);
        this.name = DriverInfo.getName(id);
        duties = new HashMap<>();
        lastBreak = null;
    }
    
 
    public void addService(Date date, Service service){
        Duty duty = duties.get(date);
        if(duty == null){
            duty = new Duty();
            duties.put(date, duty);
        }
        duty.addService(service);
    }
    
    public ArrayList<Service> getServices(Date date){
        Duty duty = duties.get(date);
        ArrayList<Service> services = null;
        if(duty != null)
            services = duty.getServices();
        return services;
        
    }
    
    public Duty getDuty(Date date){
        return duties.get(date);
    }
    
    public void addBreak(Date date, Break newBreak){
        Duty duty = duties.get(date);
        duty.addBreak(newBreak);
    }
    
    public Break getBreak(Date date){
        Duty duty = duties.get(date);
        return duty.getBreak();
    }
    
    public int getHoursThisWeek(){
        return DriverInfo.getHoursThisWeek(id);
    }
    
    public void setHoursThisWeek(int hours){
        DriverInfo.setHoursThisWeek(id, hours);
    }
    
    public void addHoursThisWeek(int hours){
        int soFar = getHoursThisWeek();
        setHoursThisWeek(soFar + hours);
    }
    
    public void clearHoursThisWeek(){
        DriverInfo.setHoursThisWeek(id, 0);
    }
    
    @Override
    public int compareTo(Driver other){
        return this.getHoursThisWeek() - other.getHoursThisWeek();
    }
    
    @Override
    public String toString(){
        String str = "";
        
        str += "Driver ID: " + id + "\n";
        str += "Driver number: " + number + "\n";
        str += "Driver name: " + name;
         
        return str;
    }
    
    public static ArrayList<Driver> readDrivers() {
        ArrayList<Driver> drivers = new ArrayList<>();
        int[] driverIDs = DriverInfo.getDrivers();
        
        for(int id : driverIDs){
            drivers.add(new Driver(id));
        }
        
        return drivers;
    }
}
