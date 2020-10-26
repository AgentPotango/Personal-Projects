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
    
    /*
     * Add a service to a duty
     */
    public void addService(Date date, Service service){
        Duty duty = duties.get(date);
        if(duty == null){
            duty = new Duty();
            duties.put(date, duty);
        }
        duty.addService(service);
    }
    
    /*
     * Get all services on a day
     */
    public ArrayList<Service> getServices(Date date){
        Duty duty = duties.get(date);
        ArrayList<Service> services = null;
        if(duty != null)
            services = duty.getServices();
        return services;
        
    }
    /*
     * Get all duties on a day
     */
    public Duty getDuty(Date date){
        return duties.get(date);
    }
    /*
     * Add a break to a driver for a given day
     */
    public void addBreak(Date date, Break newBreak){
        Duty duty = duties.get(date);
        duty.addBreak(newBreak);
    }
    /*
     * Get the break of a driver on a date
     */
    public Break getBreak(Date date){
        Duty duty = duties.get(date);
        return duty.getBreak();
    }
    /*
     * Get the number of hours worked this week by a driver
     */
    public int getHoursThisWeek(){
        return DriverInfo.getHoursThisWeek(id);
    }
    /*
     * Set the number of hours worked this week by a driver
     */
    public void setHoursThisWeek(int hours){
        DriverInfo.setHoursThisWeek(id, hours);
    }
    /*
     * Add howrs worked to a driver
     */
    public void addHoursThisWeek(int hours){
        int soFar = getHoursThisWeek();
        setHoursThisWeek(soFar + hours);
    }
    /*
     * Set all hours worked in a week to 0
     */
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
    /*
     * Get all the drivers in the database
     */
    public static ArrayList<Driver> readDrivers() {
        ArrayList<Driver> drivers = new ArrayList<>();
        int[] driverIDs = DriverInfo.getDrivers();
        
        for(int id : driverIDs){
            drivers.add(new Driver(id));
        }
        
        return drivers;
    }
}
