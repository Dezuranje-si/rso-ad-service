﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RSO.Core.AdModels;

public partial class Ad
{
    [Key]
    public int ID { get; set; }

    [Column(TypeName = "char")]
    public char Thing { get; set; }

    public int? Price { get; set; }

    [Column(TypeName = "char")]
    public char? Category { get; set; }

    public DateTime PostTime { get; set; }
}