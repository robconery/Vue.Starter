using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Isopoh.Cryptography.Argon2;
namespace Vue.Kit.Models;
[Index(nameof(Email), IsUnique = true)]
public class User
{
  public static User Register(string email, string name, string password)
  {
    //hash the password
    var hashed = Argon2.Hash(password);
    var user = new User
    {
      Email = email,
      Name = name,
      HashedPassword = hashed
    };
    return user;
  }
  public bool Login(string email, string password){

  }
  
  [DatabaseGenerated(DatabaseGeneratedOption.None)]
  [Key]
  public int ID { get; set; }
  public string? Name { get; set; }
  public string? HashedPassword { get; set; }
  [Required]
  public string? Email { get; set; }
  public DateTime LastLogin { get; set; } = new DateTime();
}

