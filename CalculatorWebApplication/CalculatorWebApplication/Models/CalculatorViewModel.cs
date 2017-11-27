using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Calculator;

namespace CalculatorWebApplication.Models
{
    public class CalculatorViewModel
    {

        [Required]
        [Display(Name = "Band A Color")]
        public string SelectedAColor { get; set; }

        [Required]
        [Display(Name = "Band B Color")]
        public string SelectedBColor { get; set; }

        [Required]
        [Display(Name = "Band C Color")]
        public string SelectedCColor { get; set; }

        [Display(Name = "Band D Color")]
        public string SelectedDColor { get; set; }

        public IEnumerable<SelectListItem> SignificantColors
        {
            get
            {
                return new SelectList(ColorCodes.Where(x => x.SignificantFigures.HasValue), "Code", "Name");
            }
        }

        public IEnumerable<SelectListItem> Colors
        {
            get
            {
                return new SelectList(ColorCodes, "Code", "Name");
            }
        }

        public IEnumerable<ColorCode> ColorCodes
        {
            get;set;
        }

        public double OhmValueMin { get; set; }
        public double OhmValueMax { get; set; }

    }
}