package my.ibmsdrh;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class Roster{
    public static String str = "";
  /**
  * @param args the command line arguments
  */
  public static void main() {
    Calendar cal = new GregorianCalendar();
    Date date;
    ArrayList<Service> services;
    ArrayList<Driver> drivers, used, unused;
    ArrayList<Bus> buses;
    Service service;

    database.openBusDatabase();
    
    unused = Driver.readDrivers();
    used = new ArrayList<>();
    
    buses = Bus.readBuses();
    
    for(Driver d : unused){
        d.clearHoursThisWeek();
    }
    
    for(int i=1; i<=7; i++){
        date = cal.getTime();
        
        Collections.sort(unused);
        Collections.sort(used);
        drivers = new ArrayList<>(used);
        drivers.addAll(unused);
        
        services = Service.readServices(date);
        Collections.sort(services);
        
        Collections.sort(buses);
        
        while (!services.isEmpty()) {
            service = services.get(0);
            for (Driver driver : drivers) {
                if (addService(date, driver, service)) {
                    //driver.addHoursThisWeek(service.duration);
                    break;
                }
            }
            services.remove(service);
        }
        
        str += "--------------" + date + "--------------\n\n\n";

        for (Driver driver : drivers) {
            Duty duty = driver.getDuty(date);
            ArrayList<Service> ser;
            str += driver;
            str += "\nServices: ";
            if (duty == null) {
                ser = new ArrayList<Service>();
            } 
            else {
                ser = duty.getServices();
                int startTime = ser.get(0).startTime;
                int endTime = ser.get(ser.size() - 1).endTime;
                Break dutyBreak = duty.getBreak();
                
                if(startTime > endTime)
                    endTime += 1440;
                
                int duration = endTime - startTime;
                
                if(dutyBreak != null)
                    duration -= (dutyBreak.end - dutyBreak.start);
                
                driver.addHoursThisWeek(duration);
                
                if(!used.contains(driver)){
                    used.add(driver);
                    unused.remove(driver);
                }
                
                if(dutyBreak == null){
                    for(Bus b : buses)
                        if(b.getAvailability(date) < ser.get(0).startTime){
                            for(Service s : ser){
                                s.busID = b.busID;
                                b.addUsage(s.duration);
                            }
                            b.setAvailability(date, ser.get(ser.size()-1).endTime);
                            break;
                        }
                }
                else{
                    for(Bus b : buses)
                        if(b.getAvailability(date) < ser.get(0).startTime){
                            for(Service s : ser)
                                if(s.endTime <= dutyBreak.start){
                                    s.busID = b.busID;
                                    b.addUsage(s.duration);
                                }
                            b.setAvailability(date, dutyBreak.start);
                            break;
                        }
                    for(Bus b : buses)
                        if(b.getAvailability(date) < dutyBreak.end){
                            for(Service s : ser)
                                if(s.startTime > dutyBreak.start){
                                    s.busID = b.busID;
                                    b.addUsage(s.duration);
                                }
                            Service lastService = ser.get(ser.size() - 1); 
                            if(lastService.startTime > lastService.endTime)
                                b.setAvailability(date, lastService.endTime + 1440);
                            else
                                b.setAvailability(date, lastService.endTime);
                            break;
                        }
                }
            }
            for (Service s : ser) {
               str += ("" + s.serviceNo + "(" + s.startTime
                        + "-" + s.endTime + ")(" + s.busID + ") ");
            }
            str += "\n===========================================\n";
        }
        
        cal.add(Calendar.DAY_OF_YEAR, 1);
    }
  }
  
  public static boolean addService(Date date, Driver driver, Service service){
      Duty duty = driver.getDuty(date);
      Service lastService;
      Break lastBreak;
      int startTime = service.startTime;
      int endTime;
      int lastEndTime;
      
      /* Check if shift is empty */
      if(duty == null){
          driver.addService(date, service);
          return true;
      }
      
      ArrayList<Service> services = duty.getServices();
      
      /* Check if service is after last service in shift */
      lastService = services.get(services.size() - 1);
      if(lastService.startTime > lastService.endTime)
          lastEndTime = lastService.endTime + 1440;
      else
          lastEndTime = lastService.endTime;
      
      if(lastEndTime > service.startTime){
          return false;
      }
      
      /* Check if service requires break */
      if(service.startTime > service.endTime)
          endTime = service.endTime + 1440;
      else
          endTime = service.endTime;
      
      /* If working for more than 5 hours */
      if(endTime - services.get(0).startTime > 300){
          lastBreak = duty.getBreak();
          if(lastBreak == null){
              if(lastEndTime + 60 > startTime)
                  return false;
              lastBreak = new Break(lastEndTime, startTime);
              driver.addBreak(date, lastBreak);
              driver.addService(date, service);
              return true;
          }
          else {
              if(lastBreak.end + 300 < endTime)
                  return false;
              if(lastEndTime + 60 < startTime)
                  return false;
              driver.addService(date, service);
              return true;
          }
      }
      else {
          if (lastEndTime + 60 < startTime){
              driver.addBreak(date, new Break(lastEndTime, startTime));
          }
      }
      
      driver.addService(date, service);
      return true;
  }
}
