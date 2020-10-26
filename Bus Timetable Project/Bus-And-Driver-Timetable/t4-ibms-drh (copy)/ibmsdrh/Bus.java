/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package my.ibmsdrh;

import java.util.ArrayList;
import java.util.Collection;
import java.util.HashMap;
import java.util.Date;

/**
 *
 * @author mbax2sb3
 */
public class Bus implements Comparable<Bus>{
    int busID;
    String busNumber;
    HashMap<Date, Integer> availability;
    int usage;
    
    public Bus(int busID, String busNumber){
        this.busID = busID;
        this.busNumber = busNumber;
        availability = new HashMap<>();
        usage = 0;
    }
    
    public int getUsage(){
        return usage;
    }
    
    public void addUsage(int amount){
        usage += amount;
    }
    
    public int getAvailability(Date date){
        Integer available = availability.get(date);
        if(available == null)
            return 0;
        else
            return available;
    }
    
    public void setAvailability(Date date, int available){
        availability.remove(date);
        availability.put(date, available);
    }
    
    @Override
    public int compareTo(Bus other){
        return this.getUsage() - other.getUsage();
    }
    
    @Override
    public String toString(){
        String str = "";
        str += "Bus ID: " + busID + "\n";
        str += "Bus number: " + busNumber;
        return str;
    }
    
    public static ArrayList<Bus> readBuses(){
        ArrayList<Bus> buses = new ArrayList<>();
        int busIDs[];
        String busNo;
        
        busIDs = BusInfo.getBuses();
        for(int b : busIDs){
            busNo = BusInfo.busNumber(b);
            buses.add(new Bus(b, busNo));
        }
        
        return buses;
    }
}
