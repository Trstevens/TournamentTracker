using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the firstName of the player of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the lastName of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the EmailAdress of the person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellPhone number of the person.
        /// </summary>
        public string CellPhone { get; set; }
    }
}
