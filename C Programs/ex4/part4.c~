#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <float.h>

float c2f (float c);
float f2c (float f);

int main(int argc, char *argv[])
{
  if (argc != 3)
  {
    printf("Please enter a type (-c or -f) and a floating point number\n");
    exit(-1);
  }
  
  char *temperatureType = argv[1];
  float temperature;
  float conversion;
  sscanf(argv[2],"%f", &temperature);
   
  
  if (strcmp(temperatureType, "-c") != 0  && strcmp(temperatureType, "-f") != 0)
  {
    printf("Please enter a type (either -c or -f)\n");
    exit(-1);
  }
  
  if (temperature > FLT_MAX)
  {
    printf("The number you have entered is too large for a float\n");
    printf("Please enter a smaller number\n");
    exit(-1);
  } 
  else if ((strcmp(temperatureType, "-f") == 0 && temperature < -273.15)
           || (strcmp(temperatureType, "-c") == 0 && temperature < -169.53))
  {
    printf("The number you have entered is below freezing\n");
    printf("Please enter a larger number\n");
    exit(-1);
  }
    
  if (strcmp(temperatureType, "-c") == 0)
  {
    conversion = c2f(temperature);
    printf("%3.2f%cC == %3.2f%cF\n", temperature,176, conversion,176);
  }
  else if (strcmp(temperatureType, "-f") == 0)
  {
    conversion = f2c(temperature);
    printf("%3.2f%cC == %3.2f%cF\n", conversion,176, temperature,176);
  }
    
 
}

float c2f (float temp)
{
  return temp * 9/5 + 32;
}

float f2c(float temp)
{
  return (temp - 32) * 5/9;
}

