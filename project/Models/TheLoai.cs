﻿using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Không được để trống Tên thể loại!")]
        [Display(Name="Thể loại")]
        public string Name { get; set; }
        [Required(ErrorMessage="Không đúng định dạng ngày!")]
        [Display(Name="Ngày Tạo")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
