using System;
using System.ComponentModel.DataAnnotations;

namespace DynamicPage.Models
{
    // مدل صفحه
    public class Page
    {
        public int Id { get; set; }

        [Display(Name = "عنوان صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        public string Title { get; set; }

        [Display(Name = "عنوان مرورگر")]
        [MaxLength(300)]
        public string BrowserTitle { get; set; }

        [Display(Name = "آدرس صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500)]
        public string Url { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "متن صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

    }
}