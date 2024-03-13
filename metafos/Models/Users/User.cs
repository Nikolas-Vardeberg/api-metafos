using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace metafos.Models.Users;

public class User {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id {get;set;}

   public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
}

public abstract class UserService {
    public static List<User> GetUsers() {
        return new List<User>() {
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos",
                },
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos"
                },
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos"
                },
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos"
                },
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos"
                },
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos"
                },
                new User() {
                    Email = "test@test.no",
                    Password = "1234",
                    Username = "metafoos"
                }
        };
    }
}