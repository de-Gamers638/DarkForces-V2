using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace Client.Utils
{ 
     public class Timer 
     {
          private int currentTick = 0;     
          
          public static void Reset()
          {
              currentTick = 0;
          }
          
          public static void timerHasReached(int value, bool reset)
          {
              if (currentTick == value)
              {
                  
                  if (reset)
                  {
                     reset();
                  }
                  return true;
              }
              else
              {
                  return false;
              
              }     
          }
    }   
}
