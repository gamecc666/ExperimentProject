using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SpecialTestProject.Models
{
    public class Persion
    {
        public string Name { get; set; }
        //可空属性亲测可用
        public int? Age { get; set; }           
        public string Gender { get; set; }
        public string Email { get; set; }

    }
}