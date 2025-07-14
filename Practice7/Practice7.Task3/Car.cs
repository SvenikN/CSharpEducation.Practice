using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task3
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }

    public Car(string make, string model)
    {
      Make = make;
      Model = model;
    }
  }
}
