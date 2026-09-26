using System;
using System.Collections.Generic;

namespace NgoThiLe_2410900046.Models;

public partial class Ngothilestudent
{
    public long Id { get; set; }

    public string? NgothileName { get; set; }

    public string? NgothileGender { get; set; }

    public DateTime? NgothileBirthday { get; set; }

    public string? NgothileEmail { get; set; }

    public string? NgothilePhone { get; set; }

    public bool? NgothileActive { get; set; }
}
