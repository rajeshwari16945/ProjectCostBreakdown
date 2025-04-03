using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

//Raja Rajeshwari Ganamukkula
//700763633
namespace GanamukkulaMidtermB.Models
{
    public class ProjectModel
    {
        //variable declaration
        [Required(ErrorMessage = "The Client name field is required.")]
        [Display(Name = "Client name: ")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The Normal Cost is required.")]
        [Display(Name = "Project Normal cost: $")]
        [Range(25000, 1000000, ErrorMessage = "Project Cost should be in the range of $25000 and $1000000")]
        [DataType(DataType.Currency)]
        public int NormalCost { get; set; }

        [Required(ErrorMessage = "The Project Priority field is required.")]
        [Display(Name = "Select Project Priority Level")]
        public string? PriorityLevel { get; set; }

        //variables to store result
        public double DevelopmentCosts { get; set; }
        public double TestingCosts { get; set; }
        public double DeploymentCosts { get; set; }
        public double ProfitMargin { get; set; }
        public double TotalProjectCost { get; set; }
        public void ProjectCostBreakdownCalculate()
        {
            //check priority level
            if (PriorityLevel == "Normal Priority") TotalProjectCost = NormalCost;
            else if (PriorityLevel == "Top Priority") TotalProjectCost = NormalCost * 1.5;
            else if (PriorityLevel == "Emergency Compliance") TotalProjectCost = NormalCost *2;
            //calculate the project cost and breakdown from TotalProjectCost
            DevelopmentCosts = TotalProjectCost * 30 / 100;
            TestingCosts = TotalProjectCost * 20 / 100;
            DeploymentCosts = TotalProjectCost * 25 / 100;
            ProfitMargin = TotalProjectCost * 25 / 100;
        }
    }//end class
}//end namespace
