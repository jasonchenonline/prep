namespace prep.collections
{
  public delegate ProductionStudio MovieProductionStudio(Movie movie);

  public class Where<ItemToMatch>
  {
    public static MovieProductionStudio has_a(MovieProductionStudio movie_production_studio)
    {
      return movie_production_studio;
    }
  }
}