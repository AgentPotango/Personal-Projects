package my.ibmsdrh;

import java.util.ArrayList;
import java.util.Date;

public class Service implements Comparable<Service>{
  public int routeNo;
  public int serviceNo;
  public int times[];
  public int duration;
  public int startTime;
  public int endTime;
  public int busID;

  public Service(int routeNo, int serviceNo, int times[]) {
    this.routeNo = routeNo;
    this.serviceNo = serviceNo;
    this.times = times;
    if(routeNo == 68){
        if(times[0] > times[times.length - 1])
            startTime = times[0] - (times[times.length - 1] + 1440 - times[0]);
        else
            startTime = times[0] - (times[times.length - 1] - times[0]);
    }
    else{
        this.startTime = times[0];
    }
    if(routeNo == 67){
        if(times[0] > times[times.length - 1])
            endTime = times[times.length -1] + (times[times.length - 1] + 1440 
                    - times[0]);
        else
            endTime = (times[times.length - 1] + (times[times.length - 1] 
                    - times[0])) % 1440;
    }
    else{
        this.endTime = times[times.length - 1];
    }
    if(startTime < endTime)
        this.duration = endTime - startTime;
    else
        this.duration = 1440 - startTime + endTime;
    this.busID = 0;
  }

  @Override
  public int compareTo(Service other){
    return this.startTime - other.startTime;
  }
  
  @Override
  public boolean equals(Object other){
      if(other == null)
          return false;
      
      Service service = (Service)other;
      return this.startTime == service.startTime;
  }

  @Override
  public String toString() {
    String str = "";
    str += "Service number: " + serviceNo + "\n";
    str += "Route number: " + routeNo + "\n";
    str += "Start time: " + startTime + "\n";
    str += "End time: " + endTime +"\n";
    str += "Duration: " + duration + "\n";
    
    return str;
  }

  public static ArrayList<Service> readServices(Date date) {
    ArrayList<Service> services = new ArrayList<>();
    int serviceIDs[];
    int times[];
    int routes[];
    int noServices;
    Service service;

    routes = BusStopInfo.getRoutes();
    for(int i=0; i<routes.length; i++) {
      serviceIDs = TimetableInfo.getServices(routes[i], TimetableInfo.timetableKind(date));
      noServices = serviceIDs.length;
      for(int j=0; j<noServices; j++) {
        times = TimetableInfo.getServiceTimes(routes[i], TimetableInfo.timetableKind(date), j);
        service = new Service(routes[i], serviceIDs[j], times);
        services.add(service);
      }
    }
    return services;
  }
}