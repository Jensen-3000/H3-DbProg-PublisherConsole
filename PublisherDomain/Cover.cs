namespace PublisherDomain;

public class Cover
{
    public int CoverId { get; set; }
    public string Title { get; set; }
    public bool DigitalOnly { get; set; }
    public List<Artist> Artists { get; set; } = [];
    public Book Book { get; set; }
}
