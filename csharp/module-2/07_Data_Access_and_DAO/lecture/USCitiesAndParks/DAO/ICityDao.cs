using System.Collections.Generic;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public interface ICityDao //contract that city DAO has to fill, Data Access Object
    {
        City GetCity(int cityId);

        IList<City> GetCitiesByState(string stateAbbreviation);

        City CreateCity(City city);

        void UpdateCity(City city);

        void DeleteCity(int cityId);
    }
}
