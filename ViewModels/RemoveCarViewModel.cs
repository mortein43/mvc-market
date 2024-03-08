using System.ComponentModel.DataAnnotations;

namespace mvc_market.ViewModels;

public class RemoveCarViewModel
{
    [Required(ErrorMessage = "Введіть назву автомобіля")]
    public string CarName { get; set; }
}
