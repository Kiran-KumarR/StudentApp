﻿using System;
using System.Collections.Generic;

namespace StudentApp.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }
}
