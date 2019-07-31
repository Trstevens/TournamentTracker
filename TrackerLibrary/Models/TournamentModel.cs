using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the tournament name of the model.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represenets the Entry Fee of the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of Entered Teams in the object team model.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a list of Prizes in the object PrizeModel.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a list of a list of Matchup Model which acts as each round in the MathchupModel 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
