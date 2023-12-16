using System.ComponentModel.DataAnnotations;
namespace MyBGList.Models
{
public class BoardGames_Domains
{
public BoardGame? BoardGame { get; set; }
public Domain? Domain { get; set; }

[Key]
[Required]
public int BoardGameId { get; set; }
[Key]
[Required]
public int DomainId { get; set; }
[Required]
public DateTime CreatedDate { get; set; }
}
}