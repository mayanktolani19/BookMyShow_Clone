using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow_Clone.Models;

public class BaseDomainEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
}
