using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Save a new prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
