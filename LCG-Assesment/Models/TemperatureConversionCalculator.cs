using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCG_Assesment.Models
{
    public class TemperatureConversionCalculator
    {
        public double Temperature { get; set; }
        public double Result { get; set; }
        public string SelectedOperation { get; set; }
       public List<SelectListItem> PossibleOperations { get; set; }

        public TemperatureConversionCalculator()
        {
            PossibleOperations = new List<SelectListItem>();
            PossibleOperations.Add(new SelectListItem { Text = "Celsius to Fahrenheit", Value = "1", Selected = true });
            PossibleOperations.Add(new SelectListItem { Text = "Fahrenheit to Celcius", Value = "2" });
        }

        public void ConvertTemperature()
        {
            switch (SelectedOperation)
            {
                case "1":
                    Result = (Temperature * 9) / 5 + 32; ;
                    break;
                case "2":
                    Result = (Temperature - 32) * 5 / 9; ;
                    break;
            }
        }
    }    
}
