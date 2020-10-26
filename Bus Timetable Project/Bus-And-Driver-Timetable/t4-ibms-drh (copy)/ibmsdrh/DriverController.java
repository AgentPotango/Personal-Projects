package my.ibmsdrh;

import java.util.Date;
import java.util.ArrayList;

public class DriverController {

  // This class is not to be instantiated
  private DriverController() {
  }
  
  /**
   * Find the driver with the specified driver number
   */
  public static int findDriver(String number)
  {
    return DriverInfo.findDriver(number);
  }
  
  /**
   * Get the number of holidays a driver has left
   */
  public static int getHolidaysLeft(int driver) {
    return 25 - DriverInfo.getHolidaysTaken(driver);
  }
  
  /**
   * Determine whether the driver has enough holidays left for the requested
   * dates
   */
  public static boolean hasHolidaysLeft(int driver, Date start, Date end) {
    int holidaysLeft = getHolidaysLeft(driver);
    int holidaysRequired = 0;
    Date current = (Date)start.clone();
    
    while(current.compareTo(end) <= 0) {
        if(DriverInfo.isAvailable(driver, current)) {
            holidaysRequired++;
        }
        current.setDate(current.getDate() + 1);
    }
    
    return (holidaysLeft >= holidaysRequired);
  }

  /**
   * Get the number of drivers that have requested a holiday for a specified
   * date
   */
  public static int driversOnHoliday(Date date) {
    int onHoliday = 0;
    int[] driverIDs = DriverInfo.getDrivers();

    for(int id : driverIDs) {
      if(!DriverInfo.isAvailable(id, date)) {
        onHoliday++;
      }
    }

    return onHoliday;
  }

  /** 
   * Return the unavailable dates from the specified holiday period
   */
  public static ArrayList<Date> getUnavailableDates(Date start, Date end) {
    ArrayList<Date> unavailableDates = new ArrayList<Date>();
    Date current = (Date)start.clone();

    while(current.compareTo(end) <= 0) {
      if(driversOnHoliday(current) >= 10) {
        unavailableDates.add((Date)current.clone());
      }
      
      current.setDate(current.getDate() + 1);
    }

    return unavailableDates;
  }
  
  /**
   * Puts the driver on holiday for the specified period of time
   */
  public static void setOnHoliday(int driver, Date start, Date end) {
      Date current = (Date)start.clone();
      
      while(current.compareTo(end) <= 0) {
          if(DriverInfo.isAvailable(driver, current)) {
            DriverInfo.setAvailable(driver, current, false);         
            DriverInfo.setHolidaysTaken(driver, DriverInfo.getHolidaysTaken(driver) + 1);
          }

          current.setDate(current.getDate() + 1);
      }
  }

  
}
