using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "This field is requaried.")]
        [MaxLength(50, ErrorMessage = "Maximum 50 simbols.")]

        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Employee Surnname")]
        [Required(ErrorMessage = "This field is required.")]

        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Employee patronymic")]
        [Required(ErrorMessage = "This field is required.")]
        public string Patronymic { get; set; }

        [Column(TypeName = "nvarchar(9)")]
        [DisplayName("Passport Id")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(9, ErrorMessage = "Maximum 9 characters only")]
        public string PassportId { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Phone")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Address")]
        [Required(ErrorMessage = "This field is required.")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
