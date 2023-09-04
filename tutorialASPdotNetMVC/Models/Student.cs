using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace tutorialASPdotNetMVC.Models
{
    public class Student
    {
        [Key] // set id to primary key to random generate id
        public int Id { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนชื่อนักเรียน")]
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }
        [DisplayName("คะแนนสอบ")]
        [Range(0,100,ErrorMessage = "กรุณาป้อนคะแนนสอบ 0-100 เท่านั้น")]
        public int Score { get; set; }
    }
}
