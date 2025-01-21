﻿using GraphQL.Types;

namespace Propagator.Infrastucture.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Salary { get; set; }
}
