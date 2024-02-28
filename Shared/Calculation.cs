using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Calculation
{
    [Required]
    public int FirstNumber { get; set; }
    [Required]
    public int SecondNumber { get; set; }

    public string Expression { get; set; }

    public string Operator { get; set; }

    public int Sum { get; set; }
}
