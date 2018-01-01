using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoLib.Models
{
    public class Movie
    {
        public Int16 Id { get; set; }
        public String Name { get; set; }
    }
}//POCO Plain Old CLR Object 
//   assuming the action that we want to do choosing a movie falls under 
//    route  /movie/random movies controller with action called random