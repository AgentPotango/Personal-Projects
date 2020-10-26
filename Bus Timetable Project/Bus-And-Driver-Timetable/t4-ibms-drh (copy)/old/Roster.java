package my.ibmsdrh;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class Roster{

  /**
  * @param args the command line arguments
  */
  public static void main(String[] args) {
    Calendar cal = new GregorianCalendar();
    Date date;
    ArrayList<Service> services;
    ArrayList<Driver> drivers, used, unused;
    Service service;

    database.openBusDatabase();
    
    unused = Driver.readDrivers();
    used = new ArrayList<>();
    
    for(Driver d : unused){
        d.clearHoursThisWeek();
    }
    
    for(int i=1; i<=7; i++){
        date = cal.getTime();
        
        Collections.sort(unused);
        Collections.sort(used);
        
        //
        drivers = new ArrayList<>(used);
        drivers.addAll(unused);
        
        //stores services for that date
        services = Service.readServices(date);
        
        //sort by start time
        Collections.sort(services);
        
        //while there are services left
        while (!services.isEmpty()) {
            //Get the fist element of the array list
            service = services.get(0);
            //for each driver in drivers
            for (Driver driver : drivers) {
                if (addService(date, driver, service)) {
                    driver.addHoursThisWeek(service.duration);
                    break;
                }
            }
            services.remove(service);
        }
        
        System.out.println("--------------" + date + "--------------");
        System.out.println();
        System.out.println();

        for (Driver driver : drivers) {
            Duty duty = driver.getDuty(date);
            ArrayList<Service> ser;
            System.out.println(driver);
            System.out.print("Services: ");
            if (duty == null) {
                ser = new ArrayList<Service>();
            } else {
                ser = duty.getServices();
                if(!used.contains(driver)){
                    used.add(driver);
                    unused.remove(driver);
                }
                
            }
            for (Service s : ser) {
                System.out.print("" + s.serviceNo + "(" + s.startTime
                        + "-" + s.endTime + ") ");
            }
            System.out.println("\n===========================================");
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
