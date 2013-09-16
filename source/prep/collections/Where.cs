using prep.utility.filtering;

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

  public static class RandomExtensions
  {
    public static IMatchA<Movie> equal_to(this MovieProductionStudio movieProductionStudio,
                                                 ProductionStudio productionStudio)
    {
      return movieProductionStudio(productionStudio);
    }
  }
}