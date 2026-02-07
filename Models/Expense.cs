using System.ComponentModel.DataAnnotations;

namespace FinanceAPP.Models
{
    public class Expense
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public double Amount { get; set; }
        [Required]
        [Range(0.01 , double.MaxValue,ErrorMessage = "Amount should be higher than 0 and lower than double.MaxValue!")]
        public string Category { get; set; } = null!;
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
