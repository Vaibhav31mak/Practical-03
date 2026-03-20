namespace Inheritance;

internal class Team : Sponsor
{
    private string TeamName;

    public Team(string teamName)
    {
        this.TeamName = teamName;
    }
    /// <summary>
    /// Returns team and sponsor information.
    /// Return Type: string
    /// </summary>
    public string PrintInfo()
    {
        return $"{TeamName} is sponsored by {Owner}";
    }
}
