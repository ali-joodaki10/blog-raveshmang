using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage ="{0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "زیر عنوان")]
        public string? SubTitle { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreateTime { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
