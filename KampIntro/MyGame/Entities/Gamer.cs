using MyGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Entities
{
    public class Gamer : IEntity
    {
        public int GamerID { get; set; }
        public string GamerFirstname { get; set; }
        public string GamerLastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
