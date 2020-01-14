using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class PersonnelModel
    {
        public string EngOne { get; set; }
        public string EngTwo { get; set; }

        public PersonnelModel() { }

        public PersonnelModel(string engOne, string engTwo)
        {
            this.EngOne = engOne;
            this.EngTwo = engTwo;
        }
    }
}