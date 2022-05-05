
using System.ComponentModel.DataAnnotations;
using HW_09.Models.Enum;
namespace HW_09.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public DateOnly Date_sabt { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateOnly Date_birthday { get; set; }

        [Display(Name = "کد ملی")]
        public int Codemeli { get; set; }

        [Display(Name = "نوع عضویت")]
        public MembershipEnum Typemember { get; set; }

        [Display(Name = "شماره تماس")]
        public string Tel { get; set; }

        [Display(Name = "جنسیت")]
        public GenderEnum Gender { get; set; }


    }
}
