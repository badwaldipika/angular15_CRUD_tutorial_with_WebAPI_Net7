namespace TutorialAPI.Models;

public partial class Tutorial
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Published { get; set; }
}
