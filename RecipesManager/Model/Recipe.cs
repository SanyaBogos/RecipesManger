// -----------------------------------------------------------------------
// <copyright file="Recipe.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RecipesManager.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.Serialization;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [DataContract]
    public class Recipe
    {
        #region Properties
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<string> Ingredients { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int Time { get; set; }
        [DataMember]
        public string Complexity { get; set; }
        [DataMember]
        public string Energy { get; set; }
        [DataMember]
        public string Picture { get; set; }
        #endregion

        #region Ctors
        public Recipe() { }

        public Recipe(string name, string description, List<string> ingredient, string type, int time, string complexity, string energy)
        {
            Name = name; Description = description; Ingredients = ingredient; Type = type; Time = time; Complexity = complexity; Energy = energy;
        }
        #endregion

        #region Overrided
        public override string ToString()
        {
            string ingred = "";
            foreach (var ingredient in Ingredients)
                ingred += ingredient;
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}", Name, Description, ingred, Type, Time, Complexity, Energy);
        }
        #endregion
    }
}
